using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("System.String");

            if (type != null)
            {
                Console.WriteLine("The class name is {0}.", type.Name);
                Console.WriteLine("The full class name is {0}.", type.FullName);
                Console.WriteLine("Class namescape is {0}.", type.Namespace);
                Console.WriteLine("Class assembly is {0}.", type.Assembly);

                Console.WriteLine("Base class is: {0}", type.BaseType);
                Console.WriteLine("Abstract: {0}", type.IsAbstract);
                Console.WriteLine("Sealed: {0}", type.IsSealed);
                Console.WriteLine("Generic: {0}", type.IsGenericTypeDefinition);
                Console.WriteLine("Class: {0}", type.IsClass);
            }

            Assembly assem = null;

            try
            {
                assem = Assembly.Load("Reflection");
            }
            catch (System.IO.FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }

            if (assem == null)
                return;


            Type countryType = assem.GetType("Reflection.Country");
            object obj = Activator.CreateInstance(countryType, new object[] { "China", 1403500365 });

            Console.WriteLine("New type created dynamically: {0}", obj);

            MethodInfo mi = countryType.GetMethod("GetCountryInfo");

            Console.WriteLine(mi);
            Console.ReadKey();

        }
    }
}
