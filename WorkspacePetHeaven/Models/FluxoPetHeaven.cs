using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workspace.Models
{
    public class Estoque
    {
      public int IdProduto{get;set;}
      public string NomeProduto {get;set;}
      public decimal ValorProduto{ get; set; }
      public int QuantidadeProduto{ get; set; }

    public class Compras {

      public int IdProduto{get;set;}
      public string NomeProduto {get;set;}
      public decimal ValorProduto{ get; set; }
         
     
      public void TomarAdvertencia()
      {
        int Estoque = ''
        int Compras = ''
        
        NovaQuantidade = Estoque - Compras

        Console.WriteLine(NovaQuantidade);
      }

      public void SairMaisCedo() 
      {
        Console.WriteLine($"O aluno {Nome} sairá mais cedo!");
      }
    }

    
}}

//características -> são as props (propriedade)
// Ações -> métodos (função)
// class é o molde
// -------------------------------
// get e set são métodos:
// get -> pegar algo
// set -> alterar algo

// -----------VISIBILIDADE-----------
//public -> qualquer lugar do projeto
//privace -> somente a class terá acesso
//default -> somente o pacote
// protect -> somente as class que possuem heranças
// -----------------------------------
//char -> comporta somente 1 caracter. ( aspas simples)
// $ -> variável e texto
