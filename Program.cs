using System.Text;





//////////////////////////////////////
/*class Program
{
    static void Main(string[] args)
    {
        var texto = new StringBuilder();
        texto.Append("Este texto é um teste");
        texto.Append(" é um teste");
        texto.Append("Este texto");
        texto.Append("Este texto teste");
        texto.Append("Este um teste");

        Console.WriteLine(texto);
    }
}*/


///////////////////////////////////////
/*class Program
{
    static void Main(string[] args)
    {
        var texto = " Este texto é um teste ";
        Console.WriteLine(texto.Replace("e", "X"));

        var divisao = texto.Split(" ");
        Console.WriteLine(divisao[0]);
        Console.WriteLine(divisao[1]);
        Console.WriteLine(divisao[2]);
        Console.WriteLine(divisao[3]);

        var resultado = texto.Substring(5, 5);
        //var resultado = texto.Substring(5, texto.LastIndexOf("o"));
        Console.WriteLine(resultado);

        Console.WriteLine(texto.Trim());
    }
} */



//////////////////////////////////////
//class Program
//{
//    static void Main(string[] args)
//    {
//        var texto = "Este texto é um teste";
//        Console.WriteLine(texto.ToLower());
//        Console.WriteLine(texto.ToUpper());
//        Console.WriteLine(texto.Insert(5, "AQUI "));
//        Console.WriteLine(texto.Remove(5, 5));
//        Console.WriteLine(texto.Length);
//    }
//}




//class Program
//{
//    static void Main(string[] args)
//    {
//        var texto = "Este texto é um teste";
//        Console.WriteLine(texto.IndexOf("é"));// o Indexof mostra em que posição estar
//        Console.WriteLine(texto.IndexOf("um"));
//        Console.WriteLine(texto.LastIndexOf("s"));// o LastIndexOf mostra a posição do ultimo
//    }
//}




//////////////////////////////////////
//class Program
//{
//    static void Main(string[] args)
//    {
//        var texto = "Este texto é um teste";
//        Console.WriteLine(texto.Equals("Este texto é um teste"));
//        Console.WriteLine(texto.Equals("este texto é um teste"));
//        Console.WriteLine(texto.Equals("este texto é um Teste"));
//  }
//}




///////////////////////////////////////
//class Program
//{
//    static void Main (string[] args)
//    {
//        var texto = "Este texto é um teste";
//        // o "StartsWith" verifica se começa com aquela determinada cadeia de caracteres(SEMPRE RETORNA BOOLEANO)
//        Console.WriteLine(texto.StartsWith("Este"));
//        Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));//para ignorar as letras maiúsculas e minúscula 
//        Console.WriteLine(texto.StartsWith("texto"));
//
//        // o "EndsWith" verifica se termina com aquela determinada cadeia de caracteres
//        Console.WriteLine(texto.EndsWith("teste"));
//        Console.WriteLine(texto.EndsWith("Teste"));
//        Console.WriteLine(texto.EndsWith("xpro"));
//    }
//}



///////////////////////////////////////////

//class Program
//{
//    static void Main(string[] args)
//    {
//        var texto = "testando";
//        //Console.WriteLine(texto.CompareTo("Testando"));
//        //Console.WriteLine(texto.Contains("Testa", StringComparison.OrdinalIgnoreCase));
//        //Console.WriteLine(texto.Contains(null));//se comparar com nulo da erro
//    }
//}



///////////////////////////////////////

//class Program
//{
//    static void Main(string[] args)
//    {
//        var price = 10.2;
//        //var texto = "O preço do produto é " + price;
//        //var texto = string.Format("O preço do produto é {0} apenas na promoção", price);
//        var texto = $@"O preço do produto é {price} 
//        apenas na promoção";
//
//        Console.WriteLine(texto);
//    }
//}


/////////////////////////////////////

//class Program
//{
//    static void Main(string[] args)
//    {
//        var id = Guid.NewGuid();
//        id = new Guid();//quando usamos apenas "new Guid" os numeros gerados serão apenas 0
//
//        id.ToString();
//
//        Console.WriteLine(id.ToString().Substring(0,8));
//    }
//}