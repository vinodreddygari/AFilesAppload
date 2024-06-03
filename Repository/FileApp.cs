using AFilesAppload.AppModels;
using AFilesAppload.Models;

namespace AFilesAppload.Repository
{
    public class FileApp
    {
        public static bool PostFile(IFormFile formFile) 
        {
            if (formFile.Length >0)
            {
                ApploadFile apploadFile = new ApploadFile()
                {
                    FileName = formFile.FileName,
                };
                using (var stream = new MemoryStream()) 
                {
                    formFile.CopyTo(stream);
                    apploadFile.Filedata = stream.ToArray();
                }
                Console.WriteLine("");
                TestContext testContext = new TestContext();
                testContext.ApploadFiles.Add(apploadFile);
                testContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
