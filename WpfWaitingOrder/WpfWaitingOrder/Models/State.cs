using System.Windows.Media;
using System;

namespace WpfWaitingOrder.Models
{
    public abstract class State
    {
        public abstract void CheckOrderWaiting(Order order);

        public abstract Brush Color { get; }
    }

    public class GreenState : State
    {
        public override Brush Color => Brushes.Green;

        public override void CheckOrderWaiting(Order order)
        {
            if ((DateTime.Now - order.Created).Minutes >= 15)
                order.State = new OrangeState();
        }
    }

    public class OrangeState : State
    {
        public override Brush Color => Brushes.OrangeRed;

        public override void CheckOrderWaiting(Order order)
        {
            if ((DateTime.Now - order.Created).Minutes >= 30)
                order.State = new RedState();
        }
    }

    public class RedState : State
    {
        public override Brush Color => Brushes.Red;

        public override void CheckOrderWaiting(Order order)
        {
            //
        }
    }
}
