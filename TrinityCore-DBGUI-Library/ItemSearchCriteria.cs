using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrinityCore_DBGUI_Library
{
    public class ItemSearchCriteria
    {

        public String DisplayName;

        public String SelectorCommand;

        public int ICLASS;
        public int SUBCLASS;
        public int INVENTORY_TYPE;
        public int LIMIT_RESULTS;

        public String ExtraSQL;

        public ItemSearchCriteria()
        {
        }

        public ItemSearchCriteria(int IClass, int InventoryType, int SubClass, int LimitResults=0)
        {

            this.ICLASS = IClass;
            this.INVENTORY_TYPE = InventoryType;
            this.SUBCLASS = SubClass;
            this.LIMIT_RESULTS = LimitResults;

        }
    
    }
}
