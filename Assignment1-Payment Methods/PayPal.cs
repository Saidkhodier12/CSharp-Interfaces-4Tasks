﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Payment_Methods;
internal class PayPal :IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Payment Using PayPal , Amount = {amount}");
    }
}