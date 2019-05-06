using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swapi.Data.Helpers;
using Swapi.Data.Contracts;
using System.Threading.Tasks;
using System.IO;

namespace Swapi.Data.Tests
{
    [TestClass]
    public class FileHelperTests
    {
        [TestMethod]
        public async Task SaveFile_ValidData_ReturnsTrue()
        {
            IFileHelper _fileHelper = new FileHelper();
            bool exptected = true; 

            string path = @"D:\Starwars\tests";
            string name = "test.txt";
            string content = "some mock data for testing";

            bool actual = await _fileHelper.SaveFile(path, name, content);
            Assert.AreEqual(exptected, actual);
        }

        [TestMethod]
        public async Task SaveFile_ConfirmFileCreation_ReturnsTrue()
        {
            IFileHelper _fileHelper = new FileHelper();
            bool exptected = true;

            string path = @"D:\Starwars\tests";
            string name = "test.txt";
            string content = "some mock data for testing";

            File.Delete($@"{path}\{name}");

            bool save = await _fileHelper.SaveFile(path, name, content);

            bool actual = File.Exists($@"{path}\{name}");
            Assert.AreEqual(exptected, actual);
        }
    }
}
