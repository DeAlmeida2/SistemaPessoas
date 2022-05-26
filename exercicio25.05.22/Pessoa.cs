using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio25._05._22
{
    internal class Pessoa
    {
        public string nome;
        public string cidade;
        public int idade;
        public string peso;
        public string altura;

        public Pessoa(string nome, string cidade, int idade, string peso, string altura)
        {
            this.nome = nome;
            this.cidade = cidade;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }
    }
}