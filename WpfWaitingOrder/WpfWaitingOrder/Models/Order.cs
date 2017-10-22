using WpfWaitingOrder.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWaitingOrder.Models
{
    public class Order : ObservableObject
    {
        public Order(int ordered)
        {
            this.Created = DateTime.Now;
            this.State = new GreenState();
            this.Name = "Order " + ordered;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                this._name = value;
                RaisePropertyChangedEvent("Name");
            }
        }

        private State _state;
        public State State
        {
            get { return _state; }
            set
            {
                this._state = value;
                RaisePropertyChangedEvent("State");
            }
        }

        public DateTime Created { get; }
    }
}
