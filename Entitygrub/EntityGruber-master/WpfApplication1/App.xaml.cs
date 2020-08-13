using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using EntityGruber;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var m = new MainWindow();
            using (var db = new GruberContext())
            {
                //var s = db.Salespeople.ToList();
                var s = (from order in db.Orders.Include("Salesperson").Include("Customers")
                         where order.Customer.City == order.Salesperson.City
                         group order by order.Odate into dates
                         select new { dates.Key, Amt = dates.Sum(o => o.Amt) }).ToList();
                //var s = (from order in db.Orders.Include("Customer")
                //         where order.Customer.Snum != order.Customer.Snum
                //         group order by order.Customer.Cname into Customer
                //         select Customer.Key).ToList();
                m.dataGrid.ItemsSource = s;
            }
            m.Show();
        }
    }
}
