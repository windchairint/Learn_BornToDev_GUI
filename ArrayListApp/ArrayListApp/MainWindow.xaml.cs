using System;
using System.Collections;
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

namespace ArrayListApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                arrayList.Add(txtData.Text);
                int LastDataAdd = arrayList.Count - 1;
                if (txtData.Text == arrayList[LastDataAdd].ToString())
                {
                    MessageBox.Show("You Added Data : " + arrayList[LastDataAdd].ToString());
                }
                else
                {
                    MessageBox.Show("Else Case");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (arrayList.Count != 0)
                {
                    arrayList.Remove(txtData.Text);
                    MessageBox.Show("You Removed Data : " + txtData.Text);
                }
                else
                {
                    MessageBox.Show("Else Case");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnShowall_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (var item in arrayList)
                {
                    for (int i = 0; i < arrayList.Count; i++)
                    {
                        MessageBox.Show("You Data Number " + (i + 1) + " : " + item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
