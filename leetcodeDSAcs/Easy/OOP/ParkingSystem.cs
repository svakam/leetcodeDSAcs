using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.OOP
{
    // runtime: 172 ms, 96.41% faster
    // memory: 43.2 mb, 86.27% less

    /**
     * Your ParkingSystem object will be instantiated and called as such:
     * ParkingSystem obj = new ParkingSystem(big, medium, small);
     * bool param_1 = obj.AddCar(carType);
     */


    public class ParkingSystem
    {
        int Big { get; set; }
        int Medium { get; set; }
        int Small { get; set; }

        public ParkingSystem(int b, int m, int s)
        {
            Big = b;
            Medium = m;
            Small = s;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if (Big > 0)
                    {
                        Big--;
                        return true;
                    }
                    break;
                case 2:
                    if (Medium > 0)
                    {
                        Medium--;
                        return true;
                    }
                    break;
                case 3:
                    if (Small > 0)
                    {
                        Small--;
                        return true;
                    }
                    break;
            }
            return false;
        }
    }
}
