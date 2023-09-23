namespace Delegate
{
    delegate void Func(string str);
    internal class MyClass
    {
        public string Str { get; set; }
        public MyClass(string str) { Str = str; }
        public void Space(string Str)
        {

            string result = string.Join("_", Str.ToCharArray());
            Console.WriteLine(result);
        }

        public void Reverse(string Str)
        {
            char[] charArray = Str.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            Console.WriteLine(result);
        }
    }

    internal class Run
    {
        public void runFunc(Func func, string str)
        {

            func(str);
        }
    }
}
