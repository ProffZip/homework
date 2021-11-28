using System;

public interface IPlayable
{
    void Play() 
    {
        Console.WriteLine("Playing " + IMedia.name);
    }
    void PauseP();
    void StopP();
}