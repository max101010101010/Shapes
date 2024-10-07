using Shapes;

namespace Tests
{
    public class TriangleTests
    {
        [TestCase(1f, 0f, 0f)]
        [TestCase(1f, 3f, 5f)]        
        [TestCase(0f, 0f, 0f)]
        public void ErrorWhenWrongSidesRation(float sideA, float sideB, float sideC) =>        
            Assert.Throws<Exception>(() => new Triangle(sideA, sideB, sideC));

                
        [TestCase(1f, 1f, 1f, ExpectedResult = 0.433d)]
        [TestCase(1f, 2f, 2f, ExpectedResult = 0.968d)]
        [TestCase(3f, 4f, 5f, ExpectedResult = 6d)]
        [TestCase(5f, 6f, 7f, ExpectedResult = 14.697d)]        
        public double GetArea_BySides(float sideA, float sideB, float sideC)
            => Math.Round(new Triangle(sideA, sideB, sideC).Area, 3);

        
        [TestCase(1f, 1f, 1f, ExpectedResult = false)]
        [TestCase(1f, 2f, 2f, ExpectedResult = false)]
        [TestCase(3f, 4f, 5f, ExpectedResult = true)]
        [TestCase(4f, 3f, 5f, ExpectedResult = true)]
        [TestCase(5f, 3f, 4f, ExpectedResult = true)]
        [TestCase(5f, 6f, 7f, ExpectedResult = false)]
        [TestCase(9f, 12f, 15f, ExpectedResult = true)]
        public bool RigthTriangeleCheck_BySides(float sideA, float sideB, float sideC)
            => new Triangle(sideA, sideB, sideC).IsItRight();
    }
}