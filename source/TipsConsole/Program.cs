namespace TipsConsole {
  internal class Program {
    static void Main(string[] args) {

      Console.WriteLine("Suppress build dialog.");
      var source = new DataLib.CardSource();
      var oddNumber = new List<int> { 1, 3, 5, 7, 9 };

      oddNumber.ForEach(x => Console.WriteLine(x));
      Console.ReadLine();
    }
  }
}