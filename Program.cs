using EjercicioTeso01.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<InfoEstudiante> infoEstudiantes = new List<InfoEstudiante>();
        List<NotasEstudiante> notasEstudiantes = new List<NotasEstudiante>();
        bool salir = false;
        while (!salir) {
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
                            AñadirEstudiante(infoEstudiantes);
                            foreach(InfoEstudiante est in infoEstudiantes){
                                Console.WriteLine("Nombre: {0} Edad: {1} Email: {2} Direccion: {3}",est.NombreEstudiante, est.EdadEstudiante, est.EmailEstudiante, est.DireccionEstudiante);
                            }
                            Console.Write("Deseea ingresar otro Estudiante? SI(Y) NO(Enter)");
                        }while(Console.ReadLine().ToLower() == "y");
                        break;
        
                    case 2:
                        Console.WriteLine("Has elegido la opción 2");
                        if (notasEstudiantes.Count() == -1){
                            Console.WriteLine("No existe");
                        }else{
                            Console.WriteLine("Si existe");
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

    public static void AñadirEstudiante(List<InfoEstudiante> listaEstudiantes){
        InfoEstudiante estudiante= new InfoEstudiante();
        string tempId = "", tempNombre = "", tempEmail ="", tempDirr = "";
        do{
            Console.Write("Ingrese ID del Estudiante (15 Caracteres max): ");
            tempId = Console.ReadLine();
        }while(tempId.Length > 15);
        estudiante.IdEstudiante = tempId;

        do{
            Console.Write("Ingrese nombre del Estudiante: ");
            tempNombre = Console.ReadLine();
        }while(tempNombre.Length > 40);
        estudiante.NombreEstudiante = tempNombre;

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
    }
}