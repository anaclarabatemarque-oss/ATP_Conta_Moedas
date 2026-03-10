 int qntmoedas1, qntmoedas50, qntmoedas25, qntmoedas10;
 double total1, total50, total25, total10, totalGeral;

    Console.Write("Informe quantas moedas de R$ 1,00 você tem: ");
    qntmoedas1 = int.Parse(Console.ReadLine());
    Console.Write("Informe quantas moedas de R$ 0,50 você tem: ");
    qntmoedas50 = int.Parse(Console.ReadLine());
    Console.Write("Informe quantas moedas de R$ 0,25 você tem: ");
    qntmoedas25 = int.Parse(Console.ReadLine());
    Console.Write("Informe quantas moedas de R$ 0,10 você tem:");
    qntmoedas10 = int.Parse(Console.ReadLine());

    total1 = qntmoedas1 * 1;
    total50 = qntmoedas50 * 0.50;
    total25 = qntmoedas25 * 0.25;
    total10 = qntmoedas10 * 0.10;
    totalGeral = total1 + total50 + total25 + total10;

    Console.WriteLine(" O valor total de moedas no cofre é: R$ " + totalGeral);

