using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie s1 = new Serie(1, "Dark", "Suspense/Ficção","Baran Odar","Louis Hofmann", "Lisa Vicari");

            Podcast p1 = new Podcast(2, "PodPlay", "Jogos", "Yudi e Tiago Leifert", "Fallen e Fer", 2);

            IRepositorio.Salvar(s1);
            IRepositorio.Salvar(p1);


            Console.WriteLine("");
            s1.Play();
            s1.Detalhes();

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            
            p1.Play();
            p1.Detalhes();
        }
    }
}
