
namespace Indexers
{
    public class Program
    {
        public delegate void RectDelegate(decimal W, decimal H);
        static int Main(string[] args)
        {
            // Mulitcast Delegate
            var helper = new RectngleHelper();
            //helper.GetArea(10, 10);
            //helper.GetPerimeter(10, 10);
            RectDelegate rect = helper.GetArea;
            rect += helper.GetPerimeter;
            rect(10, 20);
            rect -= helper.GetArea;
            Console.WriteLine("After Leaving GetArea Method...");
            rect(10, 10);
            return 0;
        }

    }

    public class RectngleHelper
    {
        public void GetArea(decimal Width, decimal Height)
        {
            var result = Width * Height;
            Console.WriteLine($"Area = {Width} x {Height} = {result}");
        }

        public void GetPerimeter(decimal Width, decimal Height)
        {
            var result = (Width + Height) * 2;
            Console.WriteLine($"Perimeter = ({Width} + {Height}) x 2 = {result}");
        }
    }
}
