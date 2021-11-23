using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio3
{
    public abstract class Informacoes
    {
        protected int _codigo;
        protected string _nome;
        protected string _genero;

        public Informacoes(int codigo, string nome, string genero)
        {
            _codigo = codigo;
            _nome = nome;
            _genero = genero;
        }

        #region GET SET
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        #endregion
    }
}
