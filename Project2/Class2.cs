using CodeFirstProject.Context;
using CodeFirstProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Class2 : Interface2
    {
        MyProjectDbContext context = new();
        public Class2(MyProjectDbContext context)
        {
            this.context = context;
        }
        public void CreateUser()
        {
            User user = new()
            {
                Name = "Rüchan",
                LastName = "Dora",
            };

            context.Users.Add(user);
            context.SaveChanges();
        }

        public void UpdateUser()
        {
            User user = context.Users.SingleOrDefault(u => u.Id == 4);
            user.Name = "Ali";
            context.SaveChanges();

        }

        public void DeleteUser()
        {
            User user = context.Users.SingleOrDefault(u => u.Id == 4);
            context.Users.Remove(user);
            context.SaveChanges();
        }
    }
    class Start
    {
        public static void Main(string[] args)
        {
            MyProjectDbContext context = new();
            Interface2 class2Instance = new Class2(context);
            // class2Instance.UpdateUser();
            //  class2Instance.CreateUser();
            class2Instance.DeleteUser();
        }
    }
}
