using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordenadores2
{
    class COrdenador
    {
        // Declaramos las variables
        private string marca;
        private string procesador;
        private int peso;
        private bool encendido = false;
        private bool pantalla = false;

        // Declaramos el metodo EncenderOrdenador

        public void EncenderOrdenador ()
        {
            if ( encendido == true )
            {
                System.Console.WriteLine ( "El equipo ya esta encendido" );
            }
            else 
            {
               encendido = true;
               pantalla = true;
               System.Console.WriteLine ("El ha sido encendido");
            }
        }

        // Se declara el metodo estado en el cual veremos en que estado se encuentra el ordenador
        public void Estado ()
        {
            System.Console.Write ("\nElestado del ordenador es el siguiente");
            System.Console.Write ( "\nMarca:" + marca );
            System.Console.Write ( "\nProcesador:" + procesador );
            System.Console.Write ( "\nPeso:" + peso +"Kg" );

            if ( encendido == true )
            {
                System.Console.Write ( "\n El ordenador esta encendido" );
            }

            else
            
                System.Console.Write ( "\n el ordenador esta apagado" );
            

            if ( pantalla == true )
            {
                System.Console.Write ( "\n la pantalla esta activada" );
            }
            else
            
                System.Console.Write ( "\n la pantalla esta apagada" );
                System.Console.Write ( "\n" );
        }
            
            
            // declaramos la propiedad Marca

            public string Marca
            {
                get
                {
                    return marca;
                }
                set
                {
                    if(value == null)
                    
                        marca = "marca desconocida";
                    else
                        marca = value;
                }
            }     
        }      
    }

