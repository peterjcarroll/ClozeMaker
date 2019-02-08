using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClozeMaker
{
    public partial class Form1 : Form
    {
        private static Regex _wordRegex = new Regex(@"([a-zA-ZÀ-ÖØ-öø-ȳЀ-ӹ]+)");
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            txtCloze.Lines = MakeCloze(txtSource.Lines);
        }

        private string[] MakeCloze(string[] sourceLines)
        {
            var clozeLines = new List<string>();

            foreach (string line in sourceLines)
            {
                string cloze = UnclozeExcludedWords(_wordRegex.Replace(line, "{{c%#::$1}}"));
                int count = 1;
                while (cloze.Contains("%#"))
                {
                    int i = cloze.IndexOf("%#");
                    cloze = cloze.Substring(0, i) + count.ToString() + cloze.Substring(i + 2);
                    count++;
                }
                clozeLines.Add(cloze);
            }

            return clozeLines.ToArray();
        }

        private string UnclozeExcludedWords(string sourceCloze)
        {
            string unclozed = sourceCloze;

            //var excludeWords = new string[]
            //{
            //   "ја",
            //   "он",
            //   "она",
            //   "те-ве",
            //   "не",
            //   "ми",
            //   "они",
            //};
            string[] excludeWords = txtExclude.Lines;

            foreach (string excludeWord in excludeWords)
            {
                string toMatch = "{{c%#::" + excludeWord + "}}";
                int i = unclozed.IndexOf(toMatch, StringComparison.InvariantCultureIgnoreCase);
                if (i >= 0)
                {
                    string matchedTerm = unclozed.Substring(i, toMatch.Length);
                    string originalWord = matchedTerm.Substring(7, excludeWord.Length);
                    unclozed = unclozed.Replace(matchedTerm, originalWord);
                }
            }

            return unclozed;
        }
    }
}
