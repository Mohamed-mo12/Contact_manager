using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_manager
{
    class Email : attribute
    {


        public Email(string email, string description , string type)
        {
            this.email = email;
            this.description = description;
            Type = type; 
        }

        public string email { get; set; }

        public override string description { get => base.description; set => base.description = value; }

        public override string Type { get => base.Type; set => base.Type = value; }

        public string getEmail() {

            return $" you email : {email} {Type} {description} ";
        
        }



    }
}
