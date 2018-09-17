
namespace Solid_Princicles_Class_Library
{
    class Interface_Segregation_Principle_Correctly_Done
    {
        public interface IOrder
        {
            void Purchase();
        }

        public interface IOnlineOrder
        {
            void ProcessCreditCard();
        }

        public class OnlineOrder : IOrder, IOnlineOrder
        {
            public void Purchase()
            {
                //Do purchase
            }

            public void ProcessCreditCard()
            {
                //process through credit card
            }
        }

        public class InpersionOrder : IOrder
        {
            public void Purchase()
            {
                //Do purchase
            }
        }
    }
}
