using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_manager
{
    class Phone : attribute
    {

        public Phone( int phone , string type , string description)
        {
            this.phone = phone;
            this.Type = type;
            this.description = description; 
        }
        public int phone { get; set; }

        public override string description { get => base.description; set => base.description = value; }

        public override string Type { get => base.Type; set => base.Type = value; }


        public string getphone() {

            return $" {phone} {description} {Type }"; 
        
        }
    }
}
