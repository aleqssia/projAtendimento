using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAtendimento.Models
{
    class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public DateTime DataGerac
        {
            set { dataGerac = value; }
            get { return dataGerac; }
        }
        public DateTime HoraGerac
        {
            set { horaGerac = value; }
            get { return horaGerac; }
        }
        public DateTime DataAtend
        {
            set { dataAtend = value; }
            get { return dataAtend; }
        }
        public DateTime HoraAtend {
            set { horaAtend = value; }
            get { return horaAtend; }
        }

        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Now;
            this.horaGerac = DateTime.Now;
        }

        public string dadosParciais()
        {
            return id + " - " + DataGerac.ToString("dd/MM/yyyy") + " - " + HoraGerac.ToString("HH:mm");
        }

        public string dadosCompletos()
        {
            return id + " - " + DataGerac.ToString("dd/MM/yyyy") + " - " + HoraGerac.ToString("HH:mm") + " - " + DataAtend.ToString("dd/MM/yyyy") + " - " + HoraAtend.ToString("HH:MM");
        }
        
    }
}
