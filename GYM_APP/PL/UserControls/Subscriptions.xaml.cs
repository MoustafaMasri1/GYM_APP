using System.Windows;
using System.Linq;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Controls;

namespace GYM_APP.PL.UserControls
{
    /// <summary>
    /// Interaction logic for NewSUB.xaml
    /// </summary>
    public partial class NewSUB : UserControl
    { 
        public NewSUB()
        {
            InitializeComponent();
        }
       
        private void dg_Subscriptions_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

        }

        private void dg_Subscriptions_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_DeleteRecord_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void chk_ShowDeleteBtns_Selected(object sender, RoutedEventArgs e)
        {
            col_btn_Delete.Visibility = Visibility.Visible;
        }

        private void chk_ShowDeleteBtns_Unselected(object sender, RoutedEventArgs e)
        {
            col_btn_Delete.Visibility = Visibility.Collapsed;
        }

        private void chk_EnableEditing_Selected(object sender, RoutedEventArgs e)
        {
            dg_Subscriptions.IsReadOnly = false;
        }

        private void chk_EnableEditing_Unselected(object sender, RoutedEventArgs e)
        {
            dg_Subscriptions.IsReadOnly = true;
        }
        private void textSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
