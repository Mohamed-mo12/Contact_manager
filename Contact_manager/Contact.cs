﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_manager
{
    class Contact
    {
        private List<string> users = new List<string>();

        public void AddUser(string add) {

            users.Add(add);
            Console.WriteLine($" yor are succcssefuly add the user {add}"); 
        }

        public List<string> delete_user(string delete)
        {
            if (users.Contains(delete))
            {
                users.Remove(delete);
                Console.WriteLine(" you remove this user ");
            }
            else
            {
                Console.WriteLine($" {delete} not found ");
            }

            return users; 
        }


        public void Show_users() {

            Console.WriteLine(" this is All User in the list ");

            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
        
        }


        public void number_users() {

            if (users.Count <= 0)
            {
                Console.WriteLine(" there is no user  ");
            }
            else
            {
                Console.WriteLine(users.Count());
            }

        }

        public string search_user(string name) {

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i] == name)
                {
                    return $"{name} is exist ";
                }
            }

            return "not exist is the list"; 
        
        }



        











    }
}
