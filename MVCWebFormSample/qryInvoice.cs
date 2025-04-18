//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWebFormSample
{
    using System;
    using System.Collections.Generic;
    
    public partial class qryInvoice
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateAbbrev { get; set; }
        public string Zip { get; set; }
        public int OrderID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public Nullable<int> ShipperID { get; set; }
        public Nullable<decimal> ShippingFee { get; set; }
        public Nullable<float> TaxRate { get; set; }
        public Nullable<byte> TaxStatusID { get; set; }
        public string PaymentMethod { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public string Notes { get; set; }
        public Nullable<int> OrderStatusID { get; set; }
        public string AddedBy { get; set; }
        public Nullable<System.DateTime> AddedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string SalesPerson { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<short> Quantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<float> Discount { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
    }
}
