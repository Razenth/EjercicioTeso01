namespace EjercicioTeso01.Entities
{
public class InfoEstudiante : NotasEstudiante
    {
        private string idEstudiante;
        public string IdEstudiante
        {
            get { return idEstudiante; }
            set { idEstudiante = value; }
        }
        
        private string nombreEstudiante;
        public string NombreEstudiante
        {
            get { return nombreEstudiante; }
            set { nombreEstudiante = value; }
        }

        private string emailEstudiante;
        public string EmailEstudiante
        {
            get { return emailEstudiante; }
            set { emailEstudiante = value; }
        }

        private int edadEstudiante;
        public int EdadEstudiante
        {
            get { return edadEstudiante; }
            set { edadEstudiante = value; }
        }
        

        private string direccionEstudiante;
        public string DireccionEstudiante
        {
            get { return direccionEstudiante; }
            set { direccionEstudiante = value; }
        }

        public InfoEstudiante() : base()
        {
        }

        public InfoEstudiante(string idEstudiante, string nombreEstudiante, string emailEstudiante, int edadEstudiante, string direccionEstudiante,List<float> notasQuices, List<float> notasTrabajos, List<float> notasParciales) : base(notasQuices,notasParciales,notasTrabajos)
        {
            this.idEstudiante = idEstudiante;
            this.nombreEstudiante = nombreEstudiante;
            this.emailEstudiante = emailEstudiante;
            this.edadEstudiante= edadEstudiante;
            this.direccionEstudiante= direccionEstudiante;
            this.NotasQuices = notasQuices;
            this.NotasParciales =  notasParciales;
            this.NotasTrabajos = notasTrabajos;
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

        public void AñadirNota(List<Estudiante> estudiantes, int opcion)
        {
            Console.WriteLine("Ingrese el codigo del estudiante: ");
            string studenCode = Console.ReadLine();
            // Estudiante alumno =  new Estudiante();
            Estudiante alumno = estudiantes.FirstOrDefault(x => x.Code.Equals(studenCode));
            Console.WriteLine("Por favor ingrese la nota del : ");
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Quiz Nro : {0}", (alumno.Quices.Count + 1));
                    alumno.Quices.Add(float.Parse(Console.ReadLine()));
                    break;
                case 2:
                    alumno.Trabajos.Add(float.Parse(Console.ReadLine()));
                    break;
                case 3:
                    alumno.Parciales.Add(float.Parse(Console.ReadLine()));
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    Console.ReadKey();
                    break;
            }
            int idx = estudiantes.FindIndex(p => p.Code.Equals(studenCode));
            estudiantes[idx] = alumno;
        }
    }
}