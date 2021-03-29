using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern.Creator
{
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
