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
using System.Windows.Shapes;

namespace Ekz
{
    /// <summary>
    /// Логика взаимодействия для KorWindow.xaml
    /// </summary>
    public partial class KorWindow : Window
    {
        List<TableEkz> Kor;
        public KorWindow()
        {
            InitializeComponent();
            LVKList.Items.Clear();
            LVKList.ItemsSource = Kor;
        }
    }
}
