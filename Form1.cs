using static InterForm.AppLang;

namespace InterForm
{
    public partial class Form1 : Form
    {
        public Form1()  => InitializeComponent();

        private void radioButtonSystem_CheckedChanged       (object sender, EventArgs e) => Choice(Sys());
        private void radioButtonPortuguese_CheckedChanged   (object sender, EventArgs e) => Choice(Pt());
        private void radioButtonSpanish_CheckedChanged      (object sender, EventArgs e) => Choice(Es());
        private void radioButtonEnglish_CheckedChanged      (object sender, EventArgs e) => Choice(En());
        
        private void Choice(AppLang lang)
        {
            Text                        = lang.formTitle;
            radioButtonSystem.Text      = lang.btnSystem;
            radioButtonPortuguese.Text  = lang.btnPT;
            radioButtonSpanish.Text     = lang.btnES;
            radioButtonEnglish.Text     = lang.btnEN;
        }
    }
}