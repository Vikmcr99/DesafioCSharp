using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio3
{
    public interface IRepositorio
    {
        void Play();
        void Detalhes();

        public static List<Informacoes> listaInformacoes = new List<Informacoes>();

        public static void Salvar(Informacoes informacoes)
        {
            listaInformacoes.Add(informacoes);
        }

        public static IEnumerable<Informacoes> InformacoesListadas()
        {
            return listaInformacoes;
        }

    }
}
