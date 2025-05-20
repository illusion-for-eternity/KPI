namespace KPIPractice2
{
    // Власні IProducer<out T> та IConsumer<in T>
    // - Оголосіть IProducer<out T> { T Produce(); } та IConsumer<in T> { void Consume(T); }.
    // - Реалізуйте NovaPoshtaProducer : IProducer<NovaPoshta>, DeliveryCenterConsumer : IConsumer<DeliveryCenter>.
    // - Покажіть присвоєння IProducer<NovaPoshta> → IProducer<DeliveryCenter> і IConsumer<DeliveryCenter> → IConsumer<NovaPoshta>.
    public class Task10
    {
        public void Main()
        {
            IProducer<NovaPoshta4> novaProducer = new NovaPoshtaProducer();
            IProducer<DeliveryCenter4> deliveryProducer = novaProducer; // Ковараіантність

            IConsumer<DeliveryCenter4> deliveryConsumer = new DeliveryCenterConsumer();
            IConsumer<NovaPoshta4> novaConsumer = deliveryConsumer; // Контраваріантність

        }
    }
    interface IProducer<out T>
    {
        T Produce();
    }
    interface IConsumer<in T>
    {
        void Consume(T item);
    }
    class NovaPoshta4 : DeliveryCenter4
    {

    }
    class DeliveryCenter4
    {
        public DeliveryCenter4()
        {
            Console.WriteLine("Delivered");
        }
    }
    class DeliveryCenterConsumer : IConsumer<DeliveryCenter4>
    {
        public void Consume(DeliveryCenter4 item)
        {
            Console.WriteLine("Consuming delivery");
        }
    }
    class NovaPoshtaProducer : IProducer<NovaPoshta4>
    {
        public NovaPoshta4 Produce()
        {
            return new NovaPoshta4();
        }
    }
}
