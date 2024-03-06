using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_manager
{
    class Users
    {
        public enum Gender
        {
            Male,
            Female
        }


        private List<int> phone = new List<int>();
        private List<string> address = new List<string>();
        private List<string> email = new List<string>();




        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public Gender gender { get; set; }

        public string City { get; set; }
        public DateTime Date { get; set; }

        public List<string> Address { get { return address;} set { address = value;} }

        public List<int> Phone { get { return phone ; } set { phone = value;}}

        public List<string> Email { get{ return email; } set {email = value ;}}


        public bool search(string search, int number)
        {
            if (Address.Contains(search) || Phone.Contains(number) || Email.Contains(search))
            {

                return true;

            }
            else
            {
                return false;
            }

        }


        public void Add_phone(int number)
        {

                Phone.Add(number); 
        }


        public void Add_Email(string email)
        {

            if (IsvalidEmail(email))
            {
                Email.Add(email);
            }
            else
            {
                Console.WriteLine(" invalid Email , Email not added ");
            }


        }
        private bool IsvalidEmail(string email)
        {

            try
            {
                var check = new System.Net.Mail.MailAddress(email);
                return check.Address == email;

            }
            catch
            {

                return false;

            }

        }

        public void Add_address(string address)
        {

            Address.Add(address);
            Console.WriteLine(" You add new Address ");
        }


        public int editphone(int number, int newnumber)
        {

            for (int i = 0; i < Phone.Count; i++)
            {
                if (number == Phone[i])
                {
                    Phone[i] = newnumber;
                    return newnumber;
                }
                          
            }

            
            return 0;
        }


        public void edit_number(int number,int newnumber)
        {
            if (editphone(number,newnumber) != 0)
            {
                Console.WriteLine("Phone number updated");
            }
            else
            {
                Console.WriteLine("Phone number not found in the list");
            }

        }


        public string edit_Email(string email, string newemail)
        {

            for (int i = 0; i < Email.Count; i++)
            {
                if (email == Email[i])
                {
                    Email[i] = newemail;
                }
            }

            return " not Exist this email";


        }


        public void display_phone() {

            foreach (int phoneNumber in Phone)
            {
                Console.WriteLine("Phone Number: " + phoneNumber);
            }
        }
    }
}