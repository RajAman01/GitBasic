using System;

namespace CatClass
{
    class cat
    {
        public string name;
        public int age;
        public string speak;

        public  cat(string _name,int _age)
        {
            name = _name;
            age = _age;
        }

        public void CastSpell()
        {
            Console.WriteLine(name + " " + age + "yr old" + "Speaks"+speak);
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cat cat01 = new cat();
            cat01.name = "foster";
            cat01.age = 20;
            cat01.speak = "Meawo";
            cat01.CastSpell();
        }
    }
}
