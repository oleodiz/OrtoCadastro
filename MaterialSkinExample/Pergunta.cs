using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample
{
    public class Pergunta
    {
        public int num { get; set; }
        public string palavra{get;set;}
        public string titulo{get;set;}
        public string opcaoA { get; set; }
        public string opcaoB { get; set; }
        public string opcaoC { get; set; }
        public int opcaoCorreta{get;set;}
        public int dificuldade{get;set;}
        public String dica{get;set;}

        public int nivel { get; set; }
        public int nivel2 { get; set; }
    }
}
