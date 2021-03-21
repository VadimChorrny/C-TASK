using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STD_Interfaces_Hometask
{
    struct Article
    {
        public ushort CodeProduct;
        public string NameProduct;
        public uint Price;
        enum TypeProduct { Phone, Laptop, Tablet };
    }
    class Client
    {
        public ushort CodeClient { get; }
        public String ShortName { get; }
        public String Adress { get; }
        public String Number
        {
            get => Number;
            set
            {
                string tmp = value.Remove(0, 1);
                if (tmp.All(c => char.IsDigit(c)) && value[0] == '+')
                {
                    this.Number = value;
                }
                else
                {
                    throw new Exception("Client number dont correct!");
                }
            }
        }
        public uint AmountProduct { get; }
    }
    struct RequestItem
    {
        public Article Product;
        public uint AmountProduct { get; }

    }
    struct Request
    {
        public ushort CodeProduct;
        public Client client;
        public DateTime date;
        public List<RequestItem> OrderProduct;
        public readonly uint Sum { get; }

    }
}
