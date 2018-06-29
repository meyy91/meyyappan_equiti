using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class FinancialData
    {
        public string Id { get; set; }

        public long ApplicationId { get; set; }

        public string Type { get; set; }

        public string Summary { get; set; }

        public float Amount { get; set; }

        public DateTimeOffset PostingDate { get; set; }

        public bool IsCleared { get; set; }

        public DateTimeOffset ClearedDate { get; set; }
    }
}