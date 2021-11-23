using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio3
{
    public class Podcast:Informacoes, IRepositorio
    {
        public string _apresentadores;
        public string _convidados;
        public int _duracao;

        public Podcast(int codigo, string nome, string genero, string apresentadores, string convidados, int duracao):base(codigo, nome, genero)
        {
            _apresentadores = apresentadores;
            _convidados = convidados;
            _duracao = duracao;
        }

        public void Play()
        {
            Console.WriteLine("Estou assistindo ao podcast " + Nome);
        }

        public void Detalhes()
        {
            foreach(Informacoes i in IRepositorio.InformacoesListadas())
            {
                if (i.Codigo % 2 == 0) //Codigo par para Podcast e codigo impar para Serie
                    Console.WriteLine($"Nome: {Nome}, Categoria: {Genero}, Apresentadores: {Apresentadores}, Convidados: {Convidados}, Duração: {Duracao} horas");
            }
        }

        #region GET SET
        public string Apresentadores
        {
            get { return _apresentadores; }
            set { _apresentadores = value; }
        }

        public string Convidados
        {
            get { return _convidados; }
            set { _convidados = value; }
        }

        public int Duracao
        {
            get { return _duracao; }
            set { _duracao = value; }
        }

        #endregion
    }
}
