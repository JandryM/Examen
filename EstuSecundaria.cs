using System;
namespace examen2
{
    class EstuSecundaria:Estudiante
    {
        int nivelcruso {get;set;}
        int preciomensual {get;set;}
        public EstuSecundaria(string nombres,string apellidos,string nombreinstitu,int cedula, int nivelcruso, int preciomensual): base(nombres, apellidos,nombreinstitu, cedula)
        {

            this.nivelcruso=nivelcruso;
            this.preciomensual=preciomensual;
        }

        public void Calculo2()
        {
            int total;
            total=nivelcruso*preciomensual;
            Console.WriteLine("El valor de matricula anual es de: "+ total+ "$");
        }
    }
}