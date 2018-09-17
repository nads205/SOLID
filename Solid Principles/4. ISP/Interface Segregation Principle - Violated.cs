﻿using System;

namespace Solid_Princicles_Class_Library
{
    class Interface_Segregation_Principle_Voilated
    {
        public interface IOrder
        {
            void Purchase();
            void ProcessCreditCard();
        }

        public class OnlineOrder : IOrder
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

            public void ProcessCreditCard()
            {
                //Not required for inperson purchase
                throw new NotImplementedException();
            }
        }
    }
}
