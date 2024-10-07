using Shapes;

namespace Tests
{
    public class CircleTests
    {        

        [TestCase(0f, ExpectedResult = 0d)]
        [TestCase(3f, ExpectedResult = 28.274d)]
        [TestCase(5f, ExpectedResult = 78.540d)]
        [TestCase(11f, ExpectedResult = 380.133d)]
        public double GetArea_ByRadius(float radius) 
            => Math.Round(new Circle(radius).Area,3);
        
    }
}