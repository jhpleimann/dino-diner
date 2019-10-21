using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class used to do custom orders.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// The Order constructor
        /// </summary>
        public Order()
        {
            SalesTaxRate = 0.15;
            Items = new ObservableCollection<IOrderItem>();
        }

        /// <summary>//
        /// The items added to the order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

        /// <summary>
        /// Calculates the total price from the prices of all order items.
        /// </summary>
        public double SubtotalCost {
            get
            {
                double cost = 0;
                foreach(IOrderItem a in Items)
                {
                    cost += a.Price;
                }
                if(cost < 0)
                {
                    return 0;
                }
                return cost;
            }
        }

        /// <summary>
        /// Calculates the total price from the prices of all order items.
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// Calculates the total price from the prices of all order items.
        /// </summary>
        public double SalesTaxCost { 
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// Calculates the total price from the prices of all order items.
        /// </summary>
        public double TotalCost {
            get
            {
                return SalesTaxCost + SubtotalCost;
            }
        }

    }
}
