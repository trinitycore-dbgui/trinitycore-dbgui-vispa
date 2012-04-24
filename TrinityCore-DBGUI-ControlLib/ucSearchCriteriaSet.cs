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
    public partial class ucSearchCriteriaSet : UserControl
    {
        public ucSearchCriteriaSet()
        {
            InitializeComponent();
        }

        public FlowLayoutPanel GetAllCriteria()
        {
            return this.flpCritieraSet;
        }

        public void AddCriteria(ucSearchCriteriaItem uCriteriaItem)
        {
            this.flpCritieraSet.Controls.Add(uCriteriaItem);
            uCriteriaItem.RequestedRemoveCriteria +=new ucSearchCriteriaItem.RemoveClicked(uCriteriaItem_RequestedRemoveCriteria);
        }

        public void uCriteriaItem_RequestedRemoveCriteria(object sender)
        {
            this.flpCritieraSet.Controls.Remove((System.Windows.Forms.Control)sender);
        }

    }
}
