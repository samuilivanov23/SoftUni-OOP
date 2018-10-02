using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StorageMaster
{
    public abstract class Storage
    {

        public Vehicle[] Garage { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int GarageSlots { get; set; }
        readonly List<Product> loot;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            Name = name;
            Capacity = capacity;
            GarageSlots = garageSlots;
            this.Garage = vehicles.ToArray();
        }

        private bool IsFull()
        {
            if (loot.Sum(x => x.Weight) >= Capacity)
            {
                return true;
            }
            return false;
        }

        private bool IsEmpty()
        {
            return loot.Count == 0;
        }

        Vehicle GetVehicle(int garageSlot)
        {
            if(garageSlot > GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            else if(Garage.Length == 0)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            return Garage[garageSlot];
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = GetVehicle(garageSlot);

            bool isGarageFull = true;

            foreach(var _vehicle in deliveryLocation.Garage)
            {
                if(_vehicle == null)
                {
                    isGarageFull = false;
                    break;
                }
            }

            if (isGarageFull) throw new InvalidOperationException("No room in garage!");

            Vehicle vehicleToBeSent = Garage[garageSlot];
            Garage[garageSlot] = null;
            int GarageSlotIndex = 0;

            foreach(var _vehicle in deliveryLocation.Garage)
            {
                if(_vehicle == null)
                {
                    deliveryLocation.Garage[garageSlot] = vehicleToBeSent;
                    break;
                }
                else
                {
                    GarageSlotIndex++;
                }
            }

            return GarageSlotIndex;
        }

        int UnloadVehicle(int garageSlot)
        {
            if(loot.Count == GarageSlots)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            int unloadProductCount = 0;
            Vehicle vehicle = GetVehicle(garageSlot);

            while (!vehicle.IsEmpty())
            {
                loot.Add(vehicle.Unload());
                unloadProductCount++;
            }
            return unloadProductCount;
        }
    }
}
