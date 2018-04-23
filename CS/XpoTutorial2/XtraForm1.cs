using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using XpoTutorial2.DataModel;

namespace XpoTutorial2 {
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm {
        public XtraForm1() {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e) {
            if (xpCollection1.Count == 0) {
                var customer1 = new Customer(session1);
                customer1.Name = "John";
                customer1.Age = 21;
                customer1.Orders.Add(new Order(session1) { 
                    ProductName = "Chai", 
                    OrderDate = new DateTime(2013, 3, 11) 
                });
                customer1.Orders.Add(new Order(session1) {
                    ProductName = "Konbu",
                    OrderDate = new DateTime(2013, 1, 23)
                });
                customer1.Save();
                xpCollection1.Add(customer1);

                var customer2 = new Customer(session1);
                customer2.Name = "Bob";
                customer2.Age = 37;
                customer2.Orders.Add(new Order(session1) {
                    ProductName = "Queso Cabrales",
                    OrderDate = new DateTime(2013, 2, 9)
                });
                customer2.Save();
                xpCollection1.Add(customer2);
            }
        }
    }
}