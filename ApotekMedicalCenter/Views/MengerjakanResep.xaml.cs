﻿using System;
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

namespace ApotekMedicalCenter.Views
{
    /// <summary>
    /// Interaction logic for MengerjakanResep.xaml
    /// </summary>
    public partial class MengerjakanResep : Window
    {
        public MengerjakanResep()
        {
            InitializeComponent();
        }
        private void CloseButtonMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void MaximizeButtonMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }

        private void ChangeViewButtonMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Normal;
        }

        private void MinimizeButtonMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void DragableGridMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
