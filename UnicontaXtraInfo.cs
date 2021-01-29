using System;
using System.Collections.Generic;
using Uniconta.API.Service;
using Uniconta.API.System;
using Uniconta.ClientTools.DataModel;
using Uniconta.Common;
using Uniconta.Common.User;
using Uniconta.DataModel;

namespace WinFormServer {
    // Uniconta API is the only way to interact with the ERP server.
    // Uniconta API is used by Uniconta it self to work with the ERP server.
    class UnicontaClassDemo {
        private string UserName;
        private string PassWord;
        private string APIGuidKey = "00000000-0000-0000-0000-000000000000";
        private CrudAPI UnicCrudAPI;
        

        private void Uniconta_Connection() { // Connection
            // Instantiate a connection. This identifies the ERP server. There is only the Live server rigth now.
            UnicontaConnection UnicConn = new UnicontaConnection(APITarget.Live);
        }
        private void Uniconta_Session(UnicontaConnection UnicConn) { // Session
            // Instantiate a session. A session is an instance of a user. Only one user can be logged in on a session at any time.
            Session UnicSess = new Session(UnicConn);
        }
        private void Uniconta_Login(Session UnicSess) { // Login
            // After instantiate the session, you can login.
            // bool loggedIn = await ses.LoginAsync("John", "Abc123", LoginType.API, new Guid("Cuid that we provide")); // Async
            ErrorCodes Login = UnicSess.LoginAsync(UserName, PassWord, LoginType.API, new Guid(APIGuidKey)).Result; // Sync
            // You can instantiate any number of sessions and each session can login as the same user or a different user.
        }
        private void Uniconta_Company(Session UnicSess, int CompanyID) { // Company
            // A Company is an entity that holds all the data for a company in the ERP Server.
            // On the session object, you have methods to get an access to a company object.
            Company UnicComp = UnicSess.GetCompany(CompanyID).Result; // public Task GetCompany(int int) || GetCompany(string str)
            // public Task<Company[]> GetCompanies()
            // public Company DefaultCompany get; set;
            // Once you have a session and a company object, you can start to interact with the data on the ERP Server.
        }
        private void Uniconta_BaseAPI(Session UnicSess, Company UnicComp) { // BaseAPI
            // Every API inherits from a BaseAPI. BaseAPI takes a session and a company, can also instantiate API from another API.
            // If you pass null in CompanyEntity, we will use session.DefaultCompany
            // protected BaseAPI(Session session, Company CompanyEntity) instantiate API with session, company, CompanyEntity
            UnicCrudAPI=new CrudAPI(UnicSess, UnicComp);
            CrudAPI UnicCrudAPI_E = new CrudAPI(UnicCrudAPI);
            // protected BaseAPI(BaseAPI api) instantiate API from API useing the session and company from API passed
        }

