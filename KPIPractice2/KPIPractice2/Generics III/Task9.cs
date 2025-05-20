namespace KPIPractice2
{
    //  Контраваріантність IComparer<in T>
    // - Реалізуйте DeliveryCenterComparer : IComparer<DeliveryCenter>.
    // - Покажіть, що IComparer<DeliveryCenter> можна присвоїти IComparer<NovaPoshta> і відсортувати NovaPoshta[].
    public class Task9
    {
        public void Main()
        {
            NovaPoshta3[] novaPoshta3s =
            {
            new NovaPoshta3 { Name = "ccccc" },
            new NovaPoshta3 { Name = "bbbbb" },
            new NovaPoshta3 { Name = "aaaaa" },
            };
            Array.Sort(novaPoshta3s, new DeliveryCenterComparer());

            foreach (var np in novaPoshta3s)
            {
                Console.WriteLine(np.Name);
            }
        }
    }
    class DeliveryCenterComparer : IComparer<DeliveryCenter3>
    {
        public int Compare(DeliveryCenter3 x, DeliveryCenter3 y)
        {
            return string.Compare(x.Name, y.Name);
        }

    }
    class NovaPoshta3 : DeliveryCenter3
    {
    }
    class DeliveryCenter3
    {
        public string Name { get; set; }
    }
}
