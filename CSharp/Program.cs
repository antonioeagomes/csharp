using System;
using System.Collections.Generic;
using CSharp.Exec;

namespace CSharp
{
    class Program
    {
        static IList<MenuItem> menuItems;
        static void Main(string[] args)
        {
            IExecutable selectedItem;
            menuItems = GetMenuItems();

            while (true)
            {
                PrintMenu(menuItems);
                var option = Console.ReadLine();

                int.TryParse(option, out int optionValue);

                if (optionValue == 0)
                {
                    break;
                }

                if (optionValue > menuItems.Count)
                {
                    break;
                }

                selectedItem = Executar(optionValue);
                Console.ReadKey();
            }
        }

        private static IExecutable Executar(int option)
        {
            IExecutable selectedItem;
            MenuItem menuItem = menuItems[option - 1];
            Type tipoClasse = menuItem.ClassType;
            selectedItem = (IExecutable)Activator.CreateInstance(tipoClasse);

            Console.WriteLine();
            string title = $"RUNNING: {menuItem.Title}";
            Console.WriteLine(title);
            Console.WriteLine(new string('=', title.Length));

            selectedItem.Execute();
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to menu...");
            return selectedItem;
        }

        private static void PrintMenu(IList<MenuItem> menuItems)
        {
            int i = 1;
            Console.WriteLine("Choose an option");
            Console.WriteLine("===================");
            Console.WriteLine("0 - Exit");
            foreach (var menuItem in menuItems)
            {
                Console.WriteLine((i++).ToString() + " - " + menuItem.Title);
            }
        }

        private static IList<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>
            {
                new MenuItem("Classes", typeof(ClassExec)),
                new MenuItem("Constructor", typeof(ConstructorExec)),
                new MenuItem("Method", typeof(MethodExec)),
                new MenuItem("Indexers", typeof(DictionariesExec)),
                new MenuItem("Stopwatch", typeof(StopwatchExec)),
                new MenuItem("Inheritance", typeof(InheritanceExec)),
                new MenuItem("Composition", typeof(CompositionExec)),
                new MenuItem("Polymorphism", typeof(PolymorphExec)),
                new MenuItem("Interface", typeof(InterfaceExec)),
                new MenuItem("WorkflowEngine", typeof(WorkflowEngineExec)),
                new MenuItem("Generics", typeof(GenericsExec)),
                new MenuItem("Delegates", typeof(DelegatesExec)),
                new MenuItem("Lambdas", typeof(LambdasExec)),
                new MenuItem("Events", typeof(EventsExe)),
                new MenuItem("Extension", typeof(ExtensionExec))
            };
        }
    }

    class MenuItem
    {        
        public string Title { get; set; }
        public Type ClassType { get; set; }
        public MenuItem(string title, Type classType)
        {
            Title = title;
            ClassType = classType;
        }
    }
}

