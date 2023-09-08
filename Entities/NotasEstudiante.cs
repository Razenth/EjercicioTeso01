namespace EjercicioTeso01.Entities
{
    public class NotasEstudiante
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
        
        
       private List<float> notasQuices = new List<float>(4);
       public List<float> NotasQuices
       {
        get { return notasQuices; }
        set { notasQuices = value; }
       }
       
       private List<float> notasTrabajos = new List<float>(2);
       public List<float> NotasTrabajos
       {
        get { return notasTrabajos; }
        set { notasTrabajos = value; }
       }
       

       private List<float> notasParciales = new List<float>(3);
       public List<float> NotasParciales
       {
        get { return notasParciales; }
        set { notasParciales = value; }
       }
       
        public NotasEstudiante()
        {}

        public NotasEstudiante(List<float> notasQuices, List<float> notasTrabajos, List<float> notasParciales){
            this.notasQuices = notasQuices;
            this.notasParciales=notasParciales;
            this.notasTrabajos = notasTrabajos;
        }


    }
}