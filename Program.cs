using EjercicioTeso01.Entities;

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
                            AñadirEstudiante(infoEstudiantes, notasEstudiantes);
                            foreach(InfoEstudiante est in infoEstudiantes){
                                Console.WriteLine("Nombre: {0} Edad: {1} Email: {2} Direccion: {3}",est.NombreEstudiante, est.EdadEstudiante, est.EmailEstudiante, est.DireccionEstudiante);
                            }
                            foreach(NotasEstudiante not in notasEstudiantes){
                                Console.WriteLine("ID: {0} Nombre {1}", not.IdEstudiante, not.NombreEstudiante);
                            }
                            Console.Write("Deseea ingresar otro Estudiante? SI(Y) NO(Enter)");
                        }while(Console.ReadLine().ToLower() == "y");
                        break;
        
                    case 2:
                        Console.WriteLine("Has elegido la opción 2");
                        if (notasEstudiantes.Count() == 0){
                            Console.Clear();
                            Console.WriteLine("No existen datos en la base, por favor ingrese algun estudiante primero");
                            Console.ReadLine();
                        }else{
                            Console.Clear();
                            Console.WriteLine("Si existen estudiantes");
                            Console.WriteLine("----------- INGRESO DE NOTAS ---------------");
                            Console.Write("Ingrese nombre o código del estudiante:");
                            string codigo = Console.ReadLine();
                            foreach(NotasEstudiante elemento in notasEstudiantes){
                                if(elemento.IdEstudiante == codigo || elemento.NombreEstudiante == codigo){
                                    bool banderita = true;
                                    Console.Clear();
                                    do{
                                        Console.Clear();
                                        Console.WriteLine("----------- INGRESO DE NOTAS---------------");
                                        Console.WriteLine("Estudiante: {0}",elemento.NombreEstudiante);
                                        Console.WriteLine("ID: {0}",elemento.IdEstudiante);
                                        Console.WriteLine("-------------------------------------------");
                                        Console.WriteLine("1. Ingresar Quices");
                                        Console.WriteLine("2. Ingresar Trabajos");
                                        Console.WriteLine("3. Ingresar Parciales");
                                        Console.WriteLine("4. Salir del Programa");
                                        int notasOpcion = Convert.ToInt32(Console.ReadLine());
                                        switch(notasOpcion){
                                            case 1:
                                                AñadirQuiz(elemento);
                                                break;
                                            case 2:
                                                // AñadirTrabajo(elemento);
                                                break;
                                            case 3:
                                                // AñadirParcial(elemento);
                                                break;
                                            case 4:
                                                banderita = false;
                                                break;

                                        }
                                    }while(banderita);
                                    break;
                                }else{
                                    Console.WriteLine("No hay nadie asi");
                                }
                            }



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

    public static void AñadirEstudiante(List<InfoEstudiante> listaEstudiantes, List<NotasEstudiante> listaNotas){
        InfoEstudiante estudiante= new InfoEstudiante();
        NotasEstudiante nota = new NotasEstudiante();
        string tempId = "", tempNombre = "", tempEmail ="", tempDirr = "";
        do{
            Console.Write("Ingrese ID del Estudiante (15 Caracteres max): ");
            tempId = Console.ReadLine();
        }while(tempId.Length > 15);
        estudiante.IdEstudiante = tempId;
        nota.IdEstudiante = tempId;


        do{
            Console.Write("Ingrese nombre del Estudiante: ");
            tempNombre = Console.ReadLine();
        }while(tempNombre.Length > 40);
        estudiante.NombreEstudiante = tempNombre;
        nota.NombreEstudiante = tempNombre;

        do{
            Console.Write("Ingrese email del Estudiante: ");
            tempEmail = Console.ReadLine();
        }while(tempEmail.Length > 40);
        estudiante.EmailEstudiante = tempEmail;

        Console.Write("Ingrese edad del Estudiante: ");
        estudiante.EdadEstudiante = int.Parse(Console.ReadLine());

        do{
            Console.Write("Ingrese dirección del Estudiante: ");
            tempDirr = Console.ReadLine();
        }while(tempDirr.Length > 35);
        estudiante.DireccionEstudiante = tempDirr;

        listaEstudiantes.Add(estudiante);
        listaNotas.Add(nota);
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

}