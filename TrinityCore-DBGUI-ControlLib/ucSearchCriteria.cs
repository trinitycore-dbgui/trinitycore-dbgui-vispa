using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrinityCore_DBGUI_ControlLib
{
    public partial class ucSearchCriteriaItem : UserControl
    {

        /* events */

        public delegate void RemoveClicked(object sender);
        public event RemoveClicked RequestedRemoveCriteria;

        public String ActualCriteriaSQL = "";

        public void SetCriteriaText(String CriteriaText)
        {
            this.lblCriteria.Text = CriteriaText;
            this.Width = this.lblCriteria.Width + this.pnlRemoveEdit.Width;

            this.pnlLabel.Width = this.lblCriteria.Width;
            
            
        }
        
        public ucSearchCriteriaItem()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.RequestedRemoveCriteria != null)
                this.RequestedRemoveCriteria(this);
        }

    }
}
