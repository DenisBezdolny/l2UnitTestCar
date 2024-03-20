using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCar
{
    public class Car
    {
        public int GetRandomSpeed()
        {
            var random = new Random();
            int speed = random.Next(0, 200);

            return (speed);
        }

        public bool CanItBeUsedInThePlace(PlaceForUsingCar placeForUsingCar)
        {
            switch (placeForUsingCar)
            {
                case PlaceForUsingCar.City:
                case PlaceForUsingCar.Field:
                case PlaceForUsingCar.Forest:
                    return true;
                case PlaceForUsingCar.Desert:
                case PlaceForUsingCar.Ocean:    
                    return false;

                default: return false;
                    
            }

        }


    }
}
