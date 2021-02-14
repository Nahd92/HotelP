using HotelP.Helpers.StoredProcedure;
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
    public partial class StoredProcedure : Form
    {
        public StoredProcedure()
        {
            InitializeComponent();
            Shown += StoredProcedure_Shown;
        }

        private void StoredProcedure_Shown(object sender, EventArgs e)
        {
            STListbox.DataSource = SPHelpers.GetAllStoredProceduresNames();
        }

        private void ClearViewBtn_Click(object sender, EventArgs e)
        {
            StoredProcedureDefinitionTextBox.Text = "";
        }

        private void GetDetails()
        {
            StoredProcedureDefinitionTextBox.Text = string.Join(" ", SPHelpers.GetStoredProcedureContent(STListbox.Text));
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            GetDetails();
        }

        private void STListbox_DoubleClick(object sender, EventArgs e)
        {
            GetDetails();
        }
    }
}
