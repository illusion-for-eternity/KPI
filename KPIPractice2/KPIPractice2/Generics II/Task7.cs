namespace KPIPractice2
{
    //  SendPackage<T> where T : DeliveryCenter, IDelivery
    // - Оголосіть DeliveryCenter та IDelivery { void Deliver(); }.
    // - Реалізуйте NovaPoshta : DeliveryCenter, IDelivery.
    // - Метод void SendPackage<T>(T c) where T:DeliveryCenter,IDelivery { c.Deliver(); }.
    public class Task7
    {
        public void Main()
        {
            NovaPoshta novaPoshta= new NovaPoshta();
            SendPackage(novaPoshta);
        }
        static void SendPackage<T>(T c) where T:DeliveryCenter,IDelivery
        {
            c.Deliver();
        }
    }
    public class NovaPoshta: DeliveryCenter, IDelivery
    {
        public void Deliver()
        {
            Console.WriteLine("Delivered");
        }
    }
    public interface IDelivery
    {
        void Deliver();
    }
    public class DeliveryCenter
    {

    }
}
