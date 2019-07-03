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
            rdoExcludeWords.Checked = !_clozeService.Include;
            rdoIncludeWords.Checked = _clozeService.Include;
        }

        private void TxtSource_TextChanged(object sender, EventArgs e)
            => UpdateCloze();

        private void TxtExclude_TextChanged(object sender, EventArgs e)
        {
            _clozeService.OptionWords.Clear();
            _clozeService.OptionWords.AddRange(txtExclude.Lines);

            UpdateCloze();
        }

        private void RdoExcludeWords_CheckedChanged(object sender, EventArgs e)
        {
            var radio = sender as RadioButton;

            _clozeService.Include = !radio.Checked;
            UpdateCloze();
        }

        private void UpdateCloze()
            => txtCloze.Lines = txtSource.Lines.Select(_clozeService.ClozeLine).ToArray();
    }
}