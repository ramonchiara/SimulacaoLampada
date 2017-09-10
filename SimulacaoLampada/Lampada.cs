using System;
namespace SimulacaoLampada
{
    public class Lampada
    {
        private bool _Acesa;

        public Lampada()
        {
            this._Acesa = false;
        }

        public bool Acesa
        {
            get { return _Acesa; }
        }

        public void Acender()
        {
            _Acesa = true;
        }

        public void Apagar()
        {
            _Acesa = false;
        }
    }
}
