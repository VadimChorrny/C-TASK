using System;

namespace STD_Interfaces_Hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(1234,"Bill Gates","USA,NewYork,Brighton Beach",3495543);
            Request request = new Request(10,new DateTime(2021,03,25),client);
            Article article = new Article(10,"IPad Pro",2800,Article.TypeProduct.Tablet);
            request.AddRequest(article,12);
            //request.AddRequest(new Article(5,"MacBook Air",35000,Article.TypeProduct.Laptop),12);
            //request.AddRequest(new Article(15,"Iphone 11",19500,Article.TypeProduct.Phone),12);
            Client clients = new Client(1235, "Elon Mask", "USA,Californiya", 13435231);
            Article articles = new Article(1, "MacBook Pro", 88000, Article.TypeProduct.Laptop);
            request.AddRequest(articles, 10);
            Console.WriteLine(client);
            Console.WriteLine(clients);

            //Client client = new Client(100,"Vova","Ukraine",38094245);
            //Console.WriteLine(client);
        }
    }
}
