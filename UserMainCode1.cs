using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsCreateObject
{
   

    public class UserMainCode1
    {
        public int MoneyConversion(string input1)
        {
            try
            {
                string[] parts = input1.Split(' ');
                if (parts.Length != 2)
                    throw new ArgumentException("Invalid input format");

                int value = int.Parse(parts[0]);

                switch (parts[1])
                {
                    case "Y":
                        return (int)(value * 1.0);
                    case "P":
                        return (int)(value * 1.0);
                    case "D":
                        return (int)(value * 70.0);
                    case "R":
                        return (int)(value * 100.0);
                    default:
                        throw new ArgumentException("Invalid currency type");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error in MoneyConversion method: " + ex.Message);
            }
        }
    }




}
