using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proyecto
{
  class Persona
    {
        //Atibutos
        private string nombre_y_apellido;
        private string email;
        private long dni;
        private long tel;

        //Metodos
        public Persona(string nom_ap, string em, long d, long t)
        {
            this.Nombre_y_apellido = nom_ap;
            this.Email = em;
            this.Dni = d;
            this.Tel = t;
        }
        public string Nombre_y_apellido
        {
            get
            {
                return nombre_y_apellido;
            }

            set
            {
                nombre_y_apellido = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public long Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public long Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }  
    }
  }

