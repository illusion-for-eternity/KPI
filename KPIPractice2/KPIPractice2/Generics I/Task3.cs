namespace KPIPractice2
{
    // Pair<TKey, TValue> — пара «Key–Value»
    // - Створіть generic-клас Pair<TKey, TValue> з полями Key, Value.
    // - Реалізуйте конструктор та ToString() → "[Key:…, Value:…]".
    // - У Main продемонструйте Pair<int,string> та Pair<Guid,DateTime>.
    public class Task3
    {
        public void Main()
        {
            Pair<int,string> pair=new Pair<int, string>(16,"Miku");
            Console.WriteLine(pair.ToString());

            Guid guid=Guid.NewGuid();
            DateTime dateTime=DateTime.Now;
            
            Pair<Guid,DateTime> pair1=new Pair<Guid, DateTime>(guid,dateTime);
            Console.WriteLine(pair1.ToString());
        }
        class Pair<TKey,TValue>
        {
            public TKey Key;
            public TValue Value;
            public Pair(TKey Key, TValue Value)
            {
                this.Key= Key;
                this.Value=Value;
            }
            public override string ToString()
            {
                return $"Key -> {Key} || Value -> {Value}";
            }
        }
    }
}
