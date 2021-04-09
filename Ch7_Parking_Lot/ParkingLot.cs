using System;
using System.Collections.Generic;
using System.Text;

namespace Ch7_Parking_Lot
{
    public class ParkingLot
    {
        //fields
        private int mysmallcar;
        private int mymediumcar;
        private int mylargecar;

        //Constructor
        public ParkingLot(int mysmallcar, int mymediumcar, int mylargecar) // integer entered in parameter will become value of size
        {
            this.mysmallcar = mysmallcar;
            this.mymediumcar = mymediumcar;
            this.mylargecar = mylargecar;
        }

        public bool AddCar(string carType)
        {
            carType = carType.ToLower();
            bool myparkingspace = false; //value to return to AddCar
            if(carType == "small" && mysmallcar > 0)
            {
                myparkingspace = true;//changes bool value to true and returns value;
                --mysmallcar;
            }
            else if(carType == "medium" && mymediumcar > 0)
            {
                myparkingspace = true;
                --mymediumcar;
            }
            else if (carType == "large" && mylargecar > 0)
            {
                myparkingspace = true;
                --mylargecar;
            }
            return myparkingspace;
        }
    }
}
