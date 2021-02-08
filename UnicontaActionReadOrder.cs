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
        private string error;
        private CrudAPI crudAPI;

        public event EventHandler OnExecute;

        public ErrorCodes Execute(UnicontaBaseEntity master, UnicontaBaseEntity currentRow, IEnumerable<UnicontaBaseEntity> source, string command, string args) {
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
                    string[] values = line.Split(';');
                    lines.Add(values);
                }
            }
            
            createLines(lines);
            return ErrorCodes.Succes;
        }

        private async void createLines(List<string[]> lines) {
            var orders = new List<DebtorOrderClient>();
            var ols = new List<DebtorOrderLineClient>();
            var items = await crudAPI.Query<InvItemClient>();
            var debtors = await crudAPI.Query<DebtorClient>();

            foreach (string[] s in lines) {
                DebtorOrderClient order;
                order = orders.Where(o => o.Account == s[0]).FirstOrDefault();
                if (order == null) {
                    order = new DebtorOrderClient();
                    order.SetMaster(debtors.Where(d => d.Account == s[0]).First());
                    orders.Add(order);
                    var orderres = await crudAPI.Insert(order);
                }
                var item = items.Where(i => i.Item == s[1]).First();
                var fp = new FindPrices(order, crudAPI) {
                    UseCustomerPrices = true
                };
                await fp.loadPriceList();
                var ol = new DebtorOrderLineClient {
                    Qty = double.Parse(s[2]),
                    Item = item.Item,
                    Date = DateTime.Parse(s[3]),
                };
                ol.SetMaster(order);
                await fp.SetPriceFromItem(ol, item);
                await crudAPI.Insert(ol);
            }
        }
        public string[] GetDependentAssembliesName() {
            return new string[] { };
        }
        public string GetErrorDescription() {
            return error;
        }
        public void SetAPI(BaseAPI api) {
            crudAPI = api as CrudAPI;
        }
    }
}
