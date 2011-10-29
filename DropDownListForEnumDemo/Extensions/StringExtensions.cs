using System.Text.RegularExpressions;

namespace DropDownListForEnumDemo.Extensions {

    public static class StringExtensions {
        public static string FromCamelToProperCase(this string str) {
            return Regex.Replace(str, "(?<=[a-z])(?<x>[A-Z])|(?<=.)(?<x>[A-Z])(?=[a-z])|(?<=[^0-9])(?<x>[0-9])(?=.)", " $1");
        }
    }

}