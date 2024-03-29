﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP3Me
{
    // public class that globally stores our project's data
    public class Data
    {
        // Static Field
        //because we want this data to be updated via all windows of the app when it gets updated.
        public static ObservableCollection<Product> products = new ObservableCollection<Product>(); // Initialized Instance



        // Static Constructor
        static Data()
        {
            products = new ObservableCollection<Product>(); // Initialized new instance of Product

            Preload(); // Runs this Static Method we created below

        }




        // Static Method
        static void Preload()
        {
            Data.products.Add(new HotDrink("Hot Coco", 2.50m, 100, Drink.Size.Venti, 110.21));
        }




    }
}
