using System;

namespace Tp8_c_
{
    class Program
    {
        //constante de dias
        const int DIAS=7;
        static void Main(string[] args)
        {
            //declaracion de array
         string[] semana={"lunes","martes","miercoles","jueves","viernes","sabado","domingo"};
            //ciclo for para recorrer array
         for(int i=0;i<DIAS;i++){
            System.Console.WriteLine("este es el dia "+semana[i]);
            }
            //array al reves
            System.Console.WriteLine("ahora al reves");
           
           for(int i=DIAS-1;i>=0;i--){
            System.Console.WriteLine("este es el dia "+semana[i]+" al reves ");
           }
        }
    }
}
