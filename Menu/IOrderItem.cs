/*  IOrderItem
*   Author: Jack Pleimann
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Everything in the order will have to implement the methods of IOrderItem
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
    /// <summary>
    /// Gets the price
    /// </summary>
    double Price { get; }

    /// <summary>
    /// Gets the description of the order
    /// </summary>
    string Description { get; }

    /// <summary>
    /// Gets the special instructions
    /// </summary>
    string[] Special { get; }
    }
}