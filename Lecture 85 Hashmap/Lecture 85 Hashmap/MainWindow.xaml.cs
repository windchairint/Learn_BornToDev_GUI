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

namespace Lecture_85_Hashmap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Add
            hashtable.Add(txtKey.Text,txtValue.Text);
            MessageBox.Show("You Added Data : " + "Key = " + txtKey.Text + " Value = " + txtValue.Text);
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            hashtable.Remove(txtKey.Text);
            MessageBox.Show("You Removed Data Key : " + txtKey.Text);
        }

        private void BtnShowAll_Click(object sender, RoutedEventArgs e)
        {
            //Show All
            ICollection ico = hashtable.Keys;
            foreach (string key in ico)
            {
                for (int i = 0; i < ico.Count; i++)
                {
                    MessageBox.Show("Your Data Key : "+ key + " Value : " + hashtable[key].ToString());
                }
            }
        }
    }
}
