using System;
using System.IO;
using System.IO.Compression;

namespace TributoPERU
{

    public class Descomprimir
    {
        public void DescomprimirArchivo(string ruta)
        {
            using (ZipArchive archive = ZipFile.OpenRead(ruta))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        if (File.Exists(Path.Combine(@"C:\Cargar", entry.FullName)))
                        {
                            File.Delete(Path.Combine(@"C:\Cargar", entry.FullName));
                        }
                        entry.ExtractToFile(Path.Combine(@"C:\Cargar", entry.FullName));
                    }
                }
            }
        }
    }
}