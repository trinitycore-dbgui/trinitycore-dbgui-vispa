using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

using System.Collections;

namespace TrinityCore_DBGUI_Library
{
    public class DbController
    {

        public String Username;
        public String Password;
        public String Hostname;
        public int Port;
        public Boolean dbListMode = false;
        public String ConnectString;

        MySqlConnection mConnection;

        public DbController()
        {
        }

        public Boolean Disconnect()
        {
            this.mConnection.Close();
            return true;
        }

        public Boolean Connect(String Database)
        {

            if (this.dbListMode == false)
            {
                this.ConnectString = "SERVER=" + this.Hostname + ";" +
                "DATABASE=" + Database + ";" +
                "UID=" + this.Username + ";" +
                "PASSWORD=" + this.Password + ";";
            }
            else
            {
                this.ConnectString = "SERVER=" + this.Hostname + ";" +
                "UID=" + this.Username + ";" +
                "PASSWORD=" + this.Password + ";";
            }

            try
            {
                this.mConnection = new MySqlConnection(this.ConnectString);
                this.mConnection.Open();
                   
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            if (this.mConnection.State == System.Data.ConnectionState.Closed)
            return false;

            return true;
        }

        public ArrayList GetGameItemList(ItemSearchCriteria SrchCriteria)
        {

 
            /*
            MySqlCommand command = connection.CreateCommand();
			MySqlDataReader Reader;
			command.CommandText = "select * from mycustomers";
			connection.Open();
			Reader = command.ExecuteReader();
			while (Reader.Read())
			{
				string thisrow = "";
				for (int i= 0;i<Reader.FieldCount;i++)
						thisrow+=Reader.GetValue(i).ToString() + ",";
				listBox1.Items.Add(thisrow);
			}
             */

            MySqlCommand mCmd = this.mConnection.CreateCommand();
            MySqlDataReader mReader;

            mCmd.CommandText = "SELECT entry,class,subclass,name,quality,InventoryType from item_template";

            String classStr = "";
            String InvTypeStr = "";
            String subclassStr = "";

            if (SrchCriteria.ICLASS != -1)
                classStr = "class = " + SrchCriteria.ICLASS;

            if (SrchCriteria.INVENTORY_TYPE != -1)
                InvTypeStr = "InventoryType = " + SrchCriteria.INVENTORY_TYPE;

            if (SrchCriteria.SUBCLASS != -1)
                subclassStr = "subclass = " + SrchCriteria.SUBCLASS;

            if (classStr != "" || InvTypeStr != "" || subclassStr != "")
            {

                mCmd.CommandText += " WHERE ";

                if (classStr != "")
                {
                    mCmd.CommandText += classStr;
                }

                if (classStr != "" && InvTypeStr != "")
                    mCmd.CommandText += " AND " + InvTypeStr;
                else if (InvTypeStr != "")
                    mCmd.CommandText += InvTypeStr;

                if (classStr != "" && InvTypeStr != "" && subclassStr != "")
                    mCmd.CommandText += " AND " + subclassStr;
                else if (InvTypeStr != "" && subclassStr != "")
                    mCmd.CommandText += " AND " + subclassStr;
                else if (subclassStr != "")
                    mCmd.CommandText += subclassStr;

                if (SrchCriteria.ExtraSQL != "")
                {
                    mCmd.CommandText += " AND " + SrchCriteria.ExtraSQL;
                }

                if (SrchCriteria.LIMIT_RESULTS == 0)
                {
                    mCmd.CommandText += " LIMIT 100";
                }
                else
                {
                    mCmd.CommandText += " LIMIT " + SrchCriteria.LIMIT_RESULTS;
                }

            }

            if (this.mConnection.State != System.Data.ConnectionState.Open)
            this.mConnection.Open();

            mReader = mCmd.ExecuteReader();

            ArrayList nResults = new ArrayList();

            while (mReader.Read())
            {
                /* Item Table: 
                 
                 entry 	class 	subclass 	unk0 	name 	displayid 	Quality 	Flags 	FlagsExtra 	BuyPrice 	SellPrice 	InventoryType 	AllowableClass 	AllowableRace 	ItemLevel 	RequiredLevel 	RequiredSkill 	RequiredSkillRank 	requiredspell 	requiredhonorrank 	RequiredCityRank 	RequiredReputationFaction 	RequiredReputationRank 	maxcount 	stackable 	ContainerSlots 	stat_type1 	stat_value1 	stat_unk1_1 	stat_unk2_1 	stat_type2 	stat_value2 	stat_unk1_2 	stat_unk2_2 	stat_type3 	stat_value3 	stat_unk1_3 	stat_unk2_3 	stat_type4 	stat_value4 	stat_unk1_4 	stat_unk2_4 	stat_type5 	stat_value5 	stat_unk1_5 	stat_unk2_5 	stat_type6 	stat_value6 	stat_unk1_6 	stat_unk2_6 	stat_type7 	stat_value7 	stat_unk1_7 	stat_unk2_7 	stat_type8 	stat_value8 	stat_unk1_8 	stat_unk2_8 	stat_type9 	stat_value9 	stat_unk1_9 	stat_unk2_9 	stat_type10 	stat_value10 	stat_unk1_10 	stat_unk2_10 	ScalingStatDistribution 	DamageType 	delay 	RangedModRange 	spellid_1 	spelltrigger_1 	spellcharges_1 	spellcooldown_1 	spellcategory_1 	spellcategorycooldown_1 	spellid_2 	spelltrigger_2 	spellcharges_2 	spellcooldown_2 	spellcategory_2 	spellcategorycooldown_2 	spellid_3 	spelltrigger_3 	spellcharges_3 	spellcooldown_3 	spellcategory_3 	spellcategorycooldown_3 	spellid_4 	spelltrigger_4 	spellcharges_4 	spellcooldown_4 	spellcategory_4 	spellcategorycooldown_4 	spellid_5 	spelltrigger_5 	spellcharges_5 	spellcooldown_5 	spellcategory_5 	spellcategorycooldown_5 	bonding 	description 	PageText 	LanguageID 	PageMaterial 	startquest 	lockid 	Material 	sheath 	RandomProperty 	RandomSuffix 	itemset 	MaxDurability 	area 	Map 	BagFamily 	TotemCategory 	socketColor_1 	socketContent_1 	socketColor_2 	socketContent_2 	socketColor_3 	socketContent_3 	socketBonus 	GemProperties 	ArmorDamageModifier 	Duration Duration in seconds. Negative value means realtime, postive value ingame time	ItemLimitCategory 	HolidayId 	StatScalingFactor 	Field130 	Field131 	WDBVerified 
                 0      1       2           3       4       5           6           7       8           9           10          11              12              13              14          15              16              17                  18              19                  20                  21                          22                      23          24          25              26          27              28              29              30          31              32              33              34          35              36              37              38          39              40              41              42          43              44              45              46          47              48              49              50          51              52              53              54          55              56              57              58          59              60              61              62              63              64              65              66                          67          68      69              70          71              72              73                  74                  75                          76          77
                 */
                GameItem gItem = new GameItem();
                gItem.EntryID = int.Parse(mReader.GetValue(0).ToString());
                gItem.Class = int.Parse(mReader.GetValue(1).ToString());

                gItem.Subclass = int.Parse(mReader.GetValue(2).ToString());
                gItem.Name = mReader.GetValue(3).ToString();
                gItem.Quality = int.Parse(mReader.GetValue(4).ToString());

                gItem.InventoryType = int.Parse(mReader.GetValue(5).ToString());

                nResults.Add(gItem);
            }

            mReader.Close();

            return nResults;

            /*
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + ",";
                listBox1.Items.Add(thisrow);
            }
            */

        }

        public ArrayList GetDbList()
        {
            /*
             * 
            MySqlCommand command = connection.CreateCommand();
			MySqlDataReader Reader;
			command.CommandText = "select * from mycustomers";
			connection.Open();
			Reader = command.ExecuteReader();
			while (Reader.Read())
			{
				string thisrow = "";
				for (int i= 0;i<Reader.FieldCount;i++)
						thisrow+=Reader.GetValue(i).ToString() + ",";
				listBox1.Items.Add(thisrow);
			}
             * 
             */

            MySqlCommand mCmd = this.mConnection.CreateCommand();
            MySqlDataReader mReader;

            mCmd.CommandText = "SHOW DATABASES;";

            if (this.mConnection.State != System.Data.ConnectionState.Open)
                return new ArrayList();
               // throw new Exception("Not connected to MySQL server.");

            mReader = mCmd.ExecuteReader();

            ArrayList dbList = new ArrayList();

            while (mReader.Read())
            {
                String tResultRow = "";
                for (int i = 0; i < mReader.FieldCount; i++)
                    tResultRow += mReader.GetValue(i).ToString();

                dbList.Add(tResultRow);

            }

            return dbList;
        }
        

    }
}
