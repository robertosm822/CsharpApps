using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp01
{
    public enum Sexo
    {
        Masculino = 2,
        Feminino = 1
    }

    class Pessoa
    {
       

        private string nome;
        //aplicando o padrao de encapsulamento
        public string Nome {
            get { return nome; }
            set { nome = value; }
        }

        private string sobrenome;
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }

            set
            {
                sobrenome = value;
            }
        }

        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }

            set
            {
                dataNascimento = value;
            }
        }

       

        private Sexo sexo;
        internal Sexo Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }


        public Pessoa() {

        }

        public string Falar(string mensagem) {
            return mensagem;
        }
    }
}
