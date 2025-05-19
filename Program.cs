Console.Clear();
string resposta;


Console.WriteLine("O objeto está se movendo (S/N)?");
String movendo = Console.ReadLine()!.ToUpper().Substring(0, 1);

Console.WriteLine("Deveria(S/N)?");
string deveria = Console.ReadLine()!.ToUpper().Substring(0, 1);


if (movendo == "S" && deveria == "S")
{
  resposta = "ótimo";
  Console.WriteLine(resposta);
}
else if (movendo == "S" && deveria == "N")
{
  resposta = "Use Silver Tape.";
  Console.WriteLine(resposta);
}

else if (movendo == "N" && deveria == "N")
{
  resposta = "ótimo";
  Console.WriteLine(resposta);
}
else if (movendo == "N" && deveria == "S")
{
  resposta = "Use WD-40.";
  Console.WriteLine(resposta);
}
else {
 resposta = "Resposta Inválida";
 Console.WriteLine(resposta);
}

