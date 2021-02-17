﻿using HotelP.Helpers.PaymentsHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelP.Forms
{
    public partial class PaymentsForm : Form
    {
        public PaymentsForm()
        {
            InitializeComponent();
        }

        private void LoadAllButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PaymentsHelper.LoadPayments();
        }

        private void ResetViewButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
