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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kt_4
{
    /// <summary>
    /// Логика взаимодействия для BillingWindow.xaml
    /// </summary>
    public partial class BillingWindow : Window
    {
        public BillingWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            SizeToContent = SizeToContent.Manual;
            DGridBilling.ItemsSource = kt_4Entities.GetContext().Billing.ToList();
        }
    }
}