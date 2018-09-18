using System;
using System.Reflection;

namespace ReflectionExample
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);

            var typesGetTypes = assembly.GetTypes();

            foreach (var itemTypesGetTypes in typesGetTypes)
            {
                Console.WriteLine("Type: " + itemTypesGetTypes.Name);

                var props = itemTypesGetTypes.GetProperties();
                foreach (var itemProps in props)
                {
                    Console.WriteLine("\tProperty: " + itemProps.Name + " PropertyType: " + itemProps.PropertyType);
                }


                var fileds = itemTypesGetTypes.GetFields();
                foreach (var itemFileds in fileds)
                {
                    Console.WriteLine("\tField: " + itemFileds.Name);
                }


                var methods = itemTypesGetTypes.GetMethods();
                foreach (var itemMethods in methods)
                {
                    Console.WriteLine("\tMethod: " + itemTypesGetTypes.Name);
                }

            }


            //EXAMPLE POPULATE
            var sample = new Sample { NameExample = "Jean", AgeExample = 20 };
            var sampleType = typeof(Sample);

            //INVOKE YOUR METHOD BY REFLACTION
            var sampleMethod = sampleType.GetMethod("MyMethodExample");
            sampleMethod.Invoke(sample, null);

            Console.ReadKey();
        }
    }

    public class Sample
    {
        public string NameExample { get; set; }
        public int AgeExample { get; set; }

        public void MyMethodExample()
        {
            Console.WriteLine($"Result of method {nameof(Sample)}");
        }
    }
}
