using System.Collections.Generic;
using Uniconta.ClientTools.DataModel;

namespace WinFormServer {
    class UnicontaWrapper {
        public List<DebtorClient> debtors { get; set; }
        public List<DebtorGroupClient> dGroups { get; set; }
        public List<DebtorPriceListClient> dPrices { get; set; }
        public List<PaymentTermClient> dPayment { get; set; }
    }
}
