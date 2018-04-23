Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports XpoTutorial2.DataModel

Namespace XpoTutorial2
    Partial Public Class XtraForm1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub XtraForm1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            If xpCollection1.Count = 0 Then
                Dim customer1 = New Customer(session1)
                customer1.Name = "John"
                customer1.Age = 21
                customer1.Orders.Add(New Order(session1) With {.ProductName = "Chai", .OrderDate = New Date(2013, 3, 11)})
                customer1.Orders.Add(New Order(session1) With {.ProductName = "Konbu", .OrderDate = New Date(2013, 1, 23)})
                customer1.Save()
                xpCollection1.Add(customer1)

                Dim customer2 = New Customer(session1)
                customer2.Name = "Bob"
                customer2.Age = 37
                customer2.Orders.Add(New Order(session1) With {.ProductName = "Queso Cabrales", .OrderDate = New Date(2013, 2, 9)})
                customer2.Save()
                xpCollection1.Add(customer2)
            End If
        End Sub
    End Class
End Namespace