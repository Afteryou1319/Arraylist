using System.Collections;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArraylistApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Button_Showall(object sender, RoutedEventArgs e)
        {

            foreach (var item in arrayList)
            {
                MessageBox.Show(item.ToString());
            } 
            //MessageBox.Show(" - " + arrayList.Count.ToString());
        }

        private void Button_Remove(object sender, RoutedEventArgs e)
        {
            string remove = txtname.Text;

            if (arrayList.Contains(remove))
            {
                arrayList.Remove(remove);
            }
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            arrayList.Add(txtname.Text.ToString());

        }
    }
}