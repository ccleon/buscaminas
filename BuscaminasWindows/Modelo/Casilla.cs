using System;
namespace BuscaminasWindows.Modelo
{
    public class Casilla
    {
        private int valor;
        private bool levantada, bomba;

        public Casilla()
        {
            levantada = false;
            valor = 0;
            bomba = false;
        }

        public bool EsBomba()
        {
            return bomba;
        }

        internal void SumarUno()
        {
            valor = valor + 1;
        }

        internal void Levanta()
        {
            levantada = true;
        }

        public void PonBomba()
        {
            bomba = true;
        }

        public int GetValor()
        {
            return valor;
        }

        internal bool EsVacia()
        {
            return valor == 0;
        }

        internal bool EstaLevantada()
        {
            return levantada;
        }
    }
}