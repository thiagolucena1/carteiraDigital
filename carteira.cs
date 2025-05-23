using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

int opcao;  //variavel utilizada para gerenciar o SWITCH - COntrole de fluso 
int fluxoswitch; //esta variavel é responsável por gerennciar o Switch caso o cliente deseje converter o valor inicial por outro valor

decimal valorCarteira;   //Esta variavel armazenja o valor inicial do cliente. 
decimal valorCarteiraTratado; // Esta variável é responsável por tratar valor após o usuario escolher converter o saldo para outro tipo de moeda.

Console.WriteLine("Digite o valor que você tem na sua carteira:");
valorCarteira = decimal.Parse(Console.ReadLine());

Console.WriteLine("Bem-vindo ao sistema de controle de carteira!");
Console.WriteLine("---------------------------------------------!");
Console.WriteLine("Escolha o seu tipo de moeda:");
Console.WriteLine("1 - Real");
Console.WriteLine("2 - Dólar");
Console.WriteLine("3 - Euro");
Console.WriteLine("4 - Libra");
Console.WriteLine("5 - Peso Argentino");

opcao = int.Parse(Console.ReadLine());  //ira ler a escolha do cliente. 

switch (opcao)
{
    case 1:
        Console.WriteLine("Você escolheu Real.");
        Console.WriteLine("Seu saldo atual é: ");
        Console.WriteLine(valorCarteira.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

        Console.WriteLine("Você deseja converter o SALDO para outro tipo de moeda?");
        Console.WriteLine("1 - SIM");
        Console.WriteLine("2 - NÃO");

        int opcaoo = int.Parse(Console.ReadLine());

        if (opcaoo == 1)      //Responsável por converter o valor caso o cliente queira. 
        {
            Console.WriteLine("Para qual moeda você deseja converter?");
            Console.WriteLine("1 - Dólar");
            Console.WriteLine("2 - Euro");
            Console.WriteLine("3 - Libra");
            Console.WriteLine("4 - Peso Argentino");

            fluxoswitch = int.Parse(Console.ReadLine()); 

            switch (fluxoswitch)
            {
                case 1:
                    valorCarteiraTratado = valorCarteira * 0.18m;
                    Console.WriteLine("Seu saldo em dólar é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                    break;
                case 2:
                    valorCarteiraTratado = valorCarteira * 0.16m;
                    Console.WriteLine("Seu saldo em euro é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("de-DE")));
                    break;
                case 3:
                    valorCarteiraTratado = valorCarteira * 0.13m;
                    Console.WriteLine("Seu saldo em libra é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
                    break;
                case 4:
                    valorCarteiraTratado = valorCarteira * 200.49m;
                    Console.WriteLine("Seu saldo em peso argentino é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")));
                    break;
            }
        }
        break;

    case 2:
        Console.WriteLine("Você escolheu Dólar.");
        Console.WriteLine("Seu saldo atual é: ");
        Console.WriteLine(valorCarteira.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

        Console.WriteLine("Você deseja converter o SALDO para outro tipo de moeda?");
        Console.WriteLine("1 - SIM");
        Console.WriteLine("2 - NÃO");

        opcaoo = int.Parse(Console.ReadLine());

        if (opcaoo == 1)
        {
            Console.WriteLine("Para qual moeda você deseja converter?");
            Console.WriteLine("1 - Real");
            Console.WriteLine("2 - Euro");
            Console.WriteLine("3 - Libra");
            Console.WriteLine("4 - Peso Argentino");

            fluxoswitch = int.Parse(Console.ReadLine());

            switch (fluxoswitch)
            {
                case 1:
                    valorCarteiraTratado = valorCarteira / 0.18m;
                    Console.WriteLine("Seu saldo em real é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
                    break;
                case 2:
                    valorCarteiraTratado = valorCarteira * 0.89m;
                    Console.WriteLine("Seu saldo em euro é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("de-DE")));
                    break;
                case 3:
                    valorCarteiraTratado = valorCarteira * 0.72m;
                    Console.WriteLine("Seu saldo em libra é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
                    break;
                case 4:
                    valorCarteiraTratado = valorCarteira * 1113.83m;
                    Console.WriteLine("Seu saldo em peso argentino é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")));
                    break;
            }
        }
        break;

    case 3:
        Console.WriteLine("Você escolheu Euro.");
        Console.WriteLine("Seu saldo atual é: ");
        Console.WriteLine(valorCarteira.ToString("C", CultureInfo.CreateSpecificCulture("de-DE")));

        Console.WriteLine("Você deseja converter o SALDO para outro tipo de moeda?");
        Console.WriteLine("1 - SIM");
        Console.WriteLine("2 - NÃO");

        opcaoo = int.Parse(Console.ReadLine());

        if (opcaoo == 1)
        {
            Console.WriteLine("Para qual moeda você deseja converter?");
            Console.WriteLine("1 - Real");
            Console.WriteLine("2 - Dólar");
            Console.WriteLine("3 - Libra");
            Console.WriteLine("4 - Peso Argentino");

            fluxoswitch = int.Parse(Console.ReadLine());

            switch (fluxoswitch)
            {
                case 1:
                    valorCarteiraTratado = valorCarteira / 0.16m;
                    Console.WriteLine("Seu saldo em real é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
                    break;
                case 2:
                    valorCarteiraTratado = valorCarteira / 0.89m;
                    Console.WriteLine("Seu saldo em dólar é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                    break;
                case 3:
                    valorCarteiraTratado = valorCarteira * 0.81m;
                    Console.WriteLine("Seu saldo em libra é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
                    break;
                case 4:
                    valorCarteiraTratado = valorCarteira * 1250.44m;
                    Console.WriteLine("Seu saldo em peso argentino é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")));
                    break;
            }
        }
        break;

    case 4:
        Console.WriteLine("Você escolheu Libra.");
        Console.WriteLine("Seu saldo atual é: ");
        Console.WriteLine(valorCarteira.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));

        Console.WriteLine("Você deseja converter o SALDO para outro tipo de moeda?");
        Console.WriteLine("1 - SIM");
        Console.WriteLine("2 - NÃO");

        opcaoo = int.Parse(Console.ReadLine());

        if (opcaoo == 1)
        {
            Console.WriteLine("Para qual moeda você deseja converter?");
            Console.WriteLine("1 - Real");
            Console.WriteLine("2 - Dólar");
            Console.WriteLine("3 - Euro");
            Console.WriteLine("4 - Peso Argentino");

            fluxoswitch = int.Parse(Console.ReadLine());

            switch (fluxoswitch)
            {
                case 1:
                    valorCarteiraTratado = valorCarteira / 0.13m;
                    Console.WriteLine("Seu saldo em real é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
                    break;
                case 2:
                    valorCarteiraTratado = valorCarteira / 0.72m;
                    Console.WriteLine("Seu saldo em dólar é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                    break;
                case 3:
                    valorCarteiraTratado = valorCarteira / 0.81m;
                    Console.WriteLine("Seu saldo em euro é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("de-DE")));
                    break;
                case 4:
                    valorCarteiraTratado = valorCarteira * 1400.00m;
                    Console.WriteLine("Seu saldo em peso argentino é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")));
                    break;
            }
        }
        break;

    case 5:
        Console.WriteLine("Você escolheu Peso Argentino.");
        Console.WriteLine("Seu saldo atual é: ");
        Console.WriteLine(valorCarteira.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")));

        Console.WriteLine("Você deseja converter o SALDO para outro tipo de moeda?");
        Console.WriteLine("1 - SIM");
        Console.WriteLine("2 - NÃO");

        opcaoo = int.Parse(Console.ReadLine());

        if (opcaoo == 1)
        {
            Console.WriteLine("Para qual moeda você deseja converter?");
            Console.WriteLine("1 - Real");
            Console.WriteLine("2 - Dólar");
            Console.WriteLine("3 - Euro");
            Console.WriteLine("4 - Libra");

            fluxoswitch = int.Parse(Console.ReadLine());

            switch (fluxoswitch)
            {
                case 1:
                    valorCarteiraTratado = valorCarteira / 200.49m;
                    Console.WriteLine("Seu saldo em real é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
                    break;
                case 2:
                    valorCarteiraTratado = valorCarteira / 1113.83m;
                    Console.WriteLine("Seu saldo em dólar é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                    break;
                case 3:
                    valorCarteiraTratado = valorCarteira / 1250.44m;
                    Console.WriteLine("Seu saldo em euro é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("de-DE")));
                    break;
                case 4:
                    valorCarteiraTratado = valorCarteira / 1400.00m;
                    Console.WriteLine("Seu saldo em libra é: ");
                    Console.WriteLine(valorCarteiraTratado.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
                    break;
            }
        }
        break;
}
