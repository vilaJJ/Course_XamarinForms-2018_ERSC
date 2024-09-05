using Mimica.Models.Enums;
using System.Collections.Generic;

namespace Mimica.Data
{
    internal static class Armazenamento
    {
        internal static Models.Jogo Jogo { get; set; }
        internal static short RodadaAtual { get; set; }
        internal static bool IsFimDeJogo { get; set; }

        internal static Dictionary<Dificuldade, List<string>> Palavras
        {
            get
            {
                return new Dictionary<Dificuldade, List<string>>()
                {
                    { 
                        Dificuldade.Facil, 
                        new List<string> 
                        { 
                            "Olho",
                            "Língua",
                            "Chinelo",
                            "Milho",
                            "Penalti",
                            "Bola",
                            "Ping-Pong",
                        } 
                    },
                    { 
                        Dificuldade.Medio, 
                        new List<string> 
                        {
                            "Carpinteiro",
                            "Computador",
                            "Luz",
                            "Lápis",
                            "Óculos",
                            "Celular",
                            "Orelhão",
                        } 
                    },
                    { 
                        Dificuldade.Dificil, 
                        new List<string> 
                        { 
                            "Cisterna",
                            "Lanterna",
                            "Ventilador",
                            "Avião",
                            "Carro",
                            "Livro",
                            "Porta",
                        } 
                    }
                };
            }
        }
    }
}
