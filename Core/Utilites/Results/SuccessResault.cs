using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.Results
{
    public class SuccessResault:Result
    {
        public SuccessResault(string message):base(true,message) 
        {  

        }

        public SuccessResault() : base(true)  
        {
            
        }
    }
}
