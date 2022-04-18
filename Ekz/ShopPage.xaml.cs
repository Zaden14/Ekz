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

namespace Ekz
{
    /// <summary>
    /// Логика взаимодействия для ShopPage.xaml
    /// </summary>
    public partial class ShopPage : Page
    {
        List<TableEkz> BookCor = new List<TableEkz>();
        public ShopPage()
        {
            InitializeComponent();

            LVList.ItemsSource = DateBase.DB.TableEkz.ToList();
        }

        private void BTKor_Click(object sender, RoutedEventArgs e)
        {
            var selectedList = LVList.SelectedItems;
            TBKol.Text = "  " + selectedList.Count;
            int AllSum = 0;
            foreach (TableEkz i in selectedList)
            {
                AllSum += (int) i.Cost;
                BookCor.Add(book);
            }
            TBCost.Text = "  " + AllSum;
        }

        private void BTPer_Click(object sender, RoutedEventArgs e)
        {
            KorWindow win = new KorWindow(BookCor);
            win.ShowDialog();
        }
    }
}
