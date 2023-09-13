using EjercicioTeso01.Entities;
using EjercicioTeso01;
internal class Program
{
    private static void Main(string[] args)
    {
        List<InfoEstudiante> infoEstudiantes = new List<InfoEstudiante>();
        List<NotasEstudiante> notasEstudiantes = new List<NotasEstudiante>();
        bool salir = false;
        while (!salir) {
            Console.Clear();
                Console.WriteLine("----------- MENU PRINCIPAL---------------");
                Console.WriteLine("1. Ingresar Estudiante");
                Console.WriteLine("2. Ingresar Nota a Estudiante");
                Console.WriteLine("3. Mostrar Notas Generales de Grupo");
                Console.WriteLine("4. Mostrar Notas Finales");
                Console.WriteLine("5. Salir del Programa");
                Console.WriteLine("Elige una de las opciones");
                int opcion = Convert.ToInt32(Console.ReadLine());
        
                switch (opcion)
                {
                    case 1:
                        do{
                            Console.WriteLine("Has elegido la opción 1");
                            InfoEstudiante.AñadirEstudiante(infoEstudiantes);
                            foreach(InfoEstudiante est in infoEstudiantes){
                                Console.WriteLine("Nombre: {0} Edad: {1} Email: {2} Direccion: {3}",est.NombreEstudiante, est.EdadEstudiante, est.EmailEstudiante, est.DireccionEstudiante);
                            }
                            Console.Write("Deseea ingresar otro Estudiante? SI(Y) NO(Enter)");
                        }while(Console.ReadLine().ToLower() == "y");
                        break;
        
                    case 2:
                        Console.WriteLine("Has elegido la opción 2");
                        if (infoEstudiantes.Count() == 0){
                            Console.Clear();
                            Console.WriteLine("No existen datos en la base, por favor ingrese algun estudiante primero");
                            Console.ReadLine();
                        }else{
                            Console.Clear();
                            Console.WriteLine("Si existen estudiantes");
                            Console.WriteLine("----------- INGRESO DE NOTAS ---------------");
                            Console.Write("Ingrese nombre o código del estudiante:");
                            string codigo = Console.ReadLine();
                            MisFunciones.MenuNotas(infoEstudiantes,codigo);
                            
                            
                        }
                        break;
                        
        
                    case 3:
                        Console.WriteLine("Has elegido la opción 3");
                        break;
                    case 4:
                        Console.WriteLine("Has elegido la opción 4");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 4");
                        break;
                }
        
        }
    }

    

    public static void AñadirQuiz(NotasEstudiante objeto){
        bool banderitaQuices = true;
        if (objeto.NotasQuices.Count() < 3){
            do{
                Console.Write("Ingrese nota de quiz {0}:", 1+(objeto.NotasQuices.Count()));
                float nota = float.Parse(Console.ReadLine());
                objeto.NotasQuices.Add(nota);
                if (objeto.NotasQuices.Count() < 3){
                    Console.Clear();
                    Console.Write("Desea ingresar otro quiz? SI(Y) NO(Enter): ");
                    if (Console.ReadLine().ToLower() == "y"){
                        continue;
                    }
                    else{
                        Console.Clear();
                        Console.WriteLine("Ya ingresó todos los quizes correspondientes");
                        Console.Write("Digite enter para continuar");
                        Console.ReadLine();
                        banderitaQuices = false;
                    }
                }else{
                        Console.Clear();
                        Console.WriteLine("Ya ingresó todos los quizes correspondientes");
                        Console.Write("Digite enter para continuar");
                        Console.ReadLine();
                        banderitaQuices = false;
                    }
            }while(banderitaQuices);
            Console.Clear();
        }else{
            Console.Clear();
            Console.WriteLine("Ya ingresó todos los quizes correspondientes");
            Console.Write("Digite enter para continuar");
            Console.ReadLine();
        }

    }


    public static void AñadirParcial(NotasEstudiante objeto){
        bool banderitaParcial = true;
        if (objeto.NotasQuices.Count() < 3){
            do{
                Console.Write("Ingrese nota de parcial {0}:", 1+(objeto.NotasQuices.Count()));
                float nota = float.Parse(Console.ReadLine());
                objeto.NotasQuices.Add(nota);
                if (objeto.NotasQuices.Count() < 3){
                    Console.Clear();
                    Console.Write("Desea ingresar otro parcial? SI(Y) NO(Enter): ");
                    if (Console.ReadLine().ToLower() == "y"){
                        continue;
                    }
                    else{
                        Console.Clear();
                        Console.WriteLine("Ya ingresó todos los parciales correspondientes");
                        Console.Write("Digite enter para continuar");
                        Console.ReadLine();
                        banderitaParcial = false;
                    }
                }else{
                        Console.Clear();
                        Console.WriteLine("Ya ingresó todos los parciales correspondientes");
                        Console.Write("Digite enter para continuar");
                        Console.ReadLine();
                        banderitaParcial = false;
                    }
            }while(banderitaParcial);
            Console.Clear();
        }else{
            Console.Clear();
            Console.WriteLine("Ya ingresó todos los parciales correspondientes");
            Console.Write("Digite enter para continuar");
            Console.ReadLine();
            banderitaParcial = false;
        }

    }

}