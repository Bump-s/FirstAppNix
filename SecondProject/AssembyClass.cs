using System;
using System.Reflection;

namespace AssemblyProject
{
    class AssembyClass
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\Viacheslav\source\repos\FirstAppNix\MyLibrary\bin\Debug\netcoreapp3.1\MyLibrary.dll");
            Console.WriteLine(assembly.FullName);

            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
            {
                Console.WriteLine(t.Name);
            }

            try
            {
                Type type = assembly.GetType("MyLibrary.Car", true, true);
                object obj = Activator.CreateInstance(type);
                MethodInfo method = type.GetMethod("СalculateOverclocking");
                object result = method.Invoke(obj, new object[] { 850, 520 });
                Console.WriteLine((result));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

    }
}
