using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_3___Encapsulamento
{
    class Carimbo:Interação
    {
        private string cor;
        private string texto;
        private int carga;

        public Carimbo(string Ptexto)
        {
            trocarTexto(Ptexto);
        }

        private string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        private string Texto
        {
            get { return texto; }
            set { texto = value; }
        }
        private int Carga
        {
             
            get { return carga; }
            set { carga = value; }
        }

        public void usar()
        {
            if (carga >= 1)
            {
                if (!string.IsNullOrEmpty(texto))
                {
                    if (!string.IsNullOrEmpty(cor))
                    {
                        Console.WriteLine("(" + texto + ")" + " na cor " + cor);
                        carga--;
                    }
                    else
                    {
                        Console.WriteLine("Impossivel carimbar -- carimbo sem cor ");
                    }
                    
                   
                }
                else
                {
                    Console.WriteLine("Impossiel carimbar -- carimbo sem texto ");
                }
            }
            else
            {
                Console.WriteLine("Impossiel carimbar -- carimbo sem carga ");
            }
        }
        public void carregar(string Pcor, int Pcarga)
        {
            trocarCor(Pcor);

            if (Pcarga < 1 || Pcarga > 10)
            {
                Console.WriteLine("Carga atual " + carga + " A carga deve ser entre 1 e 10 ");
            }
            else
            {
                carga = Pcarga;
            }
        }

        public void trocarCor(string Pcor)
        {
            if(Pcor == Cor)
            {
                Console.WriteLine("Carimbo já está com cor! ");
            }
            else
            {
                Cor = Pcor;
            }
        }

        public void trocarTexto(string Ptexto)
        {
            if(Ptexto == Texto)
            {
                Console.WriteLine("Carimbo já está com o texto! ");
            }
            else
            {
                Texto = Ptexto;
            }
        }
    }
}
