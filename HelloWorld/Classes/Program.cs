﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes
{


    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Person maggie = new Person();
            maggie.FirstName = "Maggie";
            maggie.LastName = "Tanner";
            maggie.Introduce();

            
        }

    }

}


