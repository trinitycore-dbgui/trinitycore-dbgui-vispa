using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using System.Collections.Specialized;

namespace TrinityCore_DBGUI
{
    public partial class frmdbRefs : Form
    {
        public frmdbRefs()
        {
            InitializeComponent();
        }

        private void frmdbRefs_Load(object sender, EventArgs e)
        {

            frmMain fMain = (frmMain)this.MdiParent;

            if (fMain.trinityCoreController.dbRef.Reference.Count < 1)
                return;

            foreach (DictionaryEntry dbRefValID in fMain.trinityCoreController.dbRef.Reference)
            {
                ListViewItem lvi = new ListViewItem((String)dbRefValID.Key);
                lvi.SubItems.Add((String)fMain.trinityCoreController.dbRef.Reference[dbRefValID.Key].ToString());
                this.lvDbRefs.Items.Add(lvi);
            }

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
