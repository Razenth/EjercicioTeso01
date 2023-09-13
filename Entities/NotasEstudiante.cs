namespace EjercicioTeso01.Entities
{
    public class NotasEstudiante
    {
        
       List<float> notasQuices = new List<float>();
       public List<float> NotasQuices
       {
        get { return notasQuices; }
        set { notasQuices = value; }
       }
       
       List<float> notasTrabajos = new List<float>();
       public List<float> NotasTrabajos
       {
        get { return notasTrabajos; }
        set { notasTrabajos = value; }
       }
       

       List<float> notasParciales = new List<float>();
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