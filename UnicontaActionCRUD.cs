using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniconta.API.System;
using Uniconta.ClientTools.DataModel;
using Uniconta.Common;

namespace WinFormServer {
    class UnicontaActionCRUD {
        public async Task<string> Uniconta_Insert(CrudAPI CrudAPI) { // insert method take the CRUDAPI
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
