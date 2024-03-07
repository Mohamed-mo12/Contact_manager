using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_manager
{
    class Address : attribute
    {

        public Address(string place , string description , string type)
        {
            Place = place;
            this.description = description;
            Type = type; 
        }

        public string Place { get;  set;}
        public override string description { get => base.description; set => base.description = value; }
        public override string Type { get => base.Type; set => base.Type = value; }



        public string getaddress() {

           return $" you address is {Place} {description} {Type}"; 
            
        }




    }
}
