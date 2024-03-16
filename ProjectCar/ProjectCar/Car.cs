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


    }
}
