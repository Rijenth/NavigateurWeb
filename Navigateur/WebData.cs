using System.Windows.Forms;

namespace Navigateur
{
    internal class WebData : MainWindow
    {
        public static bool AlreadyExist(string url, string path)
        {
            if (!File.Exists(path))
            {
                return false;
            }

            return File.ReadAllText(path).Contains(url);
        }
        public static bool Storable(string url, string path)
        {
            if (AlreadyExist(url, path))
            {
                if (path == FavoriPath)
                {
                    MessageBox.Show("Ce site est déjà présent dans vos favoris.", "Web", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return false;
            }
            return true;
        }
        public static bool StoreThis(string data, string path)
        {
            bool success = false;

            try
            {
                using (var file = new StreamWriter(path, true))
                {
                    file.WriteLine(data);

                    success = true;
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return success;
        }
    }
}

