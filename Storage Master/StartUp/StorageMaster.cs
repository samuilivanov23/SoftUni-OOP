﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace StorageMaster
{
    class StorageMaster
    {
        public List<Product> Pool { get; set; }

        public string AddProduct(string type, double price)
        {
            throw new NotImplementedException();
        }



        public string RegisterStorage(string type, string name)

        {

            throw new NotImplementedException();

        }



        public string SelectVehicle(string storageName, int garageSlot)

        {

            throw new NotImplementedException();

        }



        public string LoadVehicle(IEnumerable<string> productNames)

        {

            throw new NotImplementedException();

        }



        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)

        {

            throw new NotImplementedException();

        }



        public string UnloadVehicle(string storageName, int garageSlot)

        {

            throw new NotImplementedException();

        }



        public string GetStorageStatus(string storageName)

        {

            throw new NotImplementedException();

        }



        public string GetSummary()

        {

            throw new NotImplementedException();

        }
    }
}
