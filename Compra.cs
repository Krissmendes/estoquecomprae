using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14
{
    class Compra
    {
        Carrinho _produtos;
        Estoque _estoque;
        public Carrinho Produtos
        {

            get
            {
                return _produtos;
            }

        }
        public Estoque Estoque
        {

            get
            {
                return _estoque;
            }

        }
        public Compra(Carrinho produtos, Estoque estoque) 
        {

            this._estoque = estoque;
            this._produtos = produtos;
            
        }
        public void F_Dinero() 
        {
        
            foreach(KeyValuePair<Produto, int> pair in this._produtos.Itens) 
            {

                if (this._estoque.Itens.ContainsKey(pair.Key) && this._estoque.Itens[pair.Key] >= this._produtos.Itens[pair.Key]) 
                {
                    
                    this._estoque.Itens[pair.Key] -= pair.Value;
                    Console.WriteLine("Comprado " + pair.Key.Nome);
                
                }

            }
        
        }

    }
}
