using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ingressos
{
    internal class Ingresso
    {
        public Random random = new Random();
        
        public Dictionary<string, int> TipoIng = new Dictionary<string, int>()
        {
            ["Normal"] = 0,
            ["Vip Camarote"] = 0,
            ["Vip Experience"] = 0
        };

        public void distribuicaoIngresso()
        {
            int normal = 0;
            int camarote = 0;
            int experience = 0;
            int? total = 0;

            while (total < 1000 || total > 2000)
            {
                total = 0;
                normal = random.Next(300, 1001);
                camarote = random.Next(300, 1001);
                experience = random.Next(300, 1001);

                total = normal + camarote + experience;  
            }

            TipoIng["Normal"] = normal;
            TipoIng["Vip Camarote"] = camarote;
            TipoIng["Vip Experience"] = experience;

        }

        public void mostrarIngressos() 
        {
            foreach (var item in TipoIng)
            {
                Console.WriteLine($"({item.Key} = {item.Value})");
            }
        }
    }

    public class Transacoes
    {
        private Ingresso ingresso = new Ingresso();

        public int[] IngressosComprados = new int[1];
        private int dinheiroTotal;

        public void Dinheiro(int dinheiro)
        {
            dinheiroTotal = dinheiro;
            Console.WriteLine($"Seu dinheiro é de R${dinheiroTotal:N2}\n");
        }

        public void ComprarIngressos(string tipo, int quantidade)
        {
            if (!ingresso.TipoIng.ContainsKey(tipo)) 
            {
                Console.WriteLine("Não existe esse tipo de ingresso");
                return;
            }
            if (quantidade <= 0)
            {
                Console.WriteLine("Coloque um número válido");
                return;
            }
            if (ingresso.TipoIng[tipo] >= quantidade)
            {
                Console.WriteLine("A quantidade de ingressos é maior do que a que você digitou, deseja comprar todos?");
                string confirmação = Console.ReadLine();
                if (confirmação != "sim" || confirmação != "Sim") 
                {
                  ingresso.TipoIng[tipo] -= quantidade;
                    int custo = quantidade * (tipo.Contains("Normal") ? 40 : 80);
                    IngressosComprados[0] += quantidade;

                    Console.WriteLine($"Compra realizada! {quantidade} ingressos {tipo}");
                    Console.WriteLine($"Gasto: R${custo:N2} | Saldo restante: R${ingresso.TipoIng:N2}");
                }
                else
                {
                    Console.WriteLine($"Quantidade indisponivel! Máximo: {ingresso.TipoIng[tipo]}");
                    return;
                }
            }
            if (ingresso.TipoIng[tipo] < quantidade)
            {
                ingresso.TipoIng[tipo] -= quantidade;
                int custo = quantidade * (tipo.Contains("Normal") ? 40 : 80);
                IngressosComprados[0] += quantidade;

                Console.WriteLine($"Compra realizada! {quantidade} ingressos {tipo}");
                Console.WriteLine(value: $"Gasto: R${custo:N2} | Saldo restante: R${dinheiroTotal - custo:N2}");
            }
        }
    }
}
