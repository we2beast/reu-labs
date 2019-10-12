using System;
using System.Security.Cryptography;
using System.Text;

namespace Human
{
    public class Teenager: Man
    {
        private int age;
        private string name;

        public override int Age
        {
            get { return age; }
            set {
                if (value >= 13 && value <= 19) age = value;
                else throw new Exception("Age error");
            }
        }

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Teenager(Teenager previous) : base(previous)
        {
        }

        public Teenager(string Name, int Age) : base(Name, Age)
        {
        }

        public Teenager()
        {
            name = "Неизвестно"; age = 18;
        }

        public override string ToString()
        {
            return $"Teenager {name} {age}";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Teenager);
        }

        public override int GetHashCode()
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(Name));

            return hash.Length;
        }

    }
}
