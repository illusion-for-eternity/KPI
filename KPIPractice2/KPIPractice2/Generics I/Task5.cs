namespace KPIPractice2
{
    // Add<T> where T : struct — сума двох чисел
    // - Реалізуйте T Add<T>(T a, T b) where T : struct.
    // - У Main: Add(2,3) → 5; спробуйте Add("a","b") і поясніть помилку.
    public class Task5
    {
        public void Main()
        {
            Console.WriteLine(Add(2,3));
            Console.WriteLine(Add('f','k'));
        }
        static T Add<T>(T a, T b) where T : struct
        {
            return (dynamic )a+(dynamic )b;
        }
    }
}
