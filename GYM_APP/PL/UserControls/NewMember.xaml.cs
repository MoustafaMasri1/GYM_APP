
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GYM_APP.PL.UserControls
{
    /// <summary>
    /// Interaction logic for NewMember_Control.xaml
    /// </summary>
    public partial class NewMember : UserControl
    {
        public NewMember()
        {
            InitializeComponent();
            //BitmapImage logo = new BitmapImage();
            //logo.BeginInit();
            //logo.UriSource = new Uri(@"C:\Users\Moustafa Masri\Desktop\Arm.png");
            //logo.EndInit(); // Getting the exception here
            //ProfilePIC.Source = logo;
            //ProfilePIC.Visibility = Visibility.Visible;


            //myImage.Source = new BitmapImage(new Uri(@"/Images/foo.png", UriKind.Relative));
        }
    }
}
