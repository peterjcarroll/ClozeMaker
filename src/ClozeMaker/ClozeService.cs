using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClozeMaker
{
    public class ClozeService
    {
        private const string WordRegexPattern = "([a-zA-ZÀ-ÖØ-öø-ȳЀ-ӹ]+)";

        private readonly static List<string> _defaultOptionWords = new List<string>
        {
            "ја",
            "он",
            "она",
            "те-ве",
            "не",
            "nми",
            "они"
        };

        public ClozeService() : this(_defaultOptionWords)
        {
        }

        public ClozeService(List<string> optionWords, bool includeOptionWords = false)
        {
            OptionWords = optionWords;
            Include = includeOptionWords;
        }

        public List<string> OptionWords { get; }

        public bool Include { get; set; }

        public string ClozeLine(string line)
        {
            var cloze = Regex.Replace(line, WordRegexPattern, ProcessOptionWords);
            var count = 1;
            while (cloze.Contains("%#"))
            {
                var i = cloze.IndexOf("%#");
                cloze = cloze.Substring(0, i) + count.ToString() + cloze.Substring(i + 2);
                count++;
            }

            return cloze;
        }

        private string ProcessOptionWords(Match match)
        {
            if (Include && OptionWords.Any(o => match.Value.Equals(o, StringComparison.InvariantCultureIgnoreCase)))
                return "{{c%#::" + match.Value + "}}";

            if (!Include && OptionWords.Any(o => match.Value.Equals(o, StringComparison.InvariantCultureIgnoreCase)))
                return match.Value;

            return Include ? match.Value : "{{c%#::" + match.Value + "}}";
        }
    }
}