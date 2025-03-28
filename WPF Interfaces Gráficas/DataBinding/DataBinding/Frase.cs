using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace DataBinding
{
    public class Frase : INotifyPropertyChanged
    {
        private string palabra1, palabra2, frase;

        public event PropertyChangedEventHandler PropertyChanged;

        //Método que se ejecuta o desencadena cuando cambia la propiedad:
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null) 
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        //Se declaran y establecen las propiedades:
        public string Palabra1 
        { 
            get { return palabra1; }
            set { palabra1 = value; OnPropertyChanged("Frase_Completa"); }
        }

        public string Palabra2
        {
            get { return palabra2; }
            set { palabra2 = value; OnPropertyChanged("Frase_Completa"); }
        }

        public string Frase_Completa
        {
            get { frase = palabra1 + " " + palabra2; return frase; }
            set {}
        }
    }
}
