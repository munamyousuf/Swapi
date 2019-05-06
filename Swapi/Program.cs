using Swapi.Data.Contracts;
using Swapi.Data.Repositories;
using Swapi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapi
{
    class Program
    {
        private IPeople _people;
        public Program()
        {
            _people = new PeopleRepository();
        }
        static void Main(string[] args)
        {
            var a = "";
            Console.WriteLine("Hello world");
            _people
            Console.ReadLine();
        }
    }
}
