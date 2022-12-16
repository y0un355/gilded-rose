using GildedRose;

internal class Program
{
    private static void Main(string[] args)
    {
        var shop = new Shop(new FileItemsRepository());
        shop.UpdateQuality();
    }
}
