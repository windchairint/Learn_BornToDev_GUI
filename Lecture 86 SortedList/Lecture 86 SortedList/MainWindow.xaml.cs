﻿using System;
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

namespace Lecture_86_SortedList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Add
            sortedList.Add(int.Parse(txtKey.Text),txtValue.Text);

            //Show
            ICollection collection = sortedList.Keys;

            string data = "";

            foreach (int key in collection)
            {
                data = data + " " + "\n" + sortedList[key].ToString();

            }
            MessageBox.Show("Count = : " + collection.Count + data + " ");
        }
    }
}
