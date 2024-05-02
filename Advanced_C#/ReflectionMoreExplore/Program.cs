using System.Reflection;

namespace ReflectionMoreExplore
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //get information string class
            Type stringType = typeof(string);
            Assembly? myAssembly = Assembly.GetAssembly(stringType);
            Type[]? findTypes = myAssembly?.GetTypes();

            if (findTypes != null)
            {
                foreach (var item in findTypes)
                {
                    if (item.Name == nameof(String))
                    {
                        Console.WriteLine("------ All methodsOf String Class -------");
                        item.GetMethods().ToList().ForEach(m => 
                        { 
                            Console.WriteLine(m.Name); 
                        });
                        Console.WriteLine("------ ALl Properties of String class -------");
                        item.GetProperties().ToList().ForEach(p => 
                        { 
                            Console.WriteLine(p.Name); 
                        });
                        Console.WriteLine("----- All Fields of String Class ---------");
                        item.GetFields().ToList().ForEach(f => 
                        { 
                            Console.WriteLine(f.Name); 
                        });
                    }
                }
            }

            /*if (findTypes != null)
            {
                MethodInfo[] stringMethods =  findTypes.GetMethods();
                for (int i = 0; i < stringMethods.Length; i++)
                {
                    MethodInfo stringMethod = stringMethods[i];
                    Console.WriteLine(stringMethod.Name);
                }
            }
            else
            {
                Console.WriteLine("Null");
            }*/


            //this is my custom class information
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] type = assembly.GetTypes();

            for (int i = 0; i < type.Length; i++)
            {
                if (type[i].Name == nameof(Person))
                {
                    PropertyInfo[] properties1 = type[i].GetProperties();
                    Person person1 = new Person(12, "habibor Rahaman", "student", 24, "habib@gmail.com", "0120323", DateTime.Now);
                    for (int j = 0; j < properties1.Length; j++)
                    {
                        //Console.WriteLine($"{properties1[j].Name}: {properties1[j].GetValue(person1)}");
                    }

                    Console.WriteLine();

                    ConstructorInfo? constructorInfo = type[i].GetConstructor(new Type[] { typeof(int), typeof(string), typeof(string), typeof(int), typeof(string), typeof(string), typeof(DateTime) });
                    if (constructorInfo != null)
                    {
                        object[] parameters = { 12, "habibor Rahaman", "student", 24, "habib@gmail.com", "0120323", DateTime.Now };
                        object person = constructorInfo.Invoke(parameters);

                        PropertyInfo[] properties = type[i].GetProperties();
                        for (int j = 0; j < properties.Length; j++)
                        {
                            //Console.WriteLine($"{properties[j].Name}: {properties[j].GetValue(person)}");
                        }
                    }
                    Console.WriteLine();

                    //find how many method are exist of the class
                    MethodInfo[] methodInfos = type[i].GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    for(int j = 0; j < methodInfos.Length; j++)
                    {
                        MethodInfo method = methodInfos[j];
                        Type returnType = method.ReturnType;
                        //Console.WriteLine($"{method.Name}: {returnType.Name}");
                        ParameterInfo[] parameters = method.GetParameters();
                        for(int k = 0; k < parameters.Length; k++)
                        {
                            //Console.WriteLine($"Parameter Type: {parameters[k].ParameterType.Name}\n");
                        }
                    } 
                }
            }
        }
    }
}
