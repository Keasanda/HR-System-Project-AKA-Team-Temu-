using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class BankingDetail
    {
        public int BankingDetailId { get; set; }
        public string BankName { get; set; } = string.Empty;
        public string AccountType { get; set; } = string.Empty;
        public int AccountNumber { get; set; }
        public int BranchCode { get; set; }
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }

    }
}