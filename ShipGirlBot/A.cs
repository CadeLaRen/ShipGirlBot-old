﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


public partial class A : Form
{
    public A(string text)
    {
        InitializeComponent();
        textBox1.Text = text;
        textBox1.Select(0, 0);
        textBox1.ScrollToCaret();
    }
    
}