using System;

namespace Polimorfismo2.classe
{
    public abstract class Taxa
    {
        private float valor;
        public virtual void ValeRefeicao(){
            Console.WriteLine("A taxa a ser paga é de 5%");
        }
    }
}