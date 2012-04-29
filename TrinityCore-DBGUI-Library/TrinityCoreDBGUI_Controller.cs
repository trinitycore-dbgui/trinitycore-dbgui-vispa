using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;


namespace TrinityCore_DBGUI_Library
{
    public class TrinityCoreDBGUI_Controller
    {

        public String WorldDB;
        public String AuthDB;
        public String CharDB;

        public String DatabaseHostname;
        public int DatabasePort;
        public String DatabaseUsername;
        public String DatabasePassword;

        public DbController worldDb = new DbController();
        public DbController authDb = new DbController();
        public DbController characterDb = new DbController();
        public DbController dbLister = new DbController();

        public DbReferences dbRef = new DbReferences();

        public TrinityCoreDBGUI_Controller()
        {
        }

        public ArrayList GetDatabaseList()
        {
            if ((this.DatabaseHostname != "") && (this.DatabasePort.ToString() != "") && (this.DatabaseUsername != ""))
            {
                if (this.dbLister == null)
                    return new ArrayList();

                this.dbLister.Hostname = this.DatabaseHostname;
                this.dbLister.Port = this.DatabasePort;
                this.dbLister.Username = this.DatabaseUsername;
                this.dbLister.Password = this.DatabasePassword;
                this.dbLister.dbListMode = true;

                try
                {
                    this.dbLister.Connect("");
                }
                catch (Exception ex)
                {
                    //throw new Exception(ex.Message);
                    return new ArrayList();
                }


                return (this.dbLister.GetDbList());

            }
            else
            {
                throw new Exception("Error retrieving DB List");
            }

        }

        public Boolean ConnectToAuthDB()
        {
            if ((this.DatabaseHostname != "") && (this.DatabasePort.ToString() != "") && (this.DatabaseUsername != ""))
            {
                if (this.authDb == null)
                    return false;

                this.authDb.Hostname = this.DatabaseHostname;
                this.authDb.Port = this.DatabasePort;
                this.authDb.Username = this.DatabaseUsername;
                this.authDb.Password = this.DatabasePassword;

                try
                {
                    this.authDb.Connect(this.AuthDB);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                return true;

            }

            return true;
        }

        public Boolean ConnectToCharacterDb()
        {
            if ((this.DatabaseHostname != "") && (this.DatabasePort.ToString() != "") && (this.DatabaseUsername != ""))
            {
                if (this.characterDb == null)
                    return false;

                this.characterDb.Hostname = this.DatabaseHostname;
                this.characterDb.Port = this.DatabasePort;
                this.characterDb.Username = this.DatabaseUsername;
                this.characterDb.Password = this.DatabasePassword;

                try
                {
                    this.characterDb.Connect(this.CharDB);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                return true;

            }

            return true;
        }

        public Boolean ConnectToWorldDB()
        {
            if ((this.DatabaseHostname != "") && (this.DatabasePort.ToString() != "") && (this.DatabaseUsername != ""))
            {
                if (this.worldDb == null)
                    return false;

                this.worldDb.Hostname = this.DatabaseHostname;
                this.worldDb.Port = this.DatabasePort;
                this.worldDb.Username = this.DatabaseUsername;
                this.worldDb.Password = this.DatabasePassword;

                try
                {
                    this.worldDb.Connect(this.WorldDB);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                return true;

            }

            return true;
        }


    }
}
