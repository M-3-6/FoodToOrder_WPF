using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToOrder_WPF
{

    public  class IDGenerator
    {
        Random rnd = new Random();
        //public static int Id = 50;
        public int GenerateId()
        {
            //Id++;
            //return Id;
            return rnd.Next();
        }
    }
}
