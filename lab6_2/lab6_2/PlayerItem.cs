using System;

class PlayerItem : IMedia
{
    public PlayerItem()
    {
        DisplayInfo();
    }
    public static void DisplayInfo()
    {
        Console.WriteLine("Директория файла: " + IMedia.path);
    }
}