namespace Shapes
{
    public class Circle : IShape
    {
        #region Private Fields

        private double area;

        #endregion Private Fields

        #region Constructors

        public Circle(float radius)
        {
            Radius = radius;
            //Area calculate
            SetAreaByRadius();
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Радиус
        /// </summary>
        public float Radius { get; }
        public double Area { get => area; }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Вычисление площади по известному радиусу
        /// </summary>
        private void SetAreaByRadius()
        {
            area = Math.PI * Math.Pow(Radius, 2);
        }

        #endregion Private Methods
    }

}

