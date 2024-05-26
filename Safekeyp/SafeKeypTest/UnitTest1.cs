using CypherWithGuna.Forms;

namespace SafeKeypTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var app = new EncryptUserControl(); // Instantiate your user control or encryption class
            List<string> failedPaths = new List<string>(); // To store paths that fail encryption

            // Read the text file containing paths
            string[] paths = File.ReadAllLines("paths.txt"); // Adjust the file name as needed

            // Act
            foreach (string path in paths)
            {
                if(string.IsNullOrWhiteSpace(path))
                    continue;
                // Generate output file path based on the input path
                string outputFile = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + "_encrypted" + Path.GetExtension(path));

                // Encrypt the file
                try
                {
                    byte[] key = new byte[] { 0x01, 0x02, 0x03 }; // Sample key
                    byte[] iv = new byte[] { 0x04, 0x05, 0x06 }; // Sample IV
                    app.EncryptFile(path, key, iv);
                }
                catch
                {
                    // If encryption fails, record the path
                    failedPaths.Add(path);
                }
            }

            // Assert
            if (failedPaths.Count == 0)
            {
                // All paths were successfully encrypted
                Assert.IsTrue(true); // You can provide a meaningful assertion here
            }
            else
            {
                // Some paths failed encryption
                Assert.Fail($"Encryption failed for the following paths: {string.Join(", ", failedPaths)}");
            }
        }
    }
}