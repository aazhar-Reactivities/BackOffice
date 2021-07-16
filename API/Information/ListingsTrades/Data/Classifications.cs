using System;

namespace ListingsTrades.Data
{
    public class Classifications
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Acct_Id { get; set; }
        public string GST { get; set; }
        public decimal Ends { get; set; }
        public string Type { get; set; }
        public int BrokerAccount { get; set; }
        public int AgentAccount { get; set; }
        public int FeeAccount { get; set; }
        public decimal TaxRate { get; set; }
        public int TaxAccount { get; set; }
        public Boolean ChargeHOFees { get; set; }
        public Boolean AllowFeeDiscounting { get; set; }
        public Boolean ChargePST { get; set; }
        public decimal PSTRate { get; set; }
        public int CreditOffice { get; set; }
        public string ListStatus { get; set; }
        public int CommissionPlan { get; set; }
        public int BrokerAccount_S { get; set; }
        public int AgentAccount_S { get; set; }
        public int RevenueAccount_S { get; set; }
        public Boolean NotIn231 { get; set; }
        public DateTime InactiveDate { get; set; }



    }
}