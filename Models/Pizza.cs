using System;
using System.Collections.Generic;
namespace TP08.Models
{
    public class Auto
    {
        private int _idAuto;
        private int _idMarca;
        private string _marca;
        private string _modelo;
        private int _precio;
        private DateTime _fechacreacion;
        private string _foto1;
        private string _foto2;
        private string _foto3;
        
        public int IdAuto
        {
            get
            {
                return _idAuto;
            }
            set{
                _idAuto = value;
            }
        }
        public int IdMarca
        {
            get
            {
                return _idMarca;
            }
            set{
                _idMarca = value;
            }
        }
        public string Marca
        {
            get
            {
                return _marca;
            }
            set{
                _marca = value;
            }
        }

          public string Modelo
        {
            get
            {
                return _modelo;
            }
            set{
                _modelo = value;
            }
        }
        public int Precio
        {
            get
            {
                return _precio;
            }
            set{
                _precio = value;
            }
        }
         public DateTime FechaCreacion
        {
            get
            {
                return _fechacreacion;
            }
            set{
                _fechacreacion = value;
            }
        }

         public string Foto1
        {
            get
            {
                return _foto1;
            }
            set{
                _foto1 = value;
            }
        }

         public string Foto2
        {
            get
            {
                return _foto2;
            }
            set{
                _foto2 = value;
            }
        }

         public string Foto3
        {
            get
            {
                return _foto3;
            }
            set{
                _foto3 = value;
            }
        }
    } 
}