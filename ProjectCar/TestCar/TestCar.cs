using ProjectCar;

namespace TestCar
{
    public class TestCar : IDisposable
    { 

        private Car _car;

        public TestCar()
        {
            _car = new Car();
        }
        public void Dispose()
        {

        }

        [Fact]
        public void TestCarSpeedIsTooFastOrNot()
        {
            //arrange
            

            //act

            var car_speed = _car.GetRandomSpeed();

            //array

            if (car_speed > 100)
            {
                Assert.Fail("Wow wow, cool down, its too fast");
            }
        }
        [Theory]
        [InlineData(new object[] { PlaceForUsingCar.City, true })]
        [InlineData(new object[] { PlaceForUsingCar.Forest, true })]
        [InlineData(new object[] { PlaceForUsingCar.Desert, false })]
        [InlineData(new object[] { PlaceForUsingCar.Field, false })]
        [InlineData(new object[] { PlaceForUsingCar.Ocean, false })]
        public void CanItBeUsedToDriveInIt(PlaceForUsingCar placeForUsingCar, bool expectedResult)
        {
            //arrange in constructor


            //act
            var result = _car.CanItBeUsedInThePlace(placeForUsingCar);

            //assert
            Assert.Equal(expectedResult, result);

        }
    }
}