using System.Runtime.CompilerServices;

namespace KPIPractice2
{
    // IStorage<T> & ListStorage<T>
    // - Оголосіть interface IStorage<T>
    // {
    //  void Add(T);
    //  T Get(int);
    //  int Count;
    // }.
    // - Реалізуйте ListStorage<T> на базі List<T>.
    // - У Main додайте/отримайте елементи int, string тощо.
    public class Task4
    {
        public void Main()
        {
            ListStorage<int> listStorage= new ListStorage<int>();
            listStorage.Add(10);
            listStorage.Add(20);
            listStorage.Add(30);
            Console.WriteLine(listStorage.Get(2));
        }
        interface IStorage<T>
        {
            int Count { get; }
            void Add(T count);
            T Get(int num);
        }
        class ListStorage<T> : IStorage<T>
        {
            public List<T> list = new List<T>();
            public int Count =>list.Count;
            public void Add(T item)
            {
                list.Add(item);
            }
            public T Get(int num)
            {
                return list[num];
            }
        }
    }
}
