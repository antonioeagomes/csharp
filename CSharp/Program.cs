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
                new MenuItem("Method", typeof(MethodExec)) /*,
                new MenuItem("Decimal", typeof(Decimal)),
                new MenuItem("Booleanos", typeof(Booleanos)),
                new MenuItem("Estruturas", typeof(Estruturas)),
                new MenuItem("Enumeracoes", typeof(Enumeracoes)),
                new MenuItem("Tipos de Refêrencia", typeof(TiposDeReferencia)),
                new MenuItem("Classes", typeof(Classes)),
                new MenuItem("Interfaces", typeof(Interfaces)),
                new MenuItem("Delegates", typeof(Delegates)),
                new MenuItem("Objetos", typeof(Objetos)),
                new MenuItem("Dinâmicos", typeof(Dinamicos)),
                new MenuItem("Strings", typeof(Strings)),
                new MenuItem("Metodos", typeof(Metodos)),
                new MenuItem("Parâmetros Nomeados", typeof(ParametrosNomeados)),
                new MenuItem("Parâmetros Opcionais", typeof(ParametrosOpcionais)),
                new MenuItem("Métodos de Extensão", typeof(MetodosDeExtensao)),
                new MenuItem("Propriedades Indexadas", typeof(PropriedadesIndexadas)),
                new MenuItem("Sobrecargas", typeof(Sobrecargas)),
                new MenuItem("Métodos Substituidos", typeof(MetodosSubstituidos)),
                new MenuItem("Boxing", typeof(Boxing)),
                new MenuItem("Unboxing", typeof(Unboxing)),
                new MenuItem("Conversoes Implícitas", typeof(ConversoesImplicitas)),
                new MenuItem("Conversoes Explícitas", typeof(ConversoesExplicitas)),
                new MenuItem("Operadores IS e AS", typeof(OperadoresISeAS)),
                new MenuItem("Operadores de Conversão", typeof(OperadoresDeConversao)),
                new MenuItem("Métodos Auxiliares de Conversão", typeof(MetodosAuxiliares)),
                new MenuItem("Usando Dynamic", typeof(UsandoDynamic)),
                new MenuItem("Conversões de Dynamic", typeof(ConversoesDeDynamic)),
                new MenuItem("Resolucão de Sobrecarga", typeof(ResolucaoSobrecarga)),
                new MenuItem("Usando ExpandObject", typeof(UsandoExpandObject)),
                new MenuItem("Interoperabilidade COM", typeof(InteropCOM)) */
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

