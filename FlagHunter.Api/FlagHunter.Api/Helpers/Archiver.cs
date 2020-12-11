using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Tar;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.CodeAnalysis;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FlagHunter.Api.Helpers
{
    public static class Archiver
    {
        public static Guid CreateTar(string sourceDirectory)
        {
            var currentDirectory = Environment.CurrentDirectory.ToString();
            var projectDirectory = currentDirectory;
            for (int i = 0; i < 2; i++)
            {
                projectDirectory = Directory.GetParent(projectDirectory).FullName;
            }
            projectDirectory += "\\" + sourceDirectory;
            var tarId = Guid.NewGuid();
            // Creating the tar file for creating the new Docker image
            string tarOutFn = @"../../" + tarId + ".tar.gz";
            Stream outStream = File.Create(tarOutFn);
            TarOutputStream tarOutputStream = new TarOutputStream(outStream);

            CreateTarManually(tarOutputStream, projectDirectory, projectDirectory);

            tarOutputStream.Close();
            outStream.Close();

            return tarId;
        }

        private static void CreateTarManually(TarOutputStream tarOutputStream, string sourceDirectory, string basePath)
        {   
            TarEntry tarEntry = TarEntry.CreateEntryFromFile(sourceDirectory);
            tarOutputStream.PutNextEntry(tarEntry);

            // Write each file to the tar.
            string[] filenames = Directory.GetFiles(sourceDirectory);

            foreach (string filename in filenames)
            {

                using (Stream inputStream = File.OpenRead(filename))
                {
                    var tarName = filename.Replace(basePath + '\\', "");

                    long fileSize = inputStream.Length;

                    TarEntry entry = TarEntry.CreateTarEntry(tarName);

                    entry.Size = fileSize;

                    // Add the entry to the tar stream, before writing the data.
                    tarOutputStream.PutNextEntry(entry);

                    // this is copied from TarArchive.WriteEntryCore
                    byte[] localBuffer = new byte[32 * 1024];
                    while (true)
                    {
                        int numRead = inputStream.Read(localBuffer, 0, localBuffer.Length);
                        if (numRead <= 0)
                            break;

                        tarOutputStream.Write(localBuffer, 0, numRead);
                    }
                }
                tarOutputStream.CloseEntry();
            }

            string[] directories = Directory.GetDirectories(sourceDirectory);
            foreach (string directory in directories)
                CreateTarManually(tarOutputStream, directory, basePath);
        }
    }
}
