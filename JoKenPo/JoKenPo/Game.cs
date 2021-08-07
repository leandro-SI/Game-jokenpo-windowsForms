﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
    class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] imagens =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Tesoura.png"),
            Image.FromFile("imagens/Papel.png")
        };

        public Image ImgPc { get; private set; } 
        public Image ImgJogador { get; private set; }
        

        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPc();

            ImgJogador = imagens[jogador];
            ImgPc = imagens[pc];

            if (jogador == pc)
            {
                return Resultado.Empatar;
            }
            else if ((jogador == 0 && pc == 1) || (jogador == 1 && pc == 2) || (jogador == 2 && pc == 0)) {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }

        }

        private int JogadaPc()
        {
            int mil = DateTime.Now.Millisecond; // retorno em milesegundos

            if (mil < 333)
            {
                return 0;
            }
            else if (mil >= 333 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }

    }
}
