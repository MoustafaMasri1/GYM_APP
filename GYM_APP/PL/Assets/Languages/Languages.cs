using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GYM_APP.PL.Assets.Languages
{
    class Languages
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public static void FillLanguageComboBox(ComboBox cmb_language)
        {
            List<Languages> languages = new List<Languages>();
            languages.Add(new Languages() { Name = "العربية", Code = "Lang_AR" });
            languages.Add(new Languages() { Name = "English", Code = "Lang_EN" });
            cmb_language.ItemsSource = languages;
            cmb_language.DisplayMemberPath = "Name";
            cmb_language.SelectedValuePath = "Code";
        }
    }
}
