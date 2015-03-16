using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;
using System.Diagnostics;

namespace Honcho
{
    public static class Extensions
    {
        private const int ComboBoxPadding = 25;

        public static void SetComboBoxToEnum<T>(this ComboBox comboBox, Func<T, string> displayFunction, EventHandler onSelectedValueChanged = null) where T : struct
        {
            if (comboBox == null)
            {
                throw new ArgumentNullException("comboBox");
            }

            if (displayFunction == null)
            {
                throw new ArgumentNullException("displayFunction");
            }

            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("Type parameter must be an enumeration.");
            }
            
            comboBox.DataSource = Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(v => new KeyValuePair<string, T>(displayFunction(v), v))
                .ToList();
            comboBox.ValueMember = "Value";
            comboBox.DisplayMember = "Key";
            comboBox.Width = ComboBoxPadding + comboBox.Items
                .Cast<KeyValuePair<string, T>>()
                .Max(kvp => TextRenderer.MeasureText(kvp.Key, comboBox.Font).Width);

            if (onSelectedValueChanged != null)
            {
                comboBox.SelectedValueChanged += onSelectedValueChanged;
                onSelectedValueChanged(new Object(), new EventArgs()); // Force an update.
            }
        }

        public static DaysOfTheWeek ToTaskSchedulerDay(this DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return DaysOfTheWeek.Sunday;
                case DayOfWeek.Monday:
                    return DaysOfTheWeek.Monday;
                case DayOfWeek.Tuesday:
                    return DaysOfTheWeek.Tuesday;
                case DayOfWeek.Wednesday:
                    return DaysOfTheWeek.Wednesday;
                case DayOfWeek.Thursday:
                    return DaysOfTheWeek.Thursday;
                case DayOfWeek.Friday:
                    return DaysOfTheWeek.Friday;
                case DayOfWeek.Saturday:
                    return DaysOfTheWeek.Saturday;
                default:
                    Debug.Fail(string.Format("Somehow got a day of the week that no one knows about: {0}", Enum.GetName(typeof(DayOfWeek), dayOfWeek)));
                    return (DaysOfTheWeek)0;
            }
        }
    }
}
