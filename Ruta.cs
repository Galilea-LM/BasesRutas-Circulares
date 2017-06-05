using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3Circulares_Bases_y_Rutas
{
    class Ruta
    {
        private Base inicio;
        public Ruta()
        {
            inicio = null;
        }

        public void agregarBase(Base nueva)
        {
           
            bool Agregar = true;
            if(inicio== null)
            {
                inicio = nueva;
                nueva.siguiente = inicio;
            }
            else
            {
                Base temporal = inicio;
                while(temporal.siguiente!= inicio && Agregar != false)
                {
                    if(temporal.nombreBase == nueva.nombreBase)
                    {
                        Agregar = false;
                    }
                }
                if(Agregar==true && temporal.nombreBase != nueva.nombreBase)
                {
                    temporal.siguiente = nueva;
                    nueva.siguiente = inicio;
                }
            }
            
        }

        public void agregarInicio(Base nueva)
        {
            Base temporal = inicio;
            bool Agregar = true;

            if (inicio == null)
            {
                inicio = nueva;
                nueva.siguiente = inicio;
            }

            else
            {
                while (temporal.siguiente != inicio && Agregar != false)
                {

                    if (temporal.nombreBase == nueva.nombreBase)
                    {
                        Agregar = false;
                    }
                    temporal = temporal.siguiente;
                }
                if (temporal.nombreBase != nueva.nombreBase && Agregar == true)

                {
                    nueva.siguiente = inicio;
                    inicio = nueva;
                    temporal.siguiente = inicio;
                }
            }
        }

       

        public void eliminar(string nombreBase)
        {
            Base temporal = inicio;
            if (temporal.nombreBase == nombreBase)
            {
                if (temporal.siguiente == inicio)
                {
                    temporal = null;
                    inicio = temporal;
                }

                else
                {
                    while (temporal != inicio)
                    {
                        temporal = temporal.siguiente;
                    }                 
                    temporal.siguiente = inicio.siguiente;
                    inicio = inicio.siguiente;
                }
            }

        }

        public void EliminarInicio()
        {
            Base temporal = inicio;
            if (temporal.siguiente == inicio)
                inicio = null;
            else
            {
                while (temporal.siguiente != inicio)
                {
                    temporal = temporal.siguiente;
                    temporal.siguiente = inicio.siguiente;
                    inicio = inicio.siguiente;
                }          
            }
        }

        public Base buscarBase(string nombreBase)

        {

            Base temporal = inicio;

            while (temporal.siguiente != inicio && temporal.nombreBase != nombreBase)

            {

                temporal = temporal.siguiente;

            }

            return temporal;

        }
    }
}
