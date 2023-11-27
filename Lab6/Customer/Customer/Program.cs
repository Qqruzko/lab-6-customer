using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Customer
    {
        public string Name { get; set; }
        public double Balance { get; private set; }
        public enum callclass 
        {
            povremenn,
            after_10_min,
            plati_menshe
        }
        public callclass CallClass{ get; set; }
    public Customer(string name, double balance = 100, Customer.callclass callclass = callclass.povremenn)
        {
            Name = name;
            Balance = balance;
            CallClass = callclass;
        }

        public override string ToString()
        {
            return string.Format("Клиент: {0} имеет баланс: {1} Тариф - {2} ", Name, Balance, CallClass);
        }

        public void RecordPayment(double amountPaid)
        {
            if (amountPaid > 0)
                Balance += amountPaid;
        }

        public void RecordCall(char callType, int minutes, Customer.callclass callclass)
        {
            
            switch (callclass)
            {
                case callclass.povremenn:
                    if (callType == 'Г')
                        Balance -= minutes * 5;
                    else
                    if (callType == 'М')
                        Balance -= minutes * 1;
                    break;

                case callclass.after_10_min:
                    int minutesleft = minutes-10;

                    if (minutes < 10)
                    {
                        if (callType == 'Г')
                            Balance -= minutes * 5;
                        else

                    if (callType == 'М')
                            Balance -= minutes * 1;
                        break;
                    }
                    else 
                         if (callType == 'Г')
                        Balance -= (minutes-10) * 5+(minutesleft/2) * 5;
                        else

                        if (callType == 'М')
                        Balance -= (minutes - 10) * 1 + (minutesleft / 2) * 1;
                        break;

                case callclass.plati_menshe:
                    minutesleft = minutes -5;

                    if (minutes < 5)
                    {
                        if (callType == 'Г')
                            Balance -= minutes * 5/2;
                        else

                    if (callType == 'М')
                            Balance -= minutes * 1/2;
                        break;
                    }
                    else
                         if (callType == 'Г')
                        Balance -= (minutes - minutesleft) * 5/2 + (minutesleft*2) * 5;
                    else

                        if (callType == 'М')
                        Balance -= (minutes - minutesleft) * 1 / 2 + (minutesleft * 2) * 1;
                    break;
                    
            }
           
        }
    }

    class Customer1
    {
        static void Main(string[] args)
        {
            Customer Ivan = new Customer("Иван Петров", 500,Customer.callclass.plati_menshe );
            Customer Elena = new Customer("Елена Иванова", 200, Customer.callclass.after_10_min);
            Ivan.RecordCall('Г', 12, Customer.callclass.plati_menshe) ;
            Elena.RecordCall('Г', 25, Customer.callclass.after_10_min);

            Console.WriteLine(Ivan);
            Console.WriteLine(Elena);
            Console.ReadLine();
        }
    }
}
