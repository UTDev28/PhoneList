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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        //Named BtnClose but the click event is naming it button1_Click for some reason
        private void button1_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void BtnLocalPhoneNumbers_Click(object sender, EventArgs e)
        {
            LocalPhoneForm local = new LocalPhoneForm();
            local.ShowDialog();
        }

        private void BtnImportedPhoneNumbers_Click(object sender, EventArgs e)
        {
            ImportedPhoneForm imported = new ImportedPhoneForm();
            imported.ShowDialog();  
        }

        private void BtnOnlinePhoneNumbers_Click(object sender, EventArgs e)
        {
            OnlinePhoneForm online = new OnlinePhoneForm(); 
            online.ShowDialog();    
        }
    }
}
