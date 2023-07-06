using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.DespatchConfirm
{
    public class DespatchConfirm
    {
        public string requestID { get; set; }
        public string itemID { get; set; }
        public string ItemName { get; set; }
        public int requestQty { get; set; }
        public string unit { get; set; }
        public string itemStatus { get; set; }
    }
}
