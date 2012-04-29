using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrinityCore_DBGUI_Library
{

    public class SearchResultFormatRule
    {

        public enum RuleType { Colour };

        public RuleType Type;
        public String MatchField;
        public String MatchValue;

        public String Colour;
    }
}
