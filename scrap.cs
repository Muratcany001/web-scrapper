using HtmlAgilityPack;
using System;
using System.Net.Http;

namespace WebScraper
{
    class Program
    {
        static void Main(String[] args)
        {
            String url = "VERDİĞİNİZ_SITE_URL";
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url).Result;
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var tarihElement = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='ctl00_MPane_m_976_12510_ctnr_m_976_12510_kupaMaclari_ctl01_lblTarih']");
            var tarih = tarihElement?.InnerText.Trim() ?? "Tarih bulunamadı";
            Console.WriteLine("Tarih: " + tarih);
            var takim1Element = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='ctl00_MPane_m_976_12510_ctnr_m_976_12510_kupaMaclari_ctl01_lblTakim1']");
            var takim1 = takim1Element?.InnerText.Trim() ?? "Takım 1 bulunamadı";
            Console.WriteLine("Takım 1: " + takim1);
            var takim2Element = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='ctl00_MPane_m_976_12510_ctnr_m_976_12510_kupaMaclari_ctl01_lblTakim2']");
            var takim2 = takim2Element?.InnerText.Trim() ?? "Takım 2 bulunamadı";
            Console.WriteLine("Takım 2: " + takim2);
            var skorElement = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='ctl00_MPane_m_976_12510_ctnr_m_976_12510_kupaMaclari_ctl01_lblSkor']");
            var skor = skorElement?.InnerText.Trim() ?? "Skor bulunamadı";
            Console.WriteLine("Skor: " + skor);
        }
    }
}
