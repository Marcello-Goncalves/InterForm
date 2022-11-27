using System.Globalization;

namespace InterForm
{
    internal class AppLang
    {
        internal string? formTitle;
        internal string? btnSystem;
        internal string? btnPT;
        internal string? btnES;
        internal string? btnEN;

        internal AppLang(string formTitle,string btnSystem, string btnPT, string btnES, string btnEN) 
        { 
            this.formTitle  = formTitle;
            this.btnSystem  = btnSystem;
            this.btnPT      = btnPT;
            this.btnES      = btnES;
            this.btnEN      = btnEN;
        }

        internal static AppLang Pt() {return new AppLang("Internacionalização" , "Predefinição do Sistema",  "Português",    "Espanhol", "Inglês" );}
        internal static AppLang Es() {return new AppLang("internacionalización", "Preajuste del Sistema",    "Portugués",    "Español",  "Inglés" );}
        internal static AppLang En() {return new AppLang("Internationalization", "System Default",           "Portuguese",   "Spanish",  "English");}

        internal static AppLang Sys() 
        {
            switch(CultureInfo.CurrentUICulture.Parent.ToString().ToLower())
            {
                case "pt":  return Pt();
                case "es":  return Es();
                default:    return En();
            }
        }
    }
}
