using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrinityCore_DBGUI
{
    public partial class frmGameItem : Form
    {
        public frmGameItem()
        {
            InitializeComponent();
        }

        private void frmGameItem_Load(object sender, EventArgs e)
        {
            this.cboBindType.Items.Add("0 : No Bind");
            this.cboBindType.Items.Add("1 : Binds when picked up");
            this.cboBindType.Items.Add("2 : Binds when equipped");
            this.cboBindType.Items.Add("3 : Binds when used");
            this.cboBindType.Items.Add("4 : Quest Item?");
            this.cboBindType.Items.Add("5 : Quest Item?");
        }

    }
}
