using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Uniconta.API.DebtorCreditor;
using Uniconta.API.Service;
using Uniconta.API.System;
using Uniconta.ClientTools.DataModel;
using Uniconta.Common;

namespace WinFormServer {
    class UnicontaActionReadOrder {
        public string Name => "";
        private string errorMSG;
        private CrudAPI crudAPI;

        public event EventHandler OnExecute;

        public ErrorCodes Execute(CrudAPI api) {
            crudAPI = api;
            var dialog = new OpenFileDialog {
                Filter = "CSV | *csv"
            };
            if (dialog.ShowDialog() != DialogResult.OK) {
                return ErrorCodes.Succes;
            }
            var lines = new List<string[]>();

            using (StreamReader reader = new StreamReader(dialog.FileName)) {
                while (!reader.EndOfStream) {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    lines.Add(values);
                }
            }
            lines.RemoveAt(0);
            createLines(lines);
            return ErrorCodes.Succes;
        }

        private async void createLines(List<string[]> lines) {
            var orders = new List<DebtorOrderClient>();
            var ols = new List<DebtorOrderLineClient>();
            var items = await crudAPI.Query<InvItemClient>(); // getting all items
            var debtors = await crudAPI.Query<DebtorClient>(); // getting all debtors

            foreach (string[] s in lines) {
                DebtorOrderClient order; // creating a local variable of the type DebtorOrderClient.
                //foreach (var deb in debtors) { // run thou all debtors from the query
                //    Console.WriteLine(deb.Account); // checking debtor account (number)
                //    Console.WriteLine(s[0]); // checking file debtor account (number)
                //    Console.WriteLine(deb.Account == s[0]); // compairing the debtor with file
                //}
                order = orders.Where(o => o.Account == s[0]).FirstOrDefault(); // always null.
                if (order == null) { // if null, as it always will be because we never pop the variable
                    order = new DebtorOrderClient(); // pop the variable with a empty object
                    order.SetMaster(debtors.Where(d => d.Account == s[0]).First()); // 
                    orders.Add(order);
                    var orderres = await crudAPI.Insert(order);
                }
                var item = items.Where(i => i.Item == s[1]).First();
                var fp = new FindPrices(order, crudAPI) {
                    UseCustomerPrices = true
                };
                // await fp.loadPriceList(); // hvad fuck gøre dette ? HVAD GØRE DU!!! ?
                var DOL = new DebtorOrderLineClient {
                    Qty = double.Parse(s[2]),
                    Item = item.Item,
                    // Date = DateTime.Parse(s[3]), // there is not 3 column ???
                };
                DOL.SetMaster(order);
                var CC = new ContactClient {
                    Name = "test",
                    Email = "temp@maxium.dk",
                };
                CC.SetMaster(order);
                //await fp.SetPriceFromItem(ol, item); // hvad gøre disse ? virker fint uden ?_?
                await crudAPI.Insert(DOL);
            }
        }
        public string[] GetDependentAssembliesName() {
            return new string[] { };
        }
        public string GetErrorDescription() {
            return errorMSG;
        }
        public void SetAPI(BaseAPI api) {
            crudAPI = api as CrudAPI;
        }
    }
}
