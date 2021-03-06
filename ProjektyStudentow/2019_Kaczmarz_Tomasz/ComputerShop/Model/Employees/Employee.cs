﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Model.Employees
{
    /// <summary>
    /// Łańcuch zobowiązań (Chain of Responsibility) - czynnościowy
    /// </summary>
    abstract class Employee
    {
        protected Employee successor;

        public void SetSuccessor(Employee successor)
        {
            this.successor = successor;
        }

        public abstract string ProcessOrder(Order order);
    }
}
