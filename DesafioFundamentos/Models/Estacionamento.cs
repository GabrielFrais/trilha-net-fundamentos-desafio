namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private List<string> veiculos = new List<string>();

        public decimal preco_inicial;
        public decimal preco_hr;

        public void Cadastrar()
        {
            while (true)
            {
                Console.WriteLine("\nInforme a placa do veículo para estacionar");
                string? placa = Console.ReadLine();
                placa?.Trim().ToUpper();

                if (string.IsNullOrEmpty(placa))
                {
                    Console.WriteLine("\nValor incorreto! Tente novamente");
                    continue;
                }
                else if (veiculos.Contains(placa))
                {
                    Console.WriteLine("\nEsse veículo já está cadastrado no sistema");
                    Continuar();
                    return;
                }
                else
                {
                    veiculos.Add(placa);
                    Console.WriteLine($"\nVeículo {placa} cadastrado com sucesso!");
                    Continuar();
                    return;
                }
            }

        }

        public void Remover()
        {
            while (true)
            {
                Console.WriteLine("\nInforme a placa do veículo para remover");
                string? placa = Console.ReadLine();
                placa?.Trim().ToUpper();

                if (string.IsNullOrEmpty(placa))
                {
                    Console.WriteLine("\nValor incorreto! Tente novamente");
                    continue;
                }
                else if (!veiculos.Contains(placa))
                {
                    Console.WriteLine("\nEsse veículo não está estacionado");
                    Continuar();
                    return;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("\nPor quantas horas este veículo permaneceu no estacionamento?");

                        string? entrada_horas = Console.ReadLine();

                        if (!string.IsNullOrEmpty(entrada_horas))
                        {
                            int.TryParse(entrada_horas, out int horas);
                            decimal valor = preco_inicial + (preco_hr * horas);

                            veiculos.Remove(placa);
                            Console.WriteLine($"\nVeículo {placa} removido com sucesso e o preço total foi de R${valor}");
                            Continuar();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("\nValor incorreto! Tente novamente");
                            continue;
                        }
                    }
                }
            }
        }

        public void Listar_Veiculos()
        {
            Console.WriteLine("\nVeículos estacionados:");
            foreach (string placa in veiculos)
            {
                Console.WriteLine(placa);
            }
            Continuar();
        }

        public void Continuar()
        {
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();
        }
    }
}