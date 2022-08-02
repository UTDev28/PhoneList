using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhoneList
{
    public partial class ImportedPhoneForm : Form
    {
        public ImportedPhoneForm()
        {
            InitializeComponent();
        }

        private void uvuPhoneDirectoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uvuPhoneDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uVUPhoneNumsDataSet);

        }

        private void uvuPhoneDirectoryBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.uvuPhoneDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uVUPhoneNumsDataSet);

        }

        private void ImportedPhoneForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uVUPhoneNumsDataSet.UvuPhoneDirectory' table. You can move, or remove it, as needed.
            this.uvuPhoneDirectoryTableAdapter.Fill(this.uVUPhoneNumsDataSet.UvuPhoneDirectory);

        }

        private void uvuPhoneDirectoryBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.uvuPhoneDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uVUPhoneNumsDataSet);

        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uvuPhoneDirectoryIdLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uvuPhoneDirectoryIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void uvuPhoneDirectoryIdLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void uvuPhoneDirectoryIdLabel1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
