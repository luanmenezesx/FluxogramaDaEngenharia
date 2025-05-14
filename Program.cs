Console.Clear();
string resposta; 


Console.WriteLine("O objeto está se movendo (S/N)?");
bool movendo = Console.ReadLine()!.ToUpper().Substring(0, 1) == "S";

Console.WriteLine("Deveria(S/N)?");
bool deveria = Console.ReadLine()!.ToUpper().Substring(0, 1) == "N";


if (!movendo)
{

    if(!deveria)
    {
        resposta = "ótimo";
        Console.WriteLine(resposta);
   } 
   else
   {
    resposta = "Use WD-40.";
     Console.WriteLine(resposta);
   }
}
else
{
      if(!deveria)
    {
        resposta = "ótimo";
        Console.WriteLine(resposta);
   } 
   else
   {
    resposta = "Use Silver Tape.";
    Console.WriteLine(resposta);

   }
}

