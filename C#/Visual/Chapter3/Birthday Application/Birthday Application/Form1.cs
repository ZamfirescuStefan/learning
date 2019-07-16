﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birthday_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string birthday = dayOfWeekBox.Text + ", " + nameOfMonthBox.Text + " " + dayOfMonthBox.Text + ", " + yearBox.Text;
            dateOutputLabel.Text = birthday;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekBox.Text = "";
            nameOfMonthBox.Text = "";
            dayOfMonthBox.Text = "";
            yearBox.Text = "";
            dateOutputLabel.Text = "";
        }
    }
}
