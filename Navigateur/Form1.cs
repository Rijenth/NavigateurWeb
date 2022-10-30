using System.Security.Policy;

namespace Navigateur
{
    public partial class MainWindow : Form
    {
        public static readonly string FavoriPath = "BrowserFavori.txt";
        public static readonly string HistoryPath = "BrowserHistory.txt";
        public readonly List<string> _paths = new () { FavoriPath, HistoryPath };

        public MainWindow() {
            InitializeComponent();
            InitHomepage();
            InitToolStripMenuItem(_paths);
        }

        private void InitHomepage()
        {
            try
            {
                webBrowser.Navigate("google.fr");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        private void InitToolStripMenuItem(List<string> paths)
        {
            foreach (var path in paths)
            {
                if (!File.Exists(path))
                {
                    return;
                }

                ClearThisToolStripMenuItem(path);

                var urlFile = File.ReadAllLines(path);

                var urlList = new List<string>(urlFile);

                foreach (var url in urlList)
                {
                    ToolStripItem subItem = new ToolStripMenuItem(url);

                    subItem.Click -= DroppedDownItemClickedEvent;

                    subItem.Click += DroppedDownItemClickedEvent;

                    AddSubItemToThisToolStripMenuItem(subItem, path);
                }
            }
        }

        private void ClearThisToolStripMenuItem(string path)
        {
            if (path == FavoriPath)
            {
                favorisToolStripMenuItem.DropDownItems.Clear();
            }
            else if (path == HistoryPath)
            {
                historiqueToolStripMenuItem.DropDownItems.Clear();
            }
        }

        private void AddSubItemToThisToolStripMenuItem(ToolStripItem subItem, string path)
        {
            if (path == FavoriPath)
            {
                favorisToolStripMenuItem.DropDownItems.Add(subItem);
            }
            else if (path == HistoryPath)
            {
                historiqueToolStripMenuItem.DropDownItems.Add(subItem);
            }
        }

        private void DroppedDownItemClickedEvent(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;

            var url = menuItem.Text;

            NavigateToThis(url);
        }

        private void NavigateToThis(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute) && url != "")
            {
                webBrowser.Navigate(url);

                if (WebData.Storable(url, HistoryPath))
                {
                    WebData.StoreThis(url, HistoryPath);

                    var path = new List<string>() { HistoryPath };

                    InitToolStripMenuItem(path);
                };
            }
            else
            {
                MessageBox.Show(
                    "Vous n'avez pas saisi une URL valide.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ToHome(object sender, EventArgs e)
        {
            InitHomepage();
        }

        private void PreviousPageClick(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void fav_Click(object sender, EventArgs e)
        {
            string url = webBrowser.Url.ToString();

            if (WebData.Storable(url, FavoriPath))
            {
                string text = WebData.StoreThis(url, FavoriPath)
                    ? "Ce site a été enregistré dans vos favoris."
                    : "Une erreur est survenue. Ce site n'a pas été enregistré dans vos favoris.";

                MessageBox.Show(text, "Web", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var path = new List<string>() { FavoriPath };

                InitToolStripMenuItem(path);
            };
        }
        
        private void SearchClick(object sender, EventArgs e)
        {
            NavigateToThis(searchbar.Text);
        }

        private void NextPageClick(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void RefreshPageClick(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }
    }
}