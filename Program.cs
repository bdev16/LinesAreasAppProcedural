namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            int chooseUser = 0;
            List<string> Voos = new List<string> 
            {
                "Origin: Recife; Destiny: Sao Paulo; Exit: 14:00; Arrival: 17:30; Enterprise: LATAM Airlines",
                "Origin: Recife; Destiny: Guarulhos; Exit: 14:30; Arrival: 18:30; Enterprise: GOL Airlines"
            };

            List<string> Users = new List<string>
            {
                "User: brunoantonio0210@gmail.com; Password: 1234"
            };
            List<string> Enterprises = new List<string>();

             while(chooseUser != 3)
                {
                    Console.WriteLine("========== L.A ==========");
                    Console.WriteLine("Robô: Bem-Vindo ao L.A.\nRobô: Seu App de Linhas areas\n1. Login\n2. Cadastro\n3. Sair do Sistema");
                    chooseUser = Convert.ToInt32(Console.ReadLine());
                    if (chooseUser == 1)
                    {
                        Console.WriteLine("Robô: Qual o seu tipo de usuario?\n1.Usuario Comum.\n2.Empresa");
                        chooseUser = Convert.ToInt32(Console.ReadLine());
                        Login(chooseUser);
                    }else if(chooseUser == 2)
                    {
                        Console.WriteLine("Robô: Qual o seu tipo de usuario?\n1.Usuario Comum.\n2.Empresa");
                        chooseUser = Convert.ToInt32(Console.ReadLine());
                        Register(chooseUser);
                    }else if(chooseUser == 3)
                    {
                        Console.WriteLine("Saindo do sistema...");
                        Console.ReadKey();
                    }else
                    {
                        Console.WriteLine("Robô: A opção selecionada não existe\nRobô: Por gentileza informe uma opção dentre as existem");
                        Console.ReadKey();
                    }   
                }
             
            void UserMenu()
            {
                while(chooseUser != 3)
                {
                    int contemFiltro = 0;
                    int naoContemFiltro = 0;
                    int contador = 0;
                    Console.WriteLine("========== L.A ==========");
                    Console.WriteLine("Robô: Bem-Vindo ao menu de usuario...\nRobô: Você realizar as seguintes ações abaixo");
                    Console.WriteLine("1. Comprar Passagens.\n2. Ver lista de Voos.\n3. Sair da conta.");
                    chooseUser = Convert.ToInt32(Console.ReadLine());
                    // Console.ReadKey();
                    if (chooseUser == 1)
                    {
                        Console.WriteLine("============= Comprar Passagens ==============");
                        Console.WriteLine("");
                        Console.WriteLine("  Origin; Destiny; Exit; Arrival; Enterprise  ");
                        Console.WriteLine("");
                        Console.WriteLine("Informe o local de Origem: ");
                        string originUser = Console.ReadLine();
                        Console.WriteLine("Informe o local de Destino: ");
                        string destinyUser = Console.ReadLine();
                        // for(int i = 0; i < Voos.Count; i++)
                        // {
                        //     string voo = Voos[i].ToString();

                        //     string origin = ExtractValue(voo, "Origin:", ";");
                        //     string destiny = ExtractValue(voo, "Destiny:", ";");

                        //     if (originUser == origin && destinyUser == destiny)
                        //     {
                        //         Console.WriteLine($"[{i+1}] | {voo}");
                        //         contemFiltro++;
                        //     }else
                        //     {
                        //         naoContemFiltro++;
                        //     }
                        // }
                        foreach (string v in Voos)
                        {

                            string origin = ExtractValue(v, "Origin:", ";");
                            string destiny = ExtractValue(v, "Destiny:", ";");

                            if (originUser == origin && destinyUser == destiny)
                            {
                                contemFiltro++;
                                contador++;
                                Console.WriteLine($"[{contador}] | {v}");
                                
                            }else
                            {
                                naoContemFiltro++;
                            }
                            
                        }  
                        if (contemFiltro == 0)
                        {
                            Console.WriteLine("No momento não existe Voos com Os locais informados\nPor gentileza tente em outro momento...");
                        }
                    }else if(chooseUser == 2)
                    {
                        foreach(var voo in Voos)
                        {
                            Console.WriteLine(voo);
                        }
                    }
                    else if(chooseUser == 3)
                    {
                        Console.WriteLine("Saindo do sistema...");
                    }
                    Console.ReadKey();
                    }
            }

            void Login(int chooseUser)
            {
                if (chooseUser == 1)
                {
                    Console.WriteLine("Robô: Olá usuario\nRobô: Informe os seus dados a seguir");
                    Console.WriteLine("Usuario: ");
                    string user = Console.ReadLine();
                    Console.WriteLine("Senha: ");
                    string password = Console.ReadLine();
                    string userS = $"User: {user}; Password: {password}";
                    foreach (var u in Users)
                    {
                        if (u == userS)
                        {
                            UserMenu();
                        }
                    }
                    
                }else if(chooseUser == 2)
                {
                    Console.WriteLine("Robô: Olá empresa\nRobô: Informe os seus dados a seguir");
                    Console.WriteLine("Usuario: {}\nSenha: {}");
                }else
                {
                    Console.WriteLine("Robô: A opção selecionada não existe\nRobô: Por gentileza informe uma opção dentre as existem");
                }
                Console.ReadKey();
            }

            void Register(int chooseUser)
            {
                if (chooseUser == 1)
                {
                    Console.WriteLine("Robô: Olá usuario\nRobô: Informe os seus dados a seguir");
                    Console.WriteLine("Usuario: {}\nSenha: {}");
                    Console.WriteLine("Usuario:");
                    string user = Console.ReadLine();
                    Console.WriteLine("Senha:");
                    string password = Console.ReadLine();
                    Users.Add($"User: {user}; Password: {password}");

                }else if(chooseUser == 2)
                {
                    Console.WriteLine("Robô: Olá empresa\nRobô: Informe os seus dados a seguir");
                    Console.WriteLine("Usuario: {}\nSenha: {}");
                    Console.WriteLine("Usuario:");
                    string user = Console.ReadLine();
                    Console.WriteLine("Senha:");
                    string password = Console.ReadLine();
                    Enterprises.Add($"User: {user}; Password: {password}");
                }else
                {
                    Console.WriteLine("Robô: A opção selecionada não existe\nRobô: Por gentileza informe uma opção dentre as existem");
                }
                Console.ReadKey();
            }

            void UserInterface()
            {
                while(chooseUser != 0)
                {
                    Console.WriteLine("========== L.A ==========");
                    Console.WriteLine("Robô: Bem-Vindo ao L.A.\nRobô: Seu App de Linhas areas\n1. Login\n2. Cadastro\n.0. Sair do Sistema");
                    chooseUser = Convert.ToInt32(Console.ReadLine());
                    if (chooseUser == 1)
                    {
                        Console.WriteLine("Robô: Qual o seu tipo de usuario?\n1.Usuario Comum.\n2.Empresa");
                        chooseUser = Convert.ToInt32(Console.ReadLine());
                        Login(chooseUser);
                    }else if(chooseUser == 2)
                    {
                        Console.WriteLine("Robô: Qual o seu tipo de usuario?\n1.Usuario Comum.\n2.Empresa");
                        chooseUser = Convert.ToInt32(Console.ReadLine());
                        Register(chooseUser);
                    }else if(chooseUser == 3)
                    {
                        Console.WriteLine("Saindo do sistema...");
                        Console.ReadKey();
                    }else
                    {
                        Console.WriteLine("Robô: A opção selecionada não existe\nRobô: Por gentileza informe uma opção dentre as existem");
                        Console.ReadKey();
                    }   
                }
            }

            void RegisterFlight()
            {
                Console.WriteLine("========== Cadastro de Voo ==========");
                Console.WriteLine("      Informe os dados a seguir      ");
                Console.WriteLine("Informe o local de Origem: ");
                string origin = Console.ReadLine();
                Console.WriteLine("Informe o local de Destino: ");
                string destiny = Console.ReadLine();
                Console.WriteLine("Informe o horario de saida: ");
                string exit = Console.ReadLine();
                Console.WriteLine("Informe o horario de chegada: ");
                string arrival = Console.ReadLine();
                Console.WriteLine("Informe a empresa resposavel: ");
                string enterprise = Console.ReadLine();
                Voos.Add($"Origin: {origin}; Destiny: {destiny}; Exit: {exit}; Arrival: {arrival}; Enterprise: {enterprise}");
                Console.WriteLine("Voo cadastrado com sucesso...");
                Console.ReadKey();
            }

            string ExtractValue(string input, string key, string delimiter)
            {
                int startIndex = input.IndexOf(key) + key.Length;
                int endIndex = input.IndexOf(delimiter, startIndex);
                if (endIndex == -1) endIndex = input.Length;
                return input.Substring(startIndex, endIndex - startIndex).Trim();
            }

        }
    }
}