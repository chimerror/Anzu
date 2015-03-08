using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace Badgerer
{
    internal class Options
    {
        [ParserState]
        public IParserState ParserState { get; set; }

        [Option("displayTimeInMs", Required = true)]
        public int DisplayTimeInMs { get; set; }

        [Option("showAsNormalWindow", DefaultValue = false)]
        public bool ShowAsNormalWindow { get; set; }

        [Option("dontMaximize", DefaultValue = false)]
        public bool DontMaximize { get; set; }

        [Option("dontLock", DefaultValue = false)]
        public bool DontLock { get; set; }
    }
}
