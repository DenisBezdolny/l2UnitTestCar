using ProjectCar;

namespace TestCar
{
    public class TestCarSpeed
    {
        [Fact]
        public void TestCarSpeedIsTooFastOrNot()
        {
            //arrange
            

            var car = new Car();

            //act

            var car_speed = car.GetRandomSpeed();

            //array

            if (car_speed > 100)
            {
                Assert.Fail("Wow wow, cool down, its too fast");
            }


        }
    }
}