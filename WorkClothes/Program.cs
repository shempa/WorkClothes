using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace WorkClothes
{    
    class Program
    {       
        static void Main(string[] args)
        {
            IRepository repository = new Repository();
            var WorkClothes = repository.GetClothes();
            foreach (var i in WorkClothes)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Введите поле, по которому следует выполнить сортировку");
            string SortField = Console.ReadLine();
            var SortFieldClothes = repository.SortFieldClothes(SortField);
            foreach (var i in SortFieldClothes)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Введите наименование для поиска");
            string ThisClothe = Console.ReadLine();
            var ThisClothes = repository.ThisClothes(ThisClothe);
            if (ThisClothes.Count == 0)
            { Console.WriteLine("Введенное наименование отсутствует"); }
            else
            {
                foreach (var i in ThisClothes)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();            
        }        
    }   
}
