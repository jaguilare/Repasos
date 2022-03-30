using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.MyStates
{
    public class NewState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            Console.WriteLine($"Se agrega dinero a su saldo {amount}");
            customerContext.Residue = amount;
            customerContext.SetState(new NotDebtorState());
        }
    }
}
