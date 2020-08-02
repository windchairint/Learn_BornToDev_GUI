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

namespace Learn_BornToDev_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double Income = double.Parse(txtIncome.Text);
                double Expenditure = double.Parse(txtExpenditure.Text);
                double Thing = double.Parse(txtThing.Text);

                double Balance = Income - Expenditure;
                double Assess = Thing / Balance;

                txtAssess.Text = Assess.ToString();
                txtAssess.IsReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
            
        }
    }
}
