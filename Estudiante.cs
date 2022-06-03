using System;
namespace examen2
{
    class Estudiante
    {
        string nombres {get;set;}
        string apellidos {get;set;}
        string nombreinstitu {get;set;}
        int cedula {get;set;}
        public Estudiante(string nombres,string apellidos,string nombreinstitu,int cedula)
        {
            this.nombres= nombres;
            this.apellidos= apellidos;
            this.nombreinstitu= nombreinstitu;
            this.cedula= cedula;
        }
        public void Imprimir()
        {
            Console.WriteLine(" El nombre es: " +nombres + "\n El apellido es: " +apellidos+ "\n El nombre de la institucion es: " + nombreinstitu+ "\n Numero de cedula: " +cedula);
        }
    }
}