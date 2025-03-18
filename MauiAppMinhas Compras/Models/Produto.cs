using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace MauiAppMinhas_Compras.Models
{
    public class Produto
    {
        string descricao;
        

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        
        public string Descricao
        {
            get => descricao;
            set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a descrição");

                }
                descricao = value;
            }
        }
        public double Quantidade { get; set; }

        public double Preco { get; set; }
        public double Total { get => Quantidade * Preco; }
    }
}
