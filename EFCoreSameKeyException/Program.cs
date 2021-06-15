using System;
using UnitTest.EFModel.Models;
using TestModel.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSameKeyException
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new demoContext())
            {
                var remItem = context.Items.FirstOrDefault();
                context.Items.Remove(remItem);
                
                var addItem = new item
                {
                    ItemName = "testing",
                    ItemDesc = "testing",
                    TS = DateTime.Now
                };
                context.Items.Add(addItem);

                context.SaveChanges();
            }
        }
    }
}
