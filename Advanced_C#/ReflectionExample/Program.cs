using System.Reflection;

namespace ReflectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string className = "Product";
          
            string path = "D:\\Advanced_C#\\Advanced_C#\\DemoLib\\bin\\Debug\\net6.0\\DemoLib.dll";
            Assembly assembly = Assembly.LoadFile(path);
            Type[] types = assembly.GetTypes();

            foreach (var type in types)
            {
                if (type.Name == className)
                {
                    //find spacific constructor use GetConstructor()
                    ConstructorInfo? constructorInfo1 = type.GetConstructor(new Type[] {typeof(int), typeof(string), typeof(double)});
                    object? myObject = constructorInfo1?.Invoke(new object[] {123, "Samsumg S24", 120500.00});

                    MethodInfo? methodInfo = type.GetMethod("PrintObject", new Type[] { });
                    //MethodInfo? methodInfo =  type.GetMethod("PrintObject", BindingFlags.Instance | BindingFlags.Public);
                    object? data = methodInfo?.Invoke(myObject, new object[] {});

                    //find all constructor use GetConstructors()
                    ConstructorInfo[] constructorInfo =  type.GetConstructors();
                    foreach(ConstructorInfo constructor in constructorInfo)
                    {
                        //Console.WriteLine(constructor);
                    }
                } 
            }
            Console.WriteLine("---------------------------------------");

            List<int> list = new List<int>();
            Type listTypes = list.GetType();
            foreach (Type interfacee in listTypes.GetInterfaces())
            {
                Console.WriteLine(interfacee.Name);
                foreach (var getArgument in interfacee.GetGenericArguments())
                {
                    Console.WriteLine(getArgument.Name);
                }
            }
            Console.WriteLine("-------------------------------------------");
            MemberInfo[] methods = listTypes.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            foreach (MethodInfo method in methods)
            {
                Console.Write(method.Name);
                Console.Write(" (");
                ParameterInfo[] parameterInfo = method.GetParameters();

                foreach(ParameterInfo parameter in parameterInfo)
                {
                    Console.Write(parameter.GetType().Name);
                    Console.Write(" ");
                    Console.Write(parameter.Name);
                    Console.Write(", ");
                }
                Console.WriteLine(")");
            }

            Console.WriteLine("------------------------------------------");

            foreach (Type product in types)
            {
                if (product.Name == "Camera")
                {
                    Console.WriteLine(product?.BaseType?.Name);
                }
            }

            Console.WriteLine("-------------------------------------------");
            var properties = listTypes.GetMembers(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            foreach (MemberInfo property in properties)
            {
                //Console.WriteLine($"{property.Name}");
            }

            //create a object and invok there method
            int id = 101;
            string name = "Canon Camera";
            double price = 57890.58;

            string className2 = "Camera";
            int discountParcentage = 5;

            foreach (Type type in types)
            {
                if (type?.BaseType?.Name == className && type.Name == className2)
                {
                    ConstructorInfo? constructorInfo =  type.GetConstructor(new Type[] {typeof(int), typeof(string), typeof(double)});
                    object? obj =  constructorInfo?.Invoke(new object[] {id, name, price});

                    MethodInfo? methodInfo = type.GetMethod("GetDiscount", new Type[] { typeof(int) });
                    object? result = methodInfo?.Invoke(obj, new object[] {discountParcentage});
                    Console.WriteLine(result);
                }
            }
        }
    }
}
