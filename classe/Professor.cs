using System;

namespace Polimorfismo2.classe
{
    public class Professor : Taxa
    {
        public string turma;
        public override void  ValeRefeicao(){
            Console.WriteLine($"A taxa do professor é de 10%");
        }
    }
}