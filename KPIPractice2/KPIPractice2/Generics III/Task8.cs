namespace KPIPractice2
{
    // Коваріантність IEnumerable<out T>
    // - Створіть DeliveryCenter, NovaPoshta:DeliveryCenter.
    // - Поясніть, чому IEnumerable<NovaPoshta> → IEnumerable<DeliveryCenter> працює.
    public class Task8
    {
        public void Main()
        {
            List<NovaPoshta1> novaList = new List<NovaPoshta1>();
            IEnumerable<DeliveryCenter1> deliveryCenters = novaList;
            foreach (var d in deliveryCenters)
            {
                Console.WriteLine(d.GetType().Name); 
            }
        }

    }
    class DeliveryCenter1
    {

    }
    class NovaPoshta1 : DeliveryCenter1
    {

    }
}
