using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio3
{
    public class Serie:Informacoes, IRepositorio
    {
        public string _nomeDiretor;
        public string _nomeAtor;
        public string _nomeAtriz;

        public Serie(int codigo, string nome, string genero, string nomeDiretor, string nomeAtor, string nomeAtriz):base(codigo, nome, genero)
        {
            _nomeDiretor = nomeDiretor;
            _nomeAtor = nomeAtor;
            _nomeAtriz = nomeAtriz;
        }

        public void Play()
        {
            Console.WriteLine("Estou assistindo a Serie " + Nome);
        }

        public void Detalhes()
        {
            foreach (Informacoes i in IRepositorio.InformacoesListadas())
            {
                if(i.Codigo % 2 != 0) //Codigo par para Podcast e codigo impar para Serie
                    Console.WriteLine($"Nome: {Nome}, Genero: {Genero}, Diretor: {NomeDiretor}, Ator Principal: {NomeAtor}, Atriz Principal: {NomeAtriz}");
            }
        }

        #region GET SET
        public string NomeDiretor
        {
            get { return _nomeDiretor; }
            set { _nomeDiretor = value; }
        }

        public string NomeAtor
        {
            get { return _nomeAtor; }
            set { _nomeAtor = value; }
        }

        public string NomeAtriz
        {
            get { return _nomeAtriz; }
            set { _nomeAtriz = value; }
        }

        #endregion
    }
}
