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

        public String LastSQLQuery;

        MySqlConnection mConnection;

        public DbController()
        {
        }

        public Boolean Disconnect()
        {
            if (this.mConnection != null)
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

        public ArrayList GetItemSetList()
        {
            MySqlCommand mCmd = this.mConnection.CreateCommand();
            MySqlDataReader mReader;

            mCmd.CommandText = "SELECT entry,name from item_set_names";

            if (this.mConnection.State != System.Data.ConnectionState.Open)
                this.mConnection.Open();

            mReader = mCmd.ExecuteReader();

            ArrayList nResults = new ArrayList();

            while (mReader.Read())
            {
                //gItem.ItemLevel = int.Parse(mReader.GetValue(6).ToString());
                //gItem.RequiredLevel = int.Parse(mReader.GetValue(7).ToString());
                ItemSet iSet = new ItemSet();

                iSet.EntryID = mReader.GetValue(0).ToString();
                iSet.Name = mReader.GetValue(1).ToString();

                nResults.Add(iSet);
            }

            mReader.Close();

            return nResults;

        }

        public ArrayList GetGameItemList(ItemSearchCriteria SrchCriteria)
        {

            MySqlCommand mCmd = this.mConnection.CreateCommand();
            MySqlDataReader mReader;

            mCmd.CommandText = "SELECT entry,class,subclass,name,quality,InventoryType,ItemLevel,RequiredLevel from item_template";

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
                else if (classStr != "" && subclassStr != "")
                    mCmd.CommandText += " AND " + subclassStr;
                else if (subclassStr != "")
                    mCmd.CommandText += subclassStr;

                if (SrchCriteria.ExtraSQL != "")
                {
                    mCmd.CommandText += " AND " + SrchCriteria.ExtraSQL;
                }

                if (SrchCriteria.LIMIT_RESULTS == 0)
                {
                    mCmd.CommandText += " LIMIT 500";
                }
                else
                {
                    mCmd.CommandText += " LIMIT " + SrchCriteria.LIMIT_RESULTS;
                }

            }
            else
            {
                /* search everything */
                if (SrchCriteria.ExtraSQL != "")
                {
                    mCmd.CommandText += " WHERE " + SrchCriteria.ExtraSQL; 
                }

                if (SrchCriteria.LIMIT_RESULTS == 0)
                {
                    mCmd.CommandText += " LIMIT 500";
                }
                else
                {
                    mCmd.CommandText += " LIMIT " + SrchCriteria.LIMIT_RESULTS;
                }

            }

            if (this.mConnection.State != System.Data.ConnectionState.Open)
            this.mConnection.Open();

            mReader = mCmd.ExecuteReader();
            this.LastSQLQuery = mCmd.CommandText;

            ArrayList nResults = new ArrayList();

            while (mReader.Read())
            {
                GameItem gItem = new GameItem();
                gItem.EntryID = int.Parse(mReader.GetValue(0).ToString());
                gItem.Class = int.Parse(mReader.GetValue(1).ToString());

                gItem.Subclass = int.Parse(mReader.GetValue(2).ToString());
                gItem.Name = mReader.GetValue(3).ToString();
                gItem.Quality = int.Parse(mReader.GetValue(4).ToString());

                gItem.InventoryType = int.Parse(mReader.GetValue(5).ToString());

                gItem.ItemLevel = int.Parse(mReader.GetValue(6).ToString());
                gItem.RequiredLevel = int.Parse(mReader.GetValue(7).ToString());

                nResults.Add(gItem);
            }

            mReader.Close();

            return nResults;

        }

        public ArrayList GetDbList()
        {

            MySqlCommand mCmd = this.mConnection.CreateCommand();
            MySqlDataReader mReader;

            mCmd.CommandText = "SHOW DATABASES;";

            if (this.mConnection.State != System.Data.ConnectionState.Open)
                return new ArrayList();

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
