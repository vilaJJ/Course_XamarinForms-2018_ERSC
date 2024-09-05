using System;

namespace Mimica.Models.Enums
{
    public enum Dificuldade
    {
        Aleatorio = 0,
        Facil = 1,
        Medio = 2,
        Dificil = 3,
    }

    public static class DificuldadeExtension
    {
        public static ushort ObterPontuacao(this Dificuldade value)
        {
            switch (value)
            {
                case Dificuldade.Facil:
                    return 1;
                case Dificuldade.Medio:
                    return 3;
                case Dificuldade.Dificil:
                    return 5;
                default:
                    throw new InvalidOperationException("Modo de dificuldade não implementada.");
            }
        }
    }
}
