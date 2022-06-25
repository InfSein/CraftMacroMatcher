using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftMacroMatcher
{
    internal class ProgramDatas
    {
        public static string MacroMatcherPatch = "1.0.0 alpha2";

        public const string ProjectPath = @"https://github.com/InfSein/CraftMacroMatcher";
        public const string DonatePath  = @"https://afdian.net/@infsein";

        public static string ProcessPath = Environment.CurrentDirectory + "\\CraftProcesses.json";
        public static string FoodPath = Environment.CurrentDirectory + "\\Foods.json";
        public static string TincPath = Environment.CurrentDirectory + "\\Tincs.json";
    }
}
