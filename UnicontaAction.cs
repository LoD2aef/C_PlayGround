using System;
using System.Threading.Tasks;
using Uniconta.API.Service;
using Uniconta.API.System;
using Uniconta.ClientTools.DataModel;
using Uniconta.Common;
using Uniconta.Common.User;
using Uniconta.DataModel;

namespace WinFormServer {
    class UnicontaAction {
        private Guid APIGuidKey = new Guid("");
        private CrudAPI CrudAPI;
        private Company BaseCompany;
        private Session UnicSess;

        private static UnicontaAction UnicActionClass;

        public static UnicontaAction Uniconta_GetInstance() {
            if (UnicActionClass == null ) {
                UnicActionClass = new UnicontaAction();
            }
            return UnicActionClass;
        }

        public void Uniconta_SetSession() {
            // instance a UnicontaConnection with the name UnicConn, the UnicontaConnection set it's APITarget to Live.
            UnicontaConnection UnicConn = new UnicontaConnection(APITarget.Live); // Live is the only Uniconta server.
            UnicSess = new Session(UnicConn); // instance a Uniconta Session, where we store the UnicConn.
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
        private async Task Uniconta_InitializeCompany() {
            if (UnicSess.DefaultCompany != null) { // check if Session has a value for DefaultCompany.
                BaseCompany = UnicSess.DefaultCompany; // if DefaultCompany is not null set vari BaseCompany to be it. 
                return; // used to end Method; 
            }
            int CompanyId = 34776; // CompanyId is the id of the company that wish to get data about.
            BaseCompany = await UnicSess.OpenCompany(CompanyId, false); // set BaseCompany if not set yet to CompanyId
        }
        public async Task Uniconta_LogOut() { // end the Uniconta Session
            if (UnicSess != null) { // check if there is a Uniconta Session to Close/LogOut.
                await UnicSess.LogOut(); // LogOut of the Uniconta Session.
            }
        }
        public async Task<string> Uniconta_Populate() { //
            // Initialize Item
            var myItem = new InvItemClient {
                Item = "109",
                Name = "Toothbrush",
                CostPrice = 29.95,
                SalesPrice1 = 100.00,
            };
            // Insert Item
            var result = await CrudAPI.Insert(myItem);
            if (result != ErrorCodes.Succes) {
                return ("Unable to insert item. Error: " + result.ToString());
            }
            return ("Succesfully inserted item: " + myItem.Item + ", name: " + myItem.Name + "into Uniconta");
        }
    }
}