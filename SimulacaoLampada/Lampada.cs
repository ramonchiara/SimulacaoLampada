using System;
namespace SimulacaoLampada
{
    public class Lampada
    {
        public bool Acesa;

        public Lampada()
        {
            this.Acesa = false;
        }

        public void Acender()
        {
            Acesa = true;
        }

        public void Apagar()
        {
            Acesa = false;
        }
    }
}
