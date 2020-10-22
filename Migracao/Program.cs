﻿using System;

namespace Migracao
{
    public class Program
    {
        private static string[] listaUrl = {
                                             "http://treinamento.sistematodos.com.br:82/CTN/Login.aspx",
                                             "https://homologacao.sistematodos.com.br/CTN/Login.aspx"
                                           };

        private static void Main(string[] args)
        {
            var url = ExibirMenu();

            var setup = new Setup(url);
            setup.ConfigurarOrdemExecucao();

            setup.FinalizarProcesso();
        }

        private static string ExibirMenu()
        {
            Console.WriteLine("Escolha o ambiente que deseja utilizar");
            Console.WriteLine("1 - Treinamento CTN");
            Console.WriteLine("2 - Homologação CTN");
            Console.Write("\nSistema desejado: ");
            var opcao = Console.ReadLine();
            switch (Convert.ToInt32(opcao))
            {
                case 1:
                    return listaUrl[0];
                case 2:
                    return listaUrl[1];
                default:
                    Console.WriteLine("Opção inválida!");
                    Environment.Exit(0);
                    break;
            }
            return null;
        }
    }
}