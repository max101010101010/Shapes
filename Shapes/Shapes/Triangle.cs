namespace Shapes
{
    public class Triangle : IShape
    {
        #region Private Fields

        private double area;

        #endregion Private Fields

        #region Constructors

        public Triangle(float sideA, float sideB, float sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            //Validation
            if( !IsCorrectSidesRatio())
            {
                throw new Exception("Every side must be smaller than sum of the other two.");
            }
            //Area calculate
            SetAreaBySides();
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Сторона 1
        /// </summary>
        public float SideA { get; }
        /// <summary>
        /// Сторона 2
        /// </summary>
        public float SideB { get; }
        /// <summary>
        /// Сторона 3
        /// </summary>
        public float SideC { get; }

        public double Area { get => area; }

        /// <summary>
        /// Прямоугольный ли этот треугольник
        /// </summary>
        /// <returns></returns>
        //  (есть вероятно множество других, более правильных способов как осуществить такую проверку, но я решил сделать именно так)
        //  *** написано с целью развитие наблюдательности у читающего и вырабатыванию иммунитета к однострочникам и их вариантам ***
        //  Идея проста - определения наибольшей стороны и проверка выполнения формулы Пифагора с предположением что данная сторона является гипотенузой
        //  У данного способа есть и положительный момент - в лучшем случае(равносторонний треугольник) будет осуществлено всего три проверки без вычислений квадратов
        public bool IsItRight() =>
                   SideA > SideB && SideA > SideC && SideA * SideA == SideB * SideB + SideC * SideC
                || SideB > SideC && SideB > SideA && SideB * SideB == SideC * SideC + SideA * SideA
                || SideC > SideA && SideC > SideB && SideC * SideC == SideA * SideA + SideB * SideB;


        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Вычисление площади по формуле Герона
        /// </summary>
        private void SetAreaBySides()
        {
            var p = (SideA + SideB + SideC) / 2;//половина периметра
            area = Math.Sqrt(
                p
                * (p - SideA)
                * (p - SideB)
                * (p - SideC)
            );
        }

        #region Validation

        /// <summary>
        /// Каждая сторона треугольника должна быть меньше суммы двух оставшихся сторон
        /// </summary>
        /// <returns></returns>
        private bool IsCorrectSidesRatio() =>
                SideA < SideB + SideC
            &&  SideB < SideC + SideA
            &&  SideC < SideA + SideB;

        #endregion Validation

        #endregion Private Methods
    }

}

