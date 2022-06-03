using System;
namespace examen2
{
    class Program
    {
        public static void Main (string [] args)
        {
            EstuPrimaria estud = new EstuPrimaria ("Jose", "Mantuano", "4Noviembre", 213846);
            estud.Imprimir();
            estud.Calculo1();

            EstuSecundaria estuSecundaria = new EstuSecundaria ("Maria"," Ponce", " 5Junio", 2315646, 5, 100);
            estuSecundaria.Imprimir();
            estuSecundaria.Calculo2();

            EstuUniversidad estuUniversidad = new EstuUniversidad ("Ramona", " Zosa", "Tarqui", 12654687, 3,7);
            estuUniversidad.Imprimir();
            estuUniversidad.Calculo3();
        }
    }
}
