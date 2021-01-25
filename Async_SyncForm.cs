using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormServer {
    public partial class Async_SyncForm : Form {
        public Async_SyncForm() {
            InitializeComponent();
        }

        private void SyncButton_Click(object sender, EventArgs e) {
            Console.WriteLine("Sync start");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            RunDownloadSync();
            watch.Stop();
            var time = watch.ElapsedMilliseconds;
            Console.WriteLine("Time used in Sync {0} ms", time);
        }

        private async void AsyncButton_Click(object sender, EventArgs e) {
            Console.WriteLine("Async start");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //await RunDownloadParallelAsync();
            await RunDownloadAsync();
            watch.Stop();
            var time = watch.ElapsedMilliseconds;
            Console.WriteLine("Time used in Async {0} ms", time);
        }
        private async void ParallelAsyncButton_Click(object sender, EventArgs e) {
            Console.WriteLine("Parallel Async start");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await RunDownloadParallelAsync();
            watch.Stop();
            var time = watch.ElapsedMilliseconds;
            Console.WriteLine("Time used in Parallel Async {0} ms", time);
        }

        private List<string> PrepData() {
            List<string> outout = new List<string>();
            textBox1.Text = "";
            outout.Add("https://boesgaard.dk");
            outout.Add("https://yahoo.com");
            outout.Add("https://google.com");
            outout.Add("https://microsoft.com");
            outout.Add("https://codeproject.com");
            outout.Add("https://stackoverflow.com");
            return outout;
        }

        // sync doing only this task, GUI locked
        public void RunDownloadSync() {
            List<string> websites = PrepData();
            foreach (string site in websites) { // runing for each webside, lock gui until done
                WebsiteDataModel res = DownloadWebsite(site); // do this task and then the next task. only main thread working
                ReportWebsiteInfo(res);
            }
        }

        private WebsiteDataModel DownloadWebsite(string websiteURL) {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient Cli = new WebClient();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            output.WebsiteUrl = websiteURL;
            output.WebsiteData = Cli.DownloadString(websiteURL);
            watch.Stop();
            output.Downloadtime = watch.ElapsedMilliseconds;
            return output;
        }

        private void ReportWebsiteInfo(WebsiteDataModel res) {
            textBox1.Text += $"{ res.WebsiteUrl} downloaded : {res.WebsiteData.Length} characters long. MS : {res.Downloadtime} { Environment.NewLine} ";
        }

        //Async can move Gui and see result coming running
        public async Task RunDownloadAsync() { // still waiting the length of the sum of download time
            List<string> websites = PrepData();
            foreach (string site in websites) { 
                WebsiteDataModel res = await Task.Run(() => DownloadWebsite(site)); //start do this task and wait for it. then next foreach repert.
                ReportWebsiteInfo(res);
            }
        }
        //Async can move Gui and see result coming running
        public async Task RunDownloadParallelAsync() { // start a Task for each task there is
            List<string> websites = PrepData();
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();
            foreach (string site in websites) {
                tasks.Add(Task.Run(() => DownloadWebsite(site))); // start do this task. then next foreach repert
            }
            var resTasks = await Task.WhenAll(tasks); // wait for all task in list<task> to be done

            foreach (var item in resTasks) {
                ReportWebsiteInfo(item);
            }
        }

    }

    public class WebsiteDataModel {
        public string WebsiteUrl { get; set; } = "";
        public string WebsiteData { get; set; } = "";
        public long Downloadtime { get; set; } = 0;
    }
}
