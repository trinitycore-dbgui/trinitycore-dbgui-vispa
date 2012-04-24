using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

namespace TrinityCore_DBGUI_ControlLib
{
    public class CriteriaRequester
    {

        public enum CriteriaType { Text, DropDown, CheckBox };

        public CriteriaType CritType;
        public String ID;
        public ArrayList DropDownContent = new ArrayList();

        public CriteriaRequester(CriteriaType cType, String ID)
        {
            this.CritType = cType;
            this.ID = ID;
        }

    }
}
