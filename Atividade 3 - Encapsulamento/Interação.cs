using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_3___Encapsulamento
{
    interface Interação
    {
        void usar();
        void carregar(string Pcor, int Pcarga);
        void trocarCor(string Pcor);
        void trocarTexto(string Ptexto);
    }
}
