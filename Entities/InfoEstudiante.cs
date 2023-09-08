namespace EjercicioTeso01.Entities
{
    public class InfoEstudiante
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

        public InfoEstudiante()
        {
        }

        public InfoEstudiante(string idEstudiante, string nombreEstudiante, string emailEstudiante, int edadEstudiante, string direccionEstudiante){
            this.idEstudiante = idEstudiante;
            this.nombreEstudiante = nombreEstudiante;
            this.emailEstudiante = emailEstudiante;
            this.edadEstudiante= edadEstudiante;
            this.direccionEstudiante= direccionEstudiante;
        }
    }
}