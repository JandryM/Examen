using System;
namespace examen2
{
    class EstuUniversidad:Estudiante
    {
        string nombreinstitu {get;set;}
  
        int cantidadcredi {get;set;}
        int precioCredito {get;set;}
        public EstuUniversidad(string nombres,string apellidos,string nombreinstitu,int cedula, int cantidadcredi,int precioCredito): base(nombres, apellidos,nombreinstitu, cedula)
        {

            this.cantidadcredi=cantidadcredi;
            this.precioCredito=precioCredito;
        }
        public void Calculo3()
        {
            int total;
            total= cantidadcredi*precioCredito;
            Console.WriteLine("El valor total anual es: "+ total);
        }
    }
}