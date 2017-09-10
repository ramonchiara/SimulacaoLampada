using System;
namespace SimulacaoLampada
{
    public class Lampada
    {
        private bool _Acesa;
        private bool _Queimada;
        private int VidaUtil;

        public Lampada()
        {
            Random rng = new Random();

            this._Acesa = false;
            this._Queimada = false;
            this.VidaUtil = rng.Next(10) + 1; // 1 a 10 vezes
        }

        public bool Acesa
        {
            get { return _Acesa; }
        }

        public bool Queimada
        {
            get { return _Queimada; }
        }

        public void Acender()
        {
            if (!Acesa)
            {
                if (!Queimada)
                {
                    VidaUtil--;
                    _Queimada = VidaUtil <= 0;
                }

                _Acesa = !Queimada;
            }
        }

        public void Apagar()
        {
            _Acesa = false;
        }
    }
}
