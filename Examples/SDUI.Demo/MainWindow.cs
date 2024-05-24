﻿using SDUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDUI.Demo
{
    public partial class MainWindow : UIWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            BackColor = Color.Transparent;
            ColorScheme.BackColor = Color.Black;
        }
    }
}
