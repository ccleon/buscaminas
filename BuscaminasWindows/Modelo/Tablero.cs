using System;
namespace BuscaminasWindows.Modelo
{
    public class Tablero
    {
        private int fils, cols, nivel;
        private Casilla[,] casillas;

        public Tablero(int filas, int columnas, int nivel)
        {
            //sumo 2 para tener un borde
            this.fils = filas + 2;
            this.cols = columnas + 2;
            this.nivel = nivel;

            RellenaTablero();
        }

        internal int GetNumeroCasillas()
        {
            return (cols - 2) * (fils - 2);
        }

        private void RellenaTablero()
        {
            casillas = new Casilla[fils, cols];
            for (int f = 0; f < fils; f++)
                for (int c = 0; c < cols; c++)
                    casillas[f, c] = new Casilla();

            PonBombas();
            PonUnosEnElBorde();
        }

        private void PonUnosEnElBorde()
        {
            for (int c = 0; c < cols; c++)
            {
                casillas[0, c].SumarUno();
                casillas[fils - 1, c].SumarUno();
            }

            for (int f = 0; f < fils; f++)
            {
                casillas[f, 0].SumarUno();
                casillas[f, cols - 1].SumarUno();
            }
        }

        void SumaUnosAlrededor(int f, int c)
        {
            if (f > 0 || f < fils - 1 || c < cols - 1 || c > 0)
            {
                for (int i = (f - 1); i <= (f + 1); i++)
                    for (int j = (c - 1); j <= (c + 1); j++)
                    {
                        casillas[i, j].SumarUno();
                    }
            }
        }

        private void PonBombas()
        {
            Random rnd = new Random();

            for (int f = 1; f < fils - 1; f++)
                for (int c = 1; c < cols - 1; c++)
                {
                    if (rnd.Next(100) < (nivel * 10))
                    {
                        casillas[f, c].PonBomba();
                        SumaUnosAlrededor(f, c);
                    }
                }
        }

        internal void LevantaCasilla(int fila, int colu)
        {
            if (!casillas[fila, colu].EstaLevantada())
            {
                casillas[fila, colu].Levanta();
                if (casillas[fila, colu].EsVacia() && !casillas[fila, colu].EsBomba())
                {
                    for (int f = (fila - 1); f <= (fila + 1); f++)
                        for (int c = (colu - 1); c <= (colu + 1); c++)
                            casillas[f, c].Levanta();
                }
            }
        }

        internal int DameValor(int fila, int colu)
        {
            return casillas[fila, colu].GetValor();
        }

        internal bool EstaLevantada(int fila, int colu)
        {
            return casillas[fila, colu].EstaLevantada();
        }

        internal bool EsBomba(int fila, int colu)
        {
            return casillas[fila, colu].EsBomba();
        }

        internal void LevantarTodas()
        {
            for (int f = 0; f < fils; f++)
                for (int c = 0; c < cols; c++)
                    casillas[f, c].Levanta();
        }

        internal int CuantasBombas()
        {
            int numBombas = 0;
            for (int f = 1; f < fils - 1; f++)
                for (int c = 1; c < cols - 1; c++)
                {
                    if (casillas[f, c].EsBomba())
                    {
                        numBombas++;
                    }
                }
            return numBombas;
        }
    }
}
