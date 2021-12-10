using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Downloader
{
    internal class WebsiteDataModel
    {
        public string WebsiteUrl { get; set; } = "";
        public string WebsiteData { get; set; } = "";
    }

    public partial class WebsiteDownloaderFRM : Form
    {
        private CancellationTokenSource s_cts = null;

        private static readonly IReadOnlyList<string> Websites = new List<string> { "https://google.com", "https://www.hotmail.com", "https://github.com/", "https://www.gmail.com/", "https://facebook.com", "https://www.microsoft.com", "https://www.samsung.com/", "https://www.yahoo.com/" };

        public WebsiteDownloaderFRM()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            cancelBTN.Enabled = false;
            downloadBTN.Enabled = !downloadBTN.Enabled;

            int count = 0;
            s_cts = new CancellationTokenSource();
            try
            {
                count = await RunGetParallelAsync(s_cts.Token);
                downloadBTN.Enabled = !downloadBTN.Enabled;
            }
            catch
            {
            }
            finally
            {
                textBox1.Text += $"Completed. {Environment.NewLine} Total Downloaded Content Lenght: {count}";
            }
        }

        private async Task<int> RunGetParallelAsync(CancellationToken cancellationToken)
        {
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();
            foreach (var item in Websites)
            {
                tasks.Add(GetWebsiteAsync(item, cancellationToken));
            }
            cancelBTN.Enabled = true;
            try
            {
                await Task.WhenAll(tasks);
            }
            catch
            {
            }
            return tasks.Where(x => x.IsCompletedSuccessfully).Sum(x => x.Result.WebsiteData?.Length) ?? 0;
        }

        private async Task<WebsiteDataModel> GetWebsiteAsync(string url, CancellationToken cancellationToken)
        {
            WebsiteDataModel output = new WebsiteDataModel();

            try
            {
                using HttpClient httpClient = new HttpClient(new HttpClientHandler
                {
                    Proxy = null,
                    UseProxy = false
                });
                output.WebsiteUrl = url;
                await Task.Delay(1200, cancellationToken); //  there are only 3 sites to be downloaded thats why I applied it here.
                var resp = await httpClient.GetAsync(url, cancellationToken);
                var string_resp = await resp.Content.ReadAsStringAsync();
                output.WebsiteData = string_resp;
                ReportWebsiteInfo(output);
            }
            catch (TaskCanceledException)
            {
                Invoke((MethodInvoker)delegate
                {
                    textBox1.Text += $"{ output.WebsiteUrl } download cancelled.{ Environment.NewLine }";
                });
            }
            return output;
        }

        private void ReportWebsiteInfo(WebsiteDataModel data)
        {
            Invoke((MethodInvoker)delegate
            {
                textBox1.Text += $"{ data.WebsiteUrl } downloaded: { data.WebsiteData.Length } characters long.{ Environment.NewLine }";
            });
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
          s_cts?.Cancel();
        }
    }
}