using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfInvoices
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Wk07_InvoicesContext db = new Wk07_InvoicesContext();
        public MainWindow()
        {
            InitializeComponent();
            RefreshInvoices();
            RefreshItems();
            RefreshComboBox();          
        }
        private void RefreshInvoices()
        {
            //dgrdInvoices.ItemsSource = db.Invoices.SelectMany(x => x.Items).ToList();
            dgrdInvoices.ItemsSource = db.Invoices.Select(x => x).ToList();
        }
        private void RefreshComboBox()
        {
            cboInvoice.ItemsSource = db.Invoices.Select(x => x).ToList();
        }
        private void RefreshItems()
        {
            dgrdItems.ItemsSource = db.Items.Select(x => new {x.Invoice, x.Name, x.Quantity, x.Price }).ToList();
        }

        private void btnAddInvoice_Click(object sender, RoutedEventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.Name = txtName.Text;
            invoice.Address = txtAddress.Text;
            invoice.InvId = db.Invoices.Max(x => x.InvId) + 1;
            invoice.Paid = "n";
            invoice.Amount = 0;
            db.Invoices.Add(invoice);
            db.SaveChanges();
            RefreshInvoices();
            RefreshComboBox();
        }
        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            Item item = new Item();
            item.Name = txtItemName.Text;
            item.Price = Convert.ToDecimal(txtPrice.Text);
            item.Quantity = Convert.ToInt32(txtQuantity.Text);
            item.InvoiceID = (cboInvoice.SelectedValue as Invoice).InvId;
            db.Items.Add(item);
            db.SaveChanges();
            RefreshItems();
        }
    }
    partial class Invoice
    {
        public override string ToString() => $"{InvId} - {Name}";
    }
}
