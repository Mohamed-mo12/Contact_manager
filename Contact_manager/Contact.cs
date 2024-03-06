using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_manager
{
    class Contact
    {
        private List<string> users = new List<string>();

        public List<string> User { get { return users; } private set { users = value; } }


        public void add_user(string add) {

            User.Add(add);
            Console.WriteLine($" yor are succcssefuly add the user {add}"); 
        }

        public List<string> delete_user(string delete)
        {
            if (User.Contains(delete))
            {
                User.Remove(delete);
                Console.WriteLine(" you remove this user ");
            }
            else
            {
                Console.WriteLine($" {delete} not found ");
            }

            return User; 
        }


        public void Show_users() {

            Console.WriteLine(" this is All User in the list ");

            foreach (var item in User)
            {
                Console.WriteLine(item);
            }
        
        }


        public void number_users() {

            if (User.Count <= 0)
            {
                Console.WriteLine(" there is no user  ");
            }
            else
            {
                Console.WriteLine(User.Count());
            }

        }

        public string search_user(string name) {

            for (int i = 0; i < User.Count; i++)
            {
                if (User[i] == name)
                {
                    return $"{name} is exist ";
                }
            }

            return "not exist is the list"; 
        
        }



        











    }
}
