﻿using System;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(method);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
