using HotelP.Helpers.Queries;
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
    public partial class Queries : Form
    {
        public Queries()
        {
            InitializeComponent();
            Shown += Queries_Shown;
        }

        private void Queries_Shown(object sender, EventArgs e)
        {
            ListWithQueries.DataSource = QueriesHelper.GetAllTextFiles();
        }
        private void GetDetails()
        {
            TextForQueries.Text = QueriesHelper.LoadFilesToList(ListWithQueries.Text);
        }

        private void ListWithQueries_DoubleClick(object sender, EventArgs e)
        {
            GetDetails();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TextForQueries.Text = "";
        }
    }
}
