using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAbacus.Models
{
    public class MyAbacusDomainModel
    {
        public MyAbacusDomainModel(string number1, string number2)
        {
            Number1 = number1;
            Number2 = number2;
            Answer = DoAddition(number1, number2);
            
        }

        public string Number1 { get; }

        public string Number2 { get; }

        public string Answer { get; }

        


        private string DoAddition(string num1, string num2)
        {

          
                decimal firstNum = Convert.ToDecimal(num1);
                decimal secondNum = Convert.ToDecimal(num2);

                decimal answerInt = firstNum + secondNum;
                return answerInt.ToString();

           
           

            

        }

        private bool IsaError(string test)
        {
            return test == "";
        }
    

    }
}