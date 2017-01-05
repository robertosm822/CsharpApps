using System;

namespace Csharp01
{
    class Program
    {
       
        private static void ExibirMensagem() {
            Console.WriteLine("Aqui esta a mensagem!");
        }
        protected static string RetornarString()
        {
            return "Metodo com retorno";
        }

        //metodo com parametro
        static void ImprimirValor(decimal Valor) {
            Console.WriteLine(Valor);
        }

        static void Somar(int valor) {
            valor += 10;
            Console.WriteLine(valor);
        }
        //metodo com parametro por referência
        static void Somar10 (ref int value){
            value += 10;
            Console.WriteLine(value);
        }

        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Roberto";
            p.Sobrenome = "Soares";
            p.DataNascimento = DateTime.Now;
            p.Sexo = Sexo.Masculino;

            string pessoa = p.Falar(string.Format("Olá {0} {1}, nasci em: {2}, sou do sexo: {3}"
                , p.Nome, p.Sobrenome, p.DataNascimento, p.Sexo)
                );

            Console.WriteLine(pessoa);

            /*
            //ecutando metodo simples
            //mas que so poderá ser do tipo static
            ExibirMensagem();

            string retornado = RetornarString();

            Console.WriteLine(retornado);

            ImprimirValor(25.65m);

            Somar(25);

            //USANDO O VALOR POR REFERENCIA PODE-SE NOTAR QUE A VARIAVEL LOCAL
            //PASSA A ARMAZENAR EM MEMORIA O VALOR SOMADO NA EXECUCAO DO METODO
            int valorLocal = 15;
            Somar10(ref valorLocal);
            Console.WriteLine(valorLocal);
            */

            /*
            //exemplo de atributos de um funcionario
            int matricula = 10;
            string nome = "Pedro";
            string sobrenome = "Silva";
            DateTime dataNascimento = DateTime.Now;
            decimal salario = 4200.00m; //deve-se inserir o m de milhar
            bool feriasVencidas = true;
            char sexo = 'M';  //apenas um caracter entre aspas simples, nunca aspas duplas
            

            Console.WriteLine("Matricula: "+matricula);
            //Console.WriteLine("Nome: " + nome + " "+sobrenome);
            //FORMA MAIS ELEGANTE DE CONCATENAR O TEXTO
            Console.WriteLine(string.Format("{0} {1}", nome, sobrenome));
            Console.WriteLine("Data Nascimento: " + dataNascimento);
            Console.WriteLine("Salario: " + salario);
            if (sexo == 'M')
            {
                Console.WriteLine("Sexo: Masculino");
            }
            else {
                Console.WriteLine("Sexo: Feminino");
            }
            if (feriasVencidas == true) {
                Console.WriteLine("...:: FERIAS VENCIDA ::.....");
            }
            else {
                Console.WriteLine("....: Sem férias a vencer :....");
            }

            //operadores matematicos
            c

            decimal resultado1 = Convert.ToDecimal(a) * Convert.ToDecimal(b);
            decimal resultado = Convert.ToDecimal(a) / Convert.ToDecimal(b);
            //operador de resto da divisão
            int resto = a % b;

            Console.WriteLine(resultado);
            Console.WriteLine("Resto da divisão:"+resto);
            */
            //operador de incremento e decremento =====================
            /*
            int a = 15;
            int b = 2;

            a -= 3;
            b += 1;

            Console.WriteLine("Valor de A: "+a+"\n Valor de B: "+b);
            */
            //=========================================================

            //=== ESTRUTURAS CONDICIONAIS ====================================
            /*
            string idadePassada;

            Console.WriteLine("Digite a idade:   ");

            //armazena interação do usuario na variavel idadePassada
            idadePassada = Console.ReadLine();

            string resultado = int.Parse(idadePassada) > 60 ? "Aposentado" : "Trabalhando";

            if (int.Parse(idadePassada) > 17)
            {
                Console.WriteLine("Autorizado! " + resultado);
            }
            else {
                Console.WriteLine("Desautorizado! "+ resultado);
            }

            switch (int.Parse(idadePassada)) {
                case 60: Console.WriteLine("Aposentado");
                    break;
                case 10: Console.WriteLine("Criança");
                    break;
                default: Console.WriteLine("Indefinido");
                    break;
            }
            */
            //================================================================
            /*
            //==== ESTRUTURA DE REPETICAO ====================================
            int[] colecao = new int[] {5,10,15,25 };

            //foreach (var item in colecao)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i =0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            int indice = 12;
            //while (indice > 0) {
            //    Console.WriteLine(indice);
            //    indice--;
            //}

            do {
                Console.WriteLine(indice);
                indice--;
            } while (indice > 10);
            */
            //================================================================

            Console.Read();
        }
    }
}
