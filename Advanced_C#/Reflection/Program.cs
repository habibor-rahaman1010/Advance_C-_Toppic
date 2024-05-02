using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        public string? DatabaseName { get; set; }
        static void Main(string[] args)
        {
            string? name = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();

            for (int i = 0; i < types.Length; i++)
            {
                if (types[i].BaseType == typeof(Product) && types[i].Name == name)
                {
                    ConstructorInfo? constructorInfo = types[i].GetConstructor(new Type[] { typeof(string), typeof(int) });
                    object? myObject = constructorInfo?.Invoke(new object[] { name, price });

                    MethodInfo? methodInfo = types[i].GetMethod(nameof(Product.CalculateDiscount), BindingFlags.Instance | BindingFlags.Public);
                    object? percentage =  methodInfo?.Invoke(myObject, new object[] { discount });
                    //Console.WriteLine(percentage);
                }

                //information about the class that i pass in my input terminal...

                //print all constructor of the inputed class
                ConstructorInfo[] constructors =  types[i].GetConstructors();
                foreach (ConstructorInfo constructor in constructors)
                {
                    //Console.WriteLine(constructor);
                }

                //print all property of the inputed class...
                PropertyInfo[] propertyInfo = types[i].GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo property in propertyInfo)
                {
                    //Console.WriteLine(property.Name);
                }
            }

            Type? info = assembly.GetType("Reflection"+"."+nameof(Camera));
            PropertyInfo[]? propertyInfo2 = info?.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if (propertyInfo2 != null)
            {
                foreach (PropertyInfo property in propertyInfo2)
                {
                    Console.WriteLine(property.Name);
                }
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
