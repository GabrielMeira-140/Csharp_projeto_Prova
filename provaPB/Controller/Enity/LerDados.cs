using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace provaPB
{
    class LerDados
    {
        //private
        private String nome;
        private String escuderia;
        private int numeroCarro;
        private float larguraCarro;
        private String tempoVolta;
        private String dataProva;

        public LerDados()
        {
            nome = string.Empty; //retorna uma matriz vazia.
            escuderia = string.Empty;
            numeroCarro = 0;
            larguraCarro = 0;
            tempoVolta = string.Empty;
            dataProva = string.Empty;
            
        }

        public LerDados(String name, String scuderia, int numcar, float Cwidth, String time, String data)
        {
            nome = name;
            escuderia = scuderia;
            numeroCarro = numcar;
            larguraCarro = Cwidth;
            tempoVolta = time;
            dataProva = data;
        }

        // public + get's e set's
        public String Nome
        {
            get { return this.nome; }//obtendo dados
            set { this.nome = value; }
        }

        public String Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }


        public int NumeroCarro
        {
            get { return this.numeroCarro; }
            set { this.numeroCarro = value; }
        }

        public float LarguraCarro
        {
            get { return this.larguraCarro; }
            set { this.larguraCarro = value; }
        }


        public String TempoVolta
        {
            get { return this.tempoVolta; }
            set { this.tempoVolta = value; }
        }

        public String DataProva
        {
            get { return this.dataProva; }
            set { this.dataProva = value; }
        }

    }
}
