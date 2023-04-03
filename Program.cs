decimal valorDoCarro, valorPago, valorJuros;

Console.WriteLine("--- Troco ---\n");

Console.Write("Valor da carro (R$)...: ");
valorDoCarro = Convert.ToDecimal(Console.ReadLine());

Console.Write("Valor Pago (R$)........: ");
valorPago = Convert.ToDecimal(Console.ReadLine());

valorJuros = valorPago - valorDoCarro;

Console.WriteLine($"\nJuros: {valorJuros:C}");
