using System;

namespace ListingsTrades.Models
{
    public class Classifications
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Acct_Id { get; set; }
        public string GST { get; set; }
        public double Ends { get; set; }
        public string Type { get; set; }
        public int BrokerAccount { get; set; }
        public int AgentAccount { get; set; }
        public int FeeAccount { get; set; }
        public double TaxRate { get; set; }
        public int TaxAccount { get; set; }
        public bool ChargeHOFees { get; set; }
        public bool AllowFeeDiscounting { get; set; }
        public bool ChargePST { get; set; }
        public double PSTRate { get; set; }
        public int CreditOffice { get; set; }
        public string ListStatus { get; set; }
        public int CommissionPlan { get; set; }
        public int BrokerAccount_S { get; set; }
        public int AgentAccount_S { get; set; }
        public int RevenueAccount_S { get; set; }
        public bool NotIn231 { get; set; }
        public DateTime InactiveDate { get; set; }
    }
}