using System;
namespace examen2
{
    class EstuPrimaria:Estudiante
    {
        int valorAnual {get;set;}
        public EstuPrimaria(string nombres, string apellidos,string nombreinstitu, int cedula): base(nombres, apellidos,nombreinstitu, cedula)
        {
            this.valorAnual= valorAnual;   
        }

        public void Calculo1()
        {
 
                valorAnual=100;
                Console.WriteLine(" El valor anual del estudiante de Primaria es: "+valorAnual+"$");
        }
    }
}