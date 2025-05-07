using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reserva
    {
        #region Atributos
        private string cliente;
        private string fechaentrada;
        private string fechasalida;
        private string tipo;
        #endregion

        #region Propiedades
        public string Cliente 
        {
            set { cliente = value; }
            get { return cliente; }
           
        }
        public string Fechaentrada 
        {
            set { fechaentrada = value; }
            get { return fechaentrada; }
            
        }

        public string Fechasalida 
        {
            set { fechasalida = value; }
            get { return fechasalida; }
          
        }

        public string Tipo 
        {
            set { tipo = value; }
            get { return tipo; }
           
        }
        #endregion

        #region Constructores
        public Reserva() 
        { }

        public Reserva(string clien, string fentrada, string fsalida, string tp)
        {
            cliente= clien;
            fechaentrada= fentrada;
            fechasalida= fsalida;
            tipo= tp;
        }
        #endregion

        #region Metodos

      
        

        #endregion

      
    }
  
}