using System;
using System.Collections.Generic;

namespace ProvaAws
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Questoes = new List<string>();
            var RespostasUsuario = new List<string>();
            var RespostasCertas = new List<string>();

            Questoes.Add(new string("Fale sobre o EC2"));
            Questoes.Add(new string("Fale sobre o S3"));
            Questoes.Add(new string("Fale sobre a VPC"));
            Questoes.Add(new string("Fale sobre o NAT Gateway"));
            Questoes.Add(new string("Fale sobre o Internet Gateway"));
            Questoes.Add(new string("Quais os tipos de serviço disponíveis na AWS"));
            Questoes.Add(new string("Vantagens da nuvem pública"));
            Questoes.Add(new string("Desvantagens da nuvem pública"));
            Questoes.Add(new string("O que é nuvem híbrida"));
            Questoes.Add(new string("Fale sobre o IAM"));
            Questoes.Add(new string("O que é zona de disponibilidade?"));

            foreach (var questao in Questoes)
            {
                Console.WriteLine(questao);
                Console.Write("R:");
                string respostaUsuario = Console.ReadLine();
                RespostasUsuario.Add(respostaUsuario);
            }

            RespostasCertas.Add("O EC2 permite que os usuários aluguem computadores virtuais nos quais rodam suas próprias aplicações");
            RespostasCertas.Add("É um serviço oferecido pela Amazon Web Services que fornece armazenamento de objetos por meio de uma interface de serviço da web");
            RespostasCertas.Add("Uma nuvem privada virtual (VPC) é uma nuvem privada hospedada dentro de uma nuvem pública");
            RespostasCertas.Add("Permite o acesso de uma instância que está numa rede privada acesse a internet");
            RespostasCertas.Add("Permite que suas instancias dentro da Subnet Publica acessem a internet e sejam acessada pela internet. Uma Subnet é dita publica quando possui uma Route table que direciona o trafego para o IGW");
            RespostasCertas.Add("Computação\rArmazenamento\nBanco de dados\nRede e entrega de conteúdo\nSegurança, identidade e conformidade\nGerenciamento de custos");
            RespostasCertas.Add("Pagamento sob demanda, alta disponibilidade");
            RespostasCertas.Add("Dificuldade para adicionar camadas extras para obedecer protocolos segurança, como o LGPD");
            RespostasCertas.Add("Uma empresa que tem a abordagem híbrida da nuvem, faz uso de alguns recursos que utilizam infraestrutura própria e outros que utilizam infraestrutura terceirizada");
            RespostasCertas.Add("Serviço para gerenciar o acesso aos serviços da AWS");
            RespostasCertas.Add("Um ou mais datacenters dentro de uma região que possuem redundância de conectividade, rede e energia");

            Console.WriteLine("[1]Comparar respostas");
            var r1 = int.Parse(Console.ReadLine());
            switch (r1)
            {
                case 1:
                    foreach(var questao in Questoes)
                    {
                        int i = 0;
                        Console.WriteLine($"{questao}\n");
                        Console.WriteLine("Resposta dada\n");
                        
                        Console.WriteLine(RespostasUsuario[i]);

                        Console.WriteLine("Resposta certa\n");
                        Console.WriteLine(RespostasCertas[i]);

                        i++;
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
