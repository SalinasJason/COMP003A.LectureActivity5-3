namespace COMP003A.LectureActivity5_3
{
    /// <summary>
    /// Represents a generic shape with an abstract method.
    /// </summary>
    abstract class Shape
    {
        // Auto-implemented property
        public string Name { get; set; }

        /// <summary>
        /// Abstract method to calculate area.
        /// </summary>
        public abstract double CalculateArea();

        /// <summary>
        /// Displays the shape's name.
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
