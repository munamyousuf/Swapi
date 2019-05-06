using Swapi.Data.Contracts;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Swapi.Data.Helpers
{
    public class FileHelper : IFileHelper
    {
        public async Task<bool> SaveFile(string path, string name, string content)
        {
            try
            {
                bool isSuccess;
                FileInfo file = new FileInfo($@"{path}\{name}");
                file.Directory.Create();
                FileStream fs = file.Open(FileMode.Append, FileAccess.Write, FileShare.Read);

                using (StreamWriter sw = new StreamWriter(fs))
                {
                    await sw.WriteLineAsync($"{DateTime.Now.ToString("yyyyMMdd hh:mm tt")}\n{content}");
                    isSuccess = true;
                };
                return isSuccess;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
