//  #   Funktions Beschreibung der Konsolen Anwendung   #
//  #   Das Programm "OrdnerAuslesen" ließt die erste Ordner Ebene unter dem angegeben Verzeichnis (V:\Blu-ray-Filme) aus.    #
//  #   Dokumentation   #
//  #   Erfolgreicher durchlauf des Programms   #

using System;
using System.IO;

namespace OrdnerAuslesen
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Schleife durchsucht das Verzeichnis V:\Blu-ray-Filme nach dem ersten Unterordner

            foreach (string entry in Directory.GetDirectories(@"V:\Blu-ray-Filme"))
            {
                DisplayFileSystemInfoAttributes(new DirectoryInfo(entry));
            }
            //  Zeigt den Inhalt der Konsole an. 
            Console.ReadLine();
        }

        static void DisplayFileSystemInfoAttributes(FileSystemInfo fsi)
        {
            //  Schreibt den Namen des Ordners in die Konsole
            if ((fsi.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                Console.WriteLine(fsi.Name);
            }
        }

        
    }
}
