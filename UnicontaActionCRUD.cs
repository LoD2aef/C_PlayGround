using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Uniconta.API.System;
using Uniconta.ClientTools.DataModel;
using Uniconta.Common;
using Uniconta.DataModel;

namespace WinFormServer {
    class UnicontaActionCRUD {

        private static TableHeaderClient CurrentTableHeader { get; set; }
        public async Task<string> Uniconta_Insert(CrudAPI CrudAPI) { // insert method take the CRUDAPI
            // Initialize Item, this is fix for now, gotta add more flexibility, so it can take more then only InvItemClient
            var myItem = new InvItemClient { // Object and object type that will be insert in the data base.
                Item = "109", // Item number unique key.
                Name = "Toothbrush", // item name. 
                CostPrice = 29.95, // cost price 
                SalesPrice1 = 100.00, // seles price
            };
            // var myItem = new DebtorClient { // Object and object type that will be insert in the data base.
            //      Account = "109", 
            //      Name = "Toothbrush", 
            // };
            // CrudAPI.Insert takes a UnicontaBaseEntity like the InvItemClient or DebtorClient
            ErrorCodes result = await CrudAPI.Insert(myItem); // Insert Item and get result as a ErrorCodes
            if (result != ErrorCodes.Succes) { // if ErrorCodes is not Succes, so it failed insert.
                return ("Unable to insert item. Error: " + result.ToString()); // string with Error for user
            }
            return ("Succesfully inserted item: " + myItem.Item + ", name: " + myItem.Name + "into Uniconta");
        }

        // This one is not displayed..... not sure why try seting UserDefinedId and not setting it still not working ?_?
        public async Task<string> Uniconta_InsertTable(CrudAPI CrudAPI) { // This method creates a table and inserts it into Uniconta.
            // Initialize table header in Uniconta, can be find in ->  Tools\Custom Tables\Tables
            var tableHeader = new TableHeaderClient { // custom tables use to display spical data togetter or other data.
                _MenuPosition = 1,                  // Customer Menu    1 = Økonomi
                _Name = "APIInsertTest2021",        // Name of the Table (for the backend)
                _Prompt = "API-Insert",             // Name of the Table in the Menu under Custom Tables to click on
                _UserDefinedId = 0,                 // use 0 or companyId for it to be display for company.
            };
            // Insert table header into Uniconta Database 
            ErrorCodes result = await CrudAPI.Insert(tableHeader);
            if (result != ErrorCodes.Succes) {
                return ("Unable to insert table header. Error: " + result.ToString());
            }
            CurrentTableHeader = tableHeader; // set the local TableHeaderClient object so that we can insert files to it later
            return ("Succesfully inserted table header into Uniconta.\nName: " + tableHeader._Name + "\nPrompt: " +
                tableHeader._Prompt + "\nUserDefinedID: " + tableHeader._UserDefinedId);
        }
        public async Task<string> Uniconta_InsertPopulateTable(CrudAPI CrudAPI) {
            // Initialize new fields for the just created TableHeaderClient
            var newFields = new List<TableField> // a list of the TableFields so we can add more then one
            {
                // Object of the TableField type
                new TableField
                {
                    _RefTable = "Employee", // Foreign Key to Employee Table
                    _Prompt = "Employee",
                    _Name = "Employee",
                    _FieldType = CustomTypeCode.String,
                },
                new TableField
                {
                _Name = "School", // internel name
                _Prompt = "Car", // displayed name
                _FieldType = CustomTypeCode.String, // Type of input it takes
                },
            };
            // Loop over newFields and set their master
            foreach (var field in newFields)
                field.SetMaster(CurrentTableHeader);
            // Insert newFields in bulk
            var result = await CrudAPI.Insert(newFields);
            if (result != ErrorCodes.Succes) {
                return ("Unable to insert fields into table. Error: " + result.ToString());
            }
            var msg = String.Format("Succesfully inserted {0} fields into table {1}", newFields.Count, CurrentTableHeader.Name);
            return msg;
        }
        public async Task<string> Uniconta_Get_Debitor(CrudAPI CrudAPI) {
            var debtors = await CrudAPI.Query<DebtorClient>();
            string DebString = "";
            List<Debtor> LiDeb = new List<Debtor>();
            Debtor Deb1004 = new Debtor();
            foreach (Debtor deb in debtors) {
                LiDeb.Add(deb);
                DebString += deb._Name;
                DebString += " - ";
                DebString += deb._Account;
                DebString += "\n";
                if (deb._Account == "1004") {
                    Deb1004 = deb;
                }
            }
            Debtor Deb42 = new Debtor() {
                _Name = "CREADED DEMO",
                _Account = "42",
                _Country = CountryCode.Denmark,
                _Language = Language.da,
                _VatZone = VatZones.VatFree,
            };
            // ErrorCodes deleteRes = await CrudAPI.Delete(LiDeb);
            // ErrorCodes delete1004 = await CrudAPI.Delete(Deb1004); // delete Debtor
            // DebString += deleteRes.ToString(); // CouldNotDeleteRecordThatIsReferred
            // DebString += delete1004.ToString();
            //Thread.Sleep(30000);
            await CrudAPI.Insert(LiDeb);
            return DebString;
        }
    }
}