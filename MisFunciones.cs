using System.Linq.Expressions;
using EjercicioTeso01.Entities;
using Newtonsoft.Json;

namespace EjercicioTeso01;

public class MisFunciones
{
    public static void MenuNotas(List<InfoEstudiante> estudiantes,string codigo)
    {
        InfoEstudiante elemento = estudiantes.FirstOrDefault(x => x.IdEstudiante.Equals(codigo) || x.NombreEstudiante.Equals(codigo));{
            if(elemento != null){
                int idx = estudiantes.FindIndex(p => p.IdEstudiante.Equals(codigo));
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
                    Console.WriteLine(elemento);
                    int notasOpcion = Convert.ToInt32(Console.ReadLine());
                    if(notasOpcion != 4){
                        estudiantes[idx] = InfoEstudiante.AñadirNota(elemento, notasOpcion);
                        
                    }
                    else{
                        banderita = false;
                    }
                }while(banderita);
            }else{
                Console.WriteLine("No hay nadie asi");
            }
        }
    }
    public static byte Reportes()
    {
        Console.WriteLine("1. Notas del grupo");
        Console.WriteLine("2. Notas Finales");
        Console.WriteLine("0. Regresar al menu principal");
        Console.Write("Opcion: ");
        return Convert.ToByte(Console.ReadLine());
    }
    public static void SaveData(List<InfoEstudiante> lstListado)
    {
        string json = JsonConvert.SerializeObject(lstListado, Formatting.Indented);
        File.WriteAllText("boletin.json", json);
    }
    public static List<InfoEstudiante> LoadData()
    {
        using (StreamReader reader = new StreamReader("boletin.json"))
        {
            string json = reader.ReadToEnd();
            return System.Text.Json.JsonSerializer
            .Deserialize<List<InfoEstudiante>>(json, new System.Text.Json.JsonSerializerOptions()
            { PropertyNameCaseInsensitive = true }) ?? new List<InfoEstudiante>();
        }
    }
}
