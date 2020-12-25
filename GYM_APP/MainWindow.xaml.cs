using System;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using GYM_APP.PL.Assets.Classes;
using GYM_APP.PL.Assets.Languages;
using Microsoft.Win32;

namespace GYM_APP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        [DllImport("gdi32.dll", EntryPoint = "AddFontResourceW", SetLastError = true)]
        public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)]
                                         string lpFileName);
        IniFile ini = new IniFile("Settings.ini");
        public MainWindow()
        {
            //// Change Language For Full Changes
            #region Change Language
            if (ini.KeyExists("Language", "AppSettings"))
            {
                string langCode = ini.Read("Language", "AppSettings");
                LoadStringResource(langCode);
                if (langCode == "Lang_AR")
                {
                    FlowDirection = FlowDirection.RightToLeft;
                    CultureInfo ci = new CultureInfo("ar");
                    Thread.CurrentThread.CurrentCulture = ci;
                    Thread.CurrentThread.CurrentUICulture = ci;
                }
            }
            #endregion

            //// install font Before lanuching
            #region Install Fonts
            AddFontResource(AppDomain.CurrentDomain.BaseDirectory + "/Assets/Cairo-Black.ttf");
            AddFontResource(AppDomain.CurrentDomain.BaseDirectory + "/Assets/Cairo-Bold.ttf");
            AddFontResource(AppDomain.CurrentDomain.BaseDirectory + "/Assets/Cairo-ExtraLight.ttf");
            AddFontResource(AppDomain.CurrentDomain.BaseDirectory + "/Assets/Cairo-Light.ttf");
            AddFontResource(AppDomain.CurrentDomain.BaseDirectory + "/Assets/Cairo-Regular.ttf");
            AddFontResource(AppDomain.CurrentDomain.BaseDirectory + "/Assets/Cairo-SemiBold.ttf");
            #endregion
            InitializeComponent();
            StateChanged += MainWindowStateChangeRaised;
           
        }
        private void LoadStringResource(string Path)
        {
            var res_Language = new ResourceDictionary();

            res_Language.Source = new Uri("pack://application:,,,/PL/Assets/Languages/" + Path +".xaml", UriKind.Absolute);
            var cur_Language = Application.Current.Resources.MergedDictionaries.FirstOrDefault(
                             m => m.Source.OriginalString.EndsWith("Lang_EN.xaml"));
            if (cur_Language != null)
            {
                Application.Current.Resources.MergedDictionaries.Remove(cur_Language);
            }
            Application.Current.Resources.MergedDictionaries.Add(res_Language);
            //Application.Current.Resources["MaterialFont_AR_EN"] = new FontFamily("Rubik") as FontFamily;
            ini.Write("Language", Path, "AppSettings");
        }

        #region Windows Chrome
        // Can execute
        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        // Minimize
        private void CommandBinding_Executed_Minimize(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        // Maximize
        private void CommandBinding_Executed_Maximize(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MaximizeWindow(this);
        }

        // Restore
        private void CommandBinding_Executed_Restore(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.RestoreWindow(this);
        }

        // Close
        private void CommandBinding_Executed_Close(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        // State change
        private void MainWindowStateChangeRaised(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                MainWindowBorder.BorderThickness = new Thickness(8);
                RestoreButton.Visibility = Visibility.Visible;
                MaximizeButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                MainWindowBorder.BorderThickness = new Thickness(0);
                RestoreButton.Visibility = Visibility.Collapsed;
                MaximizeButton.Visibility = Visibility.Visible;
            }
        }
        #endregion
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GymSoftware");
            key.SetValue("Width", this.Width);
            key.SetValue("Height", this.Height);
            key.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Languages.FillLanguageComboBox(cmb_Language);
            LoadAppSettings();
        }
        private void LoadAppSettings()
        {
            //// Application language
            if (ini.KeyExists("Language", "AppSettings"))
            {
                string langCode = ini.Read("Language", "AppSettings");
                LoadStringResource(langCode);
                if (langCode == "Lang_AR")
                {
                    FlowDirection = FlowDirection.RightToLeft;
                    CultureInfo ci = new CultureInfo("ar");
                    Thread.CurrentThread.CurrentCulture = ci;
                    Thread.CurrentThread.CurrentUICulture = ci;
                }
                cmb_Language.SelectedValue = langCode;
            }
            else
            {
                cmb_Language.SelectedIndex = 1;
            }
            //// Windows Height And Width
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\GymSoftware");
            if (key != null)
            {
                double width = double.Parse(key.GetValue("Width").ToString());
                double height = double.Parse(key.GetValue("Height").ToString());
                this.Width = width;
                this.Height = height;
            }
        }

        private void cmb_Language_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string langCode = cmb_Language.SelectedValue.ToString();
            LoadStringResource(langCode);
            if (langCode == "Lang_AR")
            {
                FlowDirection = FlowDirection.RightToLeft;
                CultureInfo ci = new CultureInfo("ar");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
            }
            else
            {
                FlowDirection = FlowDirection.LeftToRight;
                CultureInfo ci = new CultureInfo("en");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
            }
        }
    }
}
