using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void ShouldHaveCorrectCalculatedCost()
        {
            Order order = new Order();
            Triceritots tric = new Triceritots();//Default price is .99
            Water water = new Water();//Default Price is .1
            Brontowurst bron = new Brontowurst();//Default Price is 5.36
            //Total Price is 6.45. 6.45 * .15(tax) + 6.45 = 7.4175, which can be rounded up to 7.42
            order.Add(tric);
            order.Add(water);
            order.Add(bron);
            Assert.Equal(7.42 , order.TotalCost, 2);
        }

        [Fact]
        public void SubtotalCostShouldNeverBeZero()
        {
            Order order = new Order();
            Triceritots tric = new Triceritots();
            tric.Price = -123543;
            order.Add(tric);
            Assert.Equal(0, order.SubtotalCost, 2);
        }
    }
}