        private void Uniconta_QueryAPI() { // QueryAPI
            // The QueryAPI is to retrieve data from the Uniconta server.
            // A simple select for all DebtorClient’s, will be like this:
            DebtorClient[] DebtClin = UnicCrudAPI.Query<DebtorClient>().Result; // Read from ERP SERVER
            // The Query method returns an array of objects of the same type as you pass in the call.
            /*
             * public QueryAPI(Session session, Company CompanyEntity)
             * The primary method to retrieve data is the Query method in the QueryAPI.
             * public Task<SelectType[]> Query(IEnumerable Masters, IEnumerable PropWhere )
             */
        }
        private void Uniconta_InsertAPI() { // InsertAPI -> CRUD -> C -> Create 
            // The InsertAPI is to create data to the Uniconta server.
            // A simple create and add DebtorClient for all DebtorClient’s, will be like this:
            List<DebtorClient> DebtClieCrea = new List<DebtorClient>(); // create DebtorClient that shall be add
            ErrorCodes UnicInsertResu = UnicCrudAPI.Insert(DebtClieCrea).Result; // add to ERP SERVER
            // The Insert method returns an ErrorCodes objects with status of the insert. like ErrorCodes.Succes == 1
        }
        private void Uniconta_ReadAPI() { // ReadAPI -> CRUD -> R -> Read
            // The ReadAPI is to Read data from the Uniconta server.
            // A simple read DebtorClient for all DebtorClient’s, will be like this:
            List<DebtorClient> DebtClieUpda = new List<DebtorClient>();
            ErrorCodes UnicReadResu = UnicCrudAPI.Read(DebtClieUpda).Result;
            // The Read method returns an ErrorCodes objects with status of the insert. like ErrorCodes.Succes == 1
        }
        private void Uniconta_UpdateAPI() { // UpdateAPI -> CRUD -> U -> Update
            // The UpdateAPI is to change data from the Uniconta server.
            // A simple Update DebtorClient for all DebtorClient’s, will be like this:
            List<DebtorClient> DebtClieUpda = new List<DebtorClient>();
            ErrorCodes UnicUpdatResu = UnicCrudAPI.Update(DebtClieUpda, DebtClieUpda).Result;
            // The Update method returns an ErrorCodes objects with status of the insert. like ErrorCodes.Succes == 1
        }
        private void Uniconta_DeleteAPI() { // DeleteAPI -> CRUD -> D -> Delete
            // The DeleteAPI is to remove data from the Uniconta server.
            // A simple Delete DebtorClient for all DebtorClient’s, will be like this:
            List<DebtorClient> DebtClieUpda = new List<DebtorClient>();
            ErrorCodes UnicDeleResu = UnicCrudAPI.Delete(DebtClieUpda).Result;
            // The Delete method returns an ErrorCodes objects with status of the insert. like ErrorCodes.Succes == 1
        }
        private void Uniconta_BaseEntity() { // UnicontaBaseEntity
            // All entities on the ERP server are UnicontaBaseEntities. UnicontaBaseEntity is an interface.
            // It is very useful to extend a Uniconta entity and apply it with you own methods and properties. You can inherit any class
            // that has the UnicontaBaseEntity interface and then use them in the query. We will then instantiate types of your type
            // and not our base type. Example:
            /* 
            public class MYGLAccount : GLAccount {
	            Int MyVariable;
                [Display(Name = "Account Number"), Required, Key]
                public string Account { get { return _Account; } set { _Account = value; } }
            }
            var AccountList = await qapi.Query();
             */
        }
        private void Uniconta_MasterDetail() { // Master/Detail Query.
            // Our ERP server knows all the relations between classes, so you do not have to specify much to search the details for a
            // master record. The second argument is a “Masters” for a given class. In this case, we search all the transactions that
            // belongs to the given account.
            /*
            var AccountList = await qapi.Query();
            foreach (var Acc in AccountList) {
                var Master = new List();
                Master.Add(Acc);
                var TransList = await qapi.Query(Master, null);
            }
            */
            // You can add more than one master. Let us assume we have searched a Vat-class, we can add that too and then we will
            // only get transactions with the given account and given Vat code.
            /*
            var AccountList = await qapi.Query();
            foreach (var Acc in AccountList) {
                var Master = new List();
                Master.Add(Acc);
                Master.Add(Vat);
                var TransList = await qapi.Query(Master, null);
            }
            */
        }
        private void Uniconta_FilterWhereBy() { // Filter, Where and Order By
            // The last parameter in the Query method is to filter and order the query. The values passed here will all be included in the
            // SQL statement, which the server will generate to select your data. A simple filter on properties can look like this.
            /*
            var crit = new List();
            var pair = PropValuePair.GenereteWhereElements("Date", typeof(DateTime), "1/1-2014..31/1-2014");
            crit.Add(pair);
            pair=PropValuePair.GenereteWhereElements("Voucher", typeof(int), "1000;2000..3000;7000..");
            crit.Add(pair);

            var tlst = await qapi.Query(Master, crit);
            */
            // To add an order by on “Account ascending, Voucher decending”, will look like this:
            /*
            pair=PropValuePair.GenereteOrderByElement("Account", false);
            crit.Add(pair);
            pair=PropValuePair.GenereteOrderByElement("Voucher", true);
            crit.Add(pair);
            */
            // If you only are interested in the first 10 rows, there is no need to select all rows back to the client.
            /*
            pair=PropValuePair.GenereteTakeN(10);
            crit.Add(pair);
            */
            // Please note, that this will return the top 10 rows after the query has sorted the data. This is an efficient way to find the 
            // highest values in a table. To find the highest values pass “1” in the call.
            // We have another way to generate a where clause.You can write a SQL where clause, which we will pass directly to SQL server.
            // However, we recommend the first way to work with where clauses, since we will check if the property is a valid property.
            /*
            var pair = PropValuePair.GenereteWhere("Account <= ‘1200’ and Name like ‘Sales’");
            crit.Add(pair);
            */
        }
        private void Uniconta_CRUDAPI() { // CrudAPI
            // This api is the primary api to insert, update and delete data. Every method call in this api will be executed in a SQL transaction on the server.
            // We have simple methods to work on a single record. We have methods to work on a list of records, and the records can be of different types.
            // We even have a single method that can take records of different types and can execute inserts, updates and deletes in one single call.
            // This ensures that all operations are executed in on single SQL Transaction.
            /*
            var capi = new CrudAPI(session, company);
            */
            // To insert a single record:
            /*
            var acc = new GLAccount();
            acc._Account="1200";
            acc._Name="Sales";
            acc._AccountType=(byte)GLAccountTypes.Revenue;
            var err = await capi.Insert(acc);
            */
            // Please note, that in case the server will update some values in the record, these values will be return back to the client and assigned into the record 
            // passed in the call. In the case of GLAccount, it has a property RowId, which is 0 and after a successful insert, it will have a value. To insert a list:
            /*
            var lst = new List();
            var acc = new GLAccount();
            acc._Account="1200";
            acc._Name="Sales. Computers";
            acc._AccountType=(byte)GLAccountTypes.Revenue;
            lst.Add(acc);

            acc=new GLAccount();
            acc._Account="1300";
            acc._Name="Sales. Software";
            acc._AccountType=(byte)GLAccountTypes.Revenue;
            lst.Add(acc);

            var err = await capi.Insert(lst);
            */
            // To update and delete records, you will first have to select the record.
            /*
            var crit = new List();
            var pair = PropValuePair.GenereteWhereElements("Account", typeof(string), "1300");

            var alst = await capi.Query(null, crit);
            if (alst!=null&&alst.Any()) {
                var acc = alst[0];
                acc._Name="Sales. Software and more";
                var err = await capi.Update(acc);
            }
            */
            // This method is fine, if you load the record, change a value and update. The chance that another user will have made an updated to the record since you
            // read it, is nearly none existing. Let us imagine that you load the record. Display it to the user. The user makes some changes and save it. The time
            // between the load and the update can be infinitely long, and another user could have update the record in that period, and then you will now overwrite his
            //  changes.

            // We have a way to get around that. Before we let the user modify the record, we take a copy of the loaded record. CrudAPI has an update method that takes
            // a loaded record and a modified record. This method will only update the SQL with the differences between the loaded and the modified record. This way,
            // we can apply only the changes made by the user.
            /*
            var acc=alst[0];
            var loaded = StreamingManager.Clone(acc);
            // Now user will modify acc.
            var err = await capi.Update(loaded, acc);
            */
            // Please note here, that after the call, the passed record will be updated with any new values from the server.
            // To delete a record, we will need to query it and then call delete it.
            /*
            var acc = alst[0];
            var err = await capi.Delete(acc);
            */
            // Just like the insert method could take a list, so can update and delete methods. The list can contain any type of UnicontaBaseEntity.
            // If you have worked in Uniconta, you will know that we in several screens (daily journal, order lines, inventory journal, etc) can work on a whole
            // grid of records. We can insert, edit and delete records and then we can press . To do that in one SQL Transaction, we have implemented a method 
            // that can perform all three operations in one call.
            /*
            public TaskMultiCrud(IEnumerableInserts, IEnumerableUpdates, IEnumerableDeletes)
            */
        }
        private void Uniconta_InsertDetail() { // Insert a detail record in a Master/Detail relation
            // Assume you have an Order of type DebtorOrder, which is the order header, and you want to insert a DebtorOrderLine . Like we have showed earlier,
            // when we search a detail, we pass a Master as argument in the Query. Before we insert a detail, we need to assign it to a master:
            /*
            var line = new DebtorOrderLine();
            line.SetMaster(Order);
            */
            // Now it is assigned to the Order and you can assign the other fields and call api.Insert(line);
        }
        private void Uniconta_ModulsAPI() { // Module specific API’s
            // Each module in Uniconta has a set of API’s, that will implement methods specialized for its module.
            /*
            namespace Uniconta.API.GeneralLedger {
                public class ReportAPI : BaseAPI
                public class BankStatementAPI : BaseAPI
                public class DocumentAPI : BaseAPI
                public class FinancialYearAPI : BaseAPI
                public class PeriodTotalAPI : BaseAPI
                public class PostingAPI : BaseAPI
                public class StandardGLAccountAPI : BaseAPI
            }
            namespace Uniconta.API.DebtorCreditor {
                public class DebtorOrderAPI : BaseAPI
                public class InvoiceAPI : BaseAPI
                public class ReportAPI : BaseAPI
                public class TransactionAPI : BaseAPI
            }
            namespace Uniconta.API.Inventory {
                public class PostingAPI : BaseAPI
                public class ReportAPI : BaseAPI
            }
            namespace Uniconta.API.System {
                public class CompanyAPI : BaseAPI
                public class NumberSerieAPI : BaseAPI
                public class CompanyAccessAPI : BaseAPI
                public class UserAPI : BaseAPI
            }
            */
        }
        private void Uniconta_BaseEntities() {
            // To get a list of tables, which we have in the SQL Server, please browse this namespace.
            /* 
            namespace Uniconta.DataModel 
            */
        }

    }
}