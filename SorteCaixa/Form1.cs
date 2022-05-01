using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteCaixa
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorteioSemanal_Click(object sender, EventArgs e)
        {
            var qntnumeros = 3268760;
            var sorteio2 = string.Empty;

            var sorteio1 = string.Empty;
            string meuHashSet1 = string.Empty;
            string res = string.Empty;
            int[] sortefinal = new int[] { };

            for (int i = 0; i < qntnumeros; i++)
            {
                    var Sorteio1 = sorteio1.Split(',');
                    string[] SSorteio1 = Sorteio1;
                   
                    var meuHashSet = new HashSet<string>(SSorteio1);
                    var valoresRepetidos = SSorteio1.Length - meuHashSet.Count;
                    Random numAleatorio = new Random();
                    int valorInteiro = numAleatorio.Next(1, 25);
                   
                    sorteio1 += valorInteiro + ",";
                    if (meuHashSet.Count == 16)
                    {
                                   

                    meuHashSet1 = string.Join(", ", meuHashSet.OrderBy(s => s));
                                        
                    string[] arrayString = meuHashSet1.Split(',');
                    arrayString[0] = "0";
                    int[] meuHashSet1Int = arrayString.Select(int.Parse).ToArray();
                    
                    sortefinal =  insertionSort(meuHashSet1Int);

                    break;
                    }

            }

            int indexToRemove = 0;
            sortefinal = sortefinal.Where((source, index) => index != indexToRemove).ToArray();
          
            string result = string.Join(" - ", sortefinal);
            lblNumerosSistema.Text = "Números do Sistema:\n" + result;

            
        }
              
        public static int[] insertionSort(int[] vetor)
                {
                    int i, j, atual;
                    for (i = 1; i < vetor.Length; i++)
                    {
                        atual = vetor[i];
                        j = i;
                        while ((j > 0) && (vetor[j - 1] > atual))
                {
                        vetor[j] = vetor[j - 1];
                        j = j - 1;
                    }
                    vetor[j] = atual;
                }
            return vetor;
        }

        /* https://vestibular.uol.com.br/revisao-de-disciplinas/matematica/faca-calculos-para-acertar-a-megasena.jhtm
            chance de acertar é de 1 em 50.063.860.

            Se apostarmos 1 jogo de seis dezenas, a probabilidade de ganharmos é de 1 em 50.063.860, que corresponde a 
            0,000002% de chance de ganhar.

            E = ser sorteada sena com seis números consecutivos.
            F = ser sorteada sena que não tem números consecutivos.
            A probabilidade de ocorrer F é muito maior do que a de ocorrer E, pois E é formado por apenas 55 senas({1, 2, 3, 4, 5, 6",
            {2, 3, 4, 5, 6, 7", {3, 4, 5, 6, 7, 8", ..., {55, 56, 57, 58, 59, 60"), enquanto F é formado por muito mais.


            lotofacil = 3.268.760
            A chance de ganhar é de uma em 3.268.760. Quando analisamos os níveis secundários, o cenário é mais animador. Uma aposta de 15 
            dezenas tem chance de vitória de uma em 21.791 na faixa de 14 acertos, já com 13 pontos, a probabilidade vai para apenas uma em 691.
            
            */

    }
}
