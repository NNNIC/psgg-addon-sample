using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addon_sample1
{
    public partial class ItemEditorForm : Form
    {
        public ItemEditorForm()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ItemEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
