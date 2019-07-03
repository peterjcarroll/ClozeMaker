using System;
using System.Linq;
using System.Windows.Forms;

namespace ClozeMaker
{
    public partial class Form1 : Form
    {
        private readonly ClozeService _clozeService = new ClozeService();

        public Form1()
        {
            InitializeComponent();
            txtExclude.Lines = _clozeService.OptionWords.ToArray();
        }

        private void TxtSource_TextChanged(object sender, EventArgs e)
            => UpdateCloze();

        private void TxtExclude_TextChanged(object sender, EventArgs e)
        {
            _clozeService.OptionWords.Clear();
            _clozeService.OptionWords.AddRange(txtExclude.Lines);

            UpdateCloze();
        }

        private void UpdateCloze()
            => txtCloze.Lines = txtSource.Lines.Select(_clozeService.ClozeLine).ToArray();
    }
}