using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using GYM_APP.PL.Assets.Classes;
using MaterialDesignThemes.Wpf;

namespace GYM_APP.PL.UserControls
{
    public partial class Theme : UserControl
    {
        public Theme()
        {
            InitializeComponent();
            Loaded += Theme_Control_Loaded;
        }

        private void Theme_Control_Loaded(object sender, RoutedEventArgs e)
        {
            if (iniFile.KeyExists("DarkMode", "Theme"))
            {
                EnableDarkMode(Convert.ToBoolean(iniFile.Read("DarkMode", "Theme")));
                IsDarkMode.IsChecked = Convert.ToBoolean(iniFile.Read("DarkMode", "Theme"));
            }
            if (iniFile.KeyExists("PrimaryColor", "Theme"))
            {
                string primaryColor = iniFile.Read("PrimaryColor", "Theme");
                ChangeAppColor.ChangePrimaryColor(paletteHelper, (Color)ColorConverter.ConvertFromString(primaryColor));
                ChangeAppColor.ChangeSecondaryColor(paletteHelper, (Color)ColorConverter.ConvertFromString(primaryColor));
                PrimaryColor.Color = (Color)ColorConverter.ConvertFromString(primaryColor);
                
            }


        }
        #region DarkMode And App Color
        private PaletteHelper paletteHelper = new PaletteHelper();
        IniFile iniFile = new IniFile("Settings.ini");
        private void EnableDarkMode(bool isDark)
        {
            ITheme theme = paletteHelper.GetTheme();
            IBaseTheme baseTheme = isDark ? new MaterialDesignDarkTheme() : (IBaseTheme)new MaterialDesignLightTheme();
            theme.SetBaseTheme(baseTheme);
            paletteHelper.SetTheme(theme);
            iniFile.Write("DarkMode", isDark.ToString(), "Theme");
        }
        private void IsDarkMode_Checked(object sender, RoutedEventArgs e)
        {
            EnableDarkMode(true);
        }

        private void IsDarkMode_Unchecked(object sender, RoutedEventArgs e)
        {
            EnableDarkMode(false);
            ChangeAppColor.ChangePrimaryColor(paletteHelper, Colors.White);
            ChangeAppColor.ChangeSecondaryColor(paletteHelper, Colors.White);
            ChangeAppColor.ChangePrimaryColor(paletteHelper, PrimaryColor.Color);
            ChangeAppColor.ChangeSecondaryColor(paletteHelper, PrimaryColor.Color);
        }
        // Change PrimaryColor
        private void PrimaryColor_PreviewMouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ChangeAppColor.ChangePrimaryColor(paletteHelper, PrimaryColor.Color);
            iniFile.Write("PrimaryColor", PrimaryColor.Color.ToString(), "Theme");
            ChangeAppColor.ChangeSecondaryColor(paletteHelper, PrimaryColor.Color);

        }
        #endregion

        private void PrimaryColor_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
    }
}
