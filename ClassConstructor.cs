using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsCreateObject
{
    class ClassConstructor
    {
        /// <summary>
        /// fields for employeeDetails List
        /// </summary>
        public string empNamePerson;
        public int empID;

    
        
            /// <summary>
            /// Basic constructor  
            /// </summary>
        public ClassConstructor(){
            Console.WriteLine("Constructor class is called");
        }
        /// <summary>
        /// constructor getMethod details
        /// </summary>
        public void EmployeeDetailsList()
        {
            Console.WriteLine("The Employee Details are here \n EMployee name:" + empNamePerson +"\tEmployeeID  "+ empID);
        }
        /// <summary>
        ///fields for patientDetils List Details 
        /// </summary>
        public string patietName;
        public int patientId;

        ///<summary>
        ///Patient details set with constructor
        /// </summary>

        public void SetPatientDetails(string pName,int id)
        {
            this.patientId = id;
            this.patietName = pName;
        }
        ///<summary>
        ///Patient getMethod
        ///</summary>

        public void GetPatientDetils()
        {
            Console.WriteLine($"\n\nThe patient Details are:\n patientName {patietName} and Id is {patientId} ");       
        }


       

    }
}
