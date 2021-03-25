using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace STD_Interfaces_Hometask
{
    struct Article
    {
        public ushort CodeProduct;
        public string NameProduct;
        public uint Price;
        public enum TypeProduct { Phone, Laptop, Tablet };
        private TypeProduct type;
        public Article(ushort code, string name, uint price, TypeProduct type)
        {
            this.CodeProduct = code;
            this.NameProduct = name;
            this.Price = price;
            this.type = type;
        }
    }
    class Client : IComparable, IComparer<Client>
    {
        public ushort CodeClient { get; }
        public String ShortName { get; }
        public String Adress { get; }
        public int Number { get; set; }
        public uint AmountProduct;
        public Client(ushort code, string name, string adress, int number)
        {
            this.CodeClient = code;
            this.ShortName = name;
            this.Adress = adress;
            this.Number = number;
        }
        public override string ToString()
        {
            return $"Code product - {CodeClient}\n" +
                $"Short name - {ShortName}\n" +
                $"Adress - {Adress}\n" +
                $"Number - {Number}";

        }

        public int CompareTo(object obj)
        {
            return this.ShortName.CompareTo(((Client)(obj)).ShortName);
        }

        public int Compare([AllowNull] Client x, [AllowNull] Client y)
        {
            return x.AmountProduct.CompareTo(y.AmountProduct);
        }
    }
    struct RequestItem : ICloneable
    {
        public Article article;
        public uint AmountProduct { get; set; }
        public RequestItem(Article article, uint amount)
        {
            this.article = article;
            this.AmountProduct = amount;
        }

        public object Clone()
        {
            return new RequestItem(this.article,this.AmountProduct);
        }
    }
    struct Request
    {
        public ushort CodeProduct;
        public Client client;
        public DateTime date;
        public List<RequestItem> OrderProduct;
        public readonly uint Sum => Sum;
        public Request(ushort code, DateTime data, Client client)
        {
            this.CodeProduct = code;
            this.date = data;
            this.client = client;
            OrderProduct = new List<RequestItem>();
        }

        public void AddRequest(Article article, uint amount)
        {
            OrderProduct.Add(new RequestItem(article, amount));
            client.AmountProduct += 1;
            Console.WriteLine(client);
        }
        public void RemoveRequest(Article article, uint amount)
        {
            OrderProduct.Remove(new RequestItem(article, amount));
            client.AmountProduct -= 1;
            Console.WriteLine(client);
        }
        public void RenderRequest()
        {
            foreach (var item in OrderProduct)
            {
                Console.WriteLine(item);
            }
        }
    }
}