using System;
using System.Threading.Tasks;
using Uniconta.API.Service;
using Uniconta.API.System;
using Uniconta.Common;
using Uniconta.Common.User;
using Uniconta.DataModel;

namespace WinFormServer {
    class UnicontaActionHandler {
        private Guid APIGuidKey = new Guid(""); // API key
        private CrudAPI CrudAPI; // variable for Uniconta CrudAPI. Use for CRUD functionalities.
        private Company BaseCompany; // variable for Uniconta Company. What Company data shall have data manipulation.
        private Session UnicSess; // variable for Uniconta Session with UnicontaConnection to the APITarget server.

        private static UnicontaActionHandler UniActHandler; // variable for Class instands to use for call of methods
        private static UnicontaActionCRUD UniActCRUD; // variable for Class instands to use for call of methods
        private static UnicontaActionReadOrder UniActRead; //

        public static UnicontaActionHandler Uniconta_GetInstanceHandler() { // Get instands of Handler Class
            if (UniActHandler == null) { // check if there is a instands of the Handler class
                UniActHandler = new UnicontaActionHandler(); // make a instands of the Handler class and set to variable
            }
            return UniActHandler; // return the instand of the Handle class.
        }
        public static UnicontaActionHandler Uniconta_GetInstanceCRUD() { // Get instands of CRUD Class
            if (UniActCRUD == null) { // check if there is a instands of the CRUD class
                UniActCRUD = new UnicontaActionCRUD(); // make a instands of the CRUD class and set to variable
            }
            return UniActHandler; // return the instand of the CRUD class.
        }
        public static UnicontaActionReadOrder Uniconta_GetInstanceRead() {
            if (UniActRead == null) { // 
                UniActRead = new UnicontaActionReadOrder(); // 
            }
            return UniActRead; //
        }
        private void Uniconta_SetSession() {
            if (UnicSess == null) { // check if the is a UnicSess object before trying to create a new.
                // instance a UnicontaConnection with the name UnicConn, the UnicontaConnection set it's APITarget to Live.
                UnicontaConnection UnicConn = new UnicontaConnection(APITarget.Live); // Live is the only Uniconta server.
                UnicSess = new Session(UnicConn); // instance a Uniconta Session, where we store the UnicConn.
            }
        }
        public async Task<string> Uniconta_Login(string username, string password) {
            Uniconta_SetSession(); // call the Uniconta_SetSession method so the sesssion object is instance.
            // Attempting to login. gets a ErrorCodes.Succes if login successful. Async method.
            ErrorCodes LoginRes = await UnicSess.LoginAsync(username, password, LoginType.API, APIGuidKey);
            // not in use anymore, after the code about is better as it is Async method. this is Sync method.
            // ErrorCodes Login = UnicSess.LoginAsync(UserName, PassWord, LoginType.API, APIGuidKey).Result;
            if (LoginRes == ErrorCodes.Succes) { // Login was Succesful.
                await Uniconta_InitializeCompany(); // initiates or set Session's DefaultCompany 
                CrudAPI = new CrudAPI(UnicSess, BaseCompany); // instance a Uniconta CrudAPI. 
                return "Login was Succesful"; // return a display string for end user
            } else if (LoginRes == ErrorCodes.UserOrPasswordIsWrong) { // Login Fail because wrong password or username.
                return "Wrong Username or Password"; // return a display string for end user
            }
            return "Internal Error within Uniconta"; // return a display string for end user
        }
        private async Task Uniconta_InitializeCompany() { // instands the BaseCompany variable if miss, if not return it.
            if (UnicSess.DefaultCompany != null) { // check if Session has a value for DefaultCompany.
                BaseCompany = UnicSess.DefaultCompany; // if DefaultCompany is not null set vari BaseCompany to be it. 
                return; // used to end Method; 
            }
            int CompanyId = 34776; // CompanyId is the id of the company that wish to get data about.
            // BaseCompany = await UnicSess.OpenCompany(CompanyId, false); // set BaseCompany if not set yet to CompanyId
            BaseCompany = await UnicSess.OpenCompany(CompanyId, true); // set the company as default for the user
        }
        public async Task Uniconta_LogOut() { // end the Uniconta Session
            if (UnicSess != null) { // check if there is a Uniconta Session to Close/LogOut.
                await UnicSess.LogOut(); // LogOut of the Uniconta Session.
            }
        }
        public async Task<string> Uniconta_Populate() { // Method for call the CRUD method in another class
            Uniconta_GetInstanceCRUD(); // instands the crud class if missing else, useless
            string res = await UniActCRUD.Uniconta_Insert(CrudAPI); // call the insert method with CrudAPi object
            return res; // return the result of the insert. string with what happen and so on
        }
        public async Task<string> Uniconta_Table() { // Method for call the CRUD method in another class
            Uniconta_GetInstanceCRUD(); // instands the crud class if missing else, useless
            string res = await UniActCRUD.Uniconta_InsertTable(CrudAPI); // call the insert method with CrudAPi object
            return res; // return the result of the insert. string with what happen and so on
        }
        public async Task<string> Uniconta_TablePopulate() { // Method for call the CRUD method in another class
            Uniconta_GetInstanceCRUD(); // instands the crud class if missing else, useless
            string res = await UniActCRUD.Uniconta_InsertPopulateTable(CrudAPI); // call the insert method with CrudAPi object
            return res; // return the result of the insert. string with what happen and so on
        }
        public void Uniconta_InsertCSVFile() {
            Uniconta_GetInstanceRead();
            Uniconta_SetSession();
            UniActRead.Execute(CrudAPI);
        }
    }
}