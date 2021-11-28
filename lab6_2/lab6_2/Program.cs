using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            string pathMkvFile = @"D:\Учёба\прог\hw_git\lab6_2\lab6_2\Media\MkvFile.Mkv";
            string pathMP3File = @"D:\Учёба\прог\hw_git\lab6_2\lab6_2\Media\MP3File.mp3";
            string pathWavFile = @"D:\Учёба\прог\hw_git\lab6_2\lab6_2\Media\WavFile.wav";
            string nameMkv = "MkvFile";
            string nameMP3 = "MP3File";
            string nameWav = "WavFile";
            if (File.Exists(pathMkvFile))
            {
                File.Delete(pathMkvFile);
            }
            if (File.Exists(pathMP3File))
            {
                File.Delete(pathMP3File);
            }
            if (File.Exists(pathWavFile))
            {
                File.Delete(pathWavFile);
            }
            File.Create(pathMkvFile).Dispose();
            File.Create(pathMP3File).Dispose();
            File.Create(pathWavFile).Dispose();
            Console.WriteLine("Файлы в папке Медиа: ");
            string[] massiveDirectories = new string[] { nameMkv, nameMP3, nameWav };
            foreach (string item in massiveDirectories)
            {
                Console.Write(item + "   ");
            }
            Console.WriteLine("");
            Console.WriteLine("Введите название файла для дальнейшей операции с ним");
            IMedia.name = Console.ReadLine();
            if (IMedia.name == "MkvFile")
            {
                IMedia.path = pathMkvFile;
                Console.WriteLine("Выберите действие(1,2,3): \n1. Play\n2. PauseP\n3. StopP");
                string action = Console.ReadLine();
                switch (action)
                {

                }
            }
            else if (IMedia.name == "MP3File")
            {
                IMedia.path = pathMP3File;
                Console.WriteLine("Выберите действие(1,2,3): \n1. Record\n2. PauseR\n3. StopR");
                string action = Console.ReadLine();
                switch (action)
                {

                }
            }
            else if (IMedia.name == "WavFile")
            {
                IMedia.path = pathWavFile;
                Console.WriteLine("Выберите действие(1,2,3): \n1. Play\n2. PauseP\n3. StopP\n4. Record\n5. PauseR\n6. StopR");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {

                }
            }
            
            PlayerItem pi = new PlayerItem();
        }
    }
}
