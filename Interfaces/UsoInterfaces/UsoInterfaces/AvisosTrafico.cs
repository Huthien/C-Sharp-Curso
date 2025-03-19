using System;
using System.Runtime.InteropServices;

namespace UsoInterfaces
{
    class AvisosTrafico : IAvisos
    {
        //Constructores:
        public AvisosTrafico() 
        {
            remitente = "DGT";
            mensaje = "-Sanción cometida-";
            fecha = "-";
        }
        public AvisosTrafico(String remitente, String mensaje, String fecha) 
        { 
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        //Métodos heredados de la Interfaz:
        public void MostrarAviso() => Console.WriteLine("{0}. El mensaje ha sido enviado por {1} el día {2}", mensaje, remitente, fecha);
        public String getFecha() => fecha;

        //Campos de clase:
        private String remitente;
        private String mensaje;
        private String fecha;
    }
}
