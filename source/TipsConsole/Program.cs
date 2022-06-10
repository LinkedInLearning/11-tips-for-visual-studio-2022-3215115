namespace TipsConsole {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine("Visualize IEnumerables while debugging.");

      var source = new DataLib.CardSource();
      var oddNumber = new List<int> { 1, 3,5,7,9};
      var mCards = source.MonsterCards;
      var aCards = source.AlienCards;

      Console.ReadLine();
    }
  }
}