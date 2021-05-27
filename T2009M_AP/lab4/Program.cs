namespace T2009M_AP.lab4
{
    public delegate void ShowResult(int num1, int num2);
    public class Program
    {
        public static ShowResult sr = new ShowResult(ExDelegate.ShowInfo);
        public static void Main(string[] args)
        {
            ExDelegate ed = new ExDelegate();
            sr += new ExDelegate().AddNumber;
            sr += new ExDelegate().SubNumber;
            sr += new ExDelegate().MulNumber;
            sr += new ExDelegate().DivNumber;
            sr(2, 4);
        }
    }
}