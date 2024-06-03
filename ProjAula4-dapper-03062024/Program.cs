// See https://aka.ms/new-console-template for more information
using Controllers;
using Models;

Console.WriteLine("Inicio...");

Pedido pedido = new Pedido
{
    Id = 1,
    Descricao = "Quero tudo",
    Mesa = 10
};

if (new PedidoController().Inserir(pedido))
{
    Console.WriteLine("Inseriu tudo!!!!");
}
else
{
    Console.WriteLine("ERRO");
}
        
