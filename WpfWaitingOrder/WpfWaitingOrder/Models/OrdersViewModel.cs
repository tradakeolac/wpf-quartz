using System.Collections.ObjectModel;
using WpfWaitingOrder.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfWaitingOrder.Models
{
    public class OrdersViewModel : ObservableObject
    {
        public OrdersViewModel()
        {
            this.Orders = new ObservableCollection<Order>();
        }

        public ICommand AddNewOrderCommand
        {
            get { return new DelegateCommand(AddNewOrder); }
        }

        public ObservableCollection<Order> Orders { get; set; }

        private void AddNewOrder()
        {
            var order = new Order(this.Orders.Count);
            this.Orders.Add(order);
        }
    }
}
