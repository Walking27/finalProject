using Core.Utilites.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] locigs) 
        {
            foreach (var locig in locigs)
            {
                if (!locig.Success)
                {
                    return locig;
                }
            }

            return null;
        }
    }
}
