using System;

namespace testcs
{
    class Program
    {
        static void Main(string[] args)
        {

            Random numero =new Random();
            int aleatorio = numero.Next(0,100);
            int minumero;
            int intentos=0;
            Console.WriteLine("Introduce un nuemero entre el 0 y 100");

            do{
                intentos++;
                
                try
                {
                    minumero = int.Parse(Console.ReadLine());    
                }
                /* 
                //despues de una captura genereal no se puede hacer una captura de uno que herede de exceptio
                //siempre la que es mas concreta debe ir antes de la general.
                catch (FormatException e)
                {   
                    Console.WriteLine("Has introducido texto.");
                    //Console.WriteLine(ex.Message);
                    minumero=0; //se inicializa en 0 para que continue el programa
                }
                */
                
                //otra exeception usando filtros
                catch (Exception e) when (e.GetType() != typeof(FormatException)  //captura general
                {
                    
                    Console.WriteLine("Ha habido un error");
                    //Console.WriteLine(ex.Message);
                    minumero=0; //se inicializa en 0 para que continue el programa
                }
                catch (FormatException e) //captura general
                {
                    
                    Console.WriteLine("Has introducido texto");
                    //Console.WriteLine(ex.Message);
                    minumero=0; //se inicializa en 0 para que continue el programa
                }


                                
                if(minumero > aleatorio ) Console.WriteLine("El n° mas bajo :");
                if(minumero < aleatorio ) Console.WriteLine("El n° mas alto :");
            
            }while (aleatorio != minumero);

            Console.WriteLine($"Correcto ! has necesitado {intentos} intentos");


            //int edad=2;
            //string gian="Gian";
            //Console.WriteLine("La edad de "+gian+" es : "+edad);
            //Console.WriteLine($"{gian} tienes una edad de {edad} años");//Interpolacion de string -- solo es de c#
            
            /*
            int sininiciar2=2; 
            int p1;
            int p2; 
            int p3;
            int p4;
            p1=p2=p3=p4 =27; //solo lo hace c#
            */

            //declaracion implicita de variables--- se declara y se inicia en la misma linea con var
            //var sininiciar = 238; //no es necesario especificar el tipo de variable--
            //pero no se puede cambiar por otro valor- se respeta a lo largo de todo el programa
            //Console.WriteLine(sininiciar);

            /* Constantes
            const int valor1=5;
            const int valor2=1;
            Console.WriteLine("el valor de la constante es {0}, {1}",valor1,valor2);
            */


            /* LLAMANDO A LOS METODOS
            MensajeenPantalla();//no ejecutarara porque exige que el metodo sea static
            Console.WriteLine(SumarNumeros(2, 67, 4545));
            Console.WriteLine(RestarNumeros(8,8,4));
            */
        }// fin del metodo main
            
        /*  Metodos
        static void MensajeenPantalla()
        { //da igual como este ubicandos los metodos siempre lo ejecuta el main
            Console.WriteLine("Llama al metodo MensajeenPantalla()");
        }

        static int SumarNumeros(int x, int y)
        {
            return x+y;
        }

        //otra forma de usar un metodo con una linea de codigo => se da por supuesta el return
        static int RestarNumeros(int x, int y) => x-y;
        
        //Sobrecarga de metodos debe tener diferente numero de parametross y del mismo tipo
        static int RestarNumeros(int x, int y, int z) => x-y-z;

        //Parametros Opcionales -- se indica opcional dandole un valor z=0
        static int SumarNumeros(int x, int y, int z=0) => x+y+z;
        
        */
        






            
    }
}
