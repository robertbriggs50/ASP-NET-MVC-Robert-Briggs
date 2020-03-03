using System;
using System.Collections.Generic;
using System.Text;

namespace CertificationTrainingOOP
{
    public class Person
    {
        public string name { get; set; }

        public void updateName(string newName)
        {
            name = newName;
        }
    }

    public class Customer : Person
    {
        public int customerId { get; set; }
        
    }

    public class Supplier : Person
    {
        public int supplierId { get; set; }
       
}

}
