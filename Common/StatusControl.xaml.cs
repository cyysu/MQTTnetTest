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

namespace MqttTest.Common
{
    /// <summary>
    /// Interaction logic for StatusControl.xaml
    /// </summary>
    public partial class StatusControl : UserControl
    {
        public event EventHandler ResetClicked;

        public StatusControl()
        {
            InitializeComponent();
        }

        private void BReset_Click(object sender, RoutedEventArgs e)
        {
            ResetClicked?.Invoke(this, e);
        }
    }
}
