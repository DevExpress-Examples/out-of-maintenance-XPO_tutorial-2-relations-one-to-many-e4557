//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace XpoTutorial2.DataModel {

    public partial class Customer : XPObject {
        string fName;
        public string Name {
            get { return fName; }
            set { SetPropertyValue<string>("Name", ref fName, value); }
        }
        ushort fAge;
        public ushort Age {
            get { return fAge; }
            set { SetPropertyValue<ushort>("Age", ref fAge, value); }
        }
        [Association(@"OrderReferencesCustomer", typeof(Order))]
        public XPCollection<Order> Orders { get { return GetCollection<Order>("Orders"); } }
    }

}
