using BloodBank.Classes;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Scraping
    {
        public static List<Hastane> GetHospitalsİnİstanbul()
        {
            List<Hastane> hastanes = new List<Hastane>();
			var html = @"http://www.istanbulhastaneleri.net/devlet-hastaneleri.html";
			HtmlWeb web = new HtmlWeb();
			var htmlDoc = web.Load(html);
			var node = htmlDoc.DocumentNode.SelectNodes("//div[@class='list']/div[@class='item']");
			foreach (var a in node)
			{
                if (a.ChildNodes.Contains(a.SelectSingleNode(".//div[@class='district']")))
                {
                    string b = a.SelectSingleNode(".//div[@class='district']").InnerText;
                    b.Trim();
                    string sub = b.Substring(b.IndexOf(':') + 1, b.Length - b.IndexOf(':') - 1);
                    İlçeler ilçe=(İlçeler)Enum.Parse(typeof(İlçeler), sub.Trim(),true);
                    string t = a.SelectSingleNode(".//h2[@class='name third-title']").InnerText;
                    Hastane hastane = new Hastane(t.Trim(),ilçe);
                    hastanes.Add(hastane);
                }
			}
            html = @"http://www.istanbulhastaneleri.net/ozel-hastaneler.html";
            htmlDoc = web.Load(html);
            node= htmlDoc.DocumentNode.SelectNodes("//div[@class='list']/div[@class='item']");
            foreach (var a in node)
            {
                if (a.ChildNodes.Contains(a.SelectSingleNode(".//div[@class='district']")))
                {
                    string b = a.SelectSingleNode(".//div[@class='district']").InnerText;
                    b.Trim();
                    string sub = b.Substring(b.IndexOf(':') + 1, b.Length - b.IndexOf(':') - 1);
                    İlçeler ilçe = (İlçeler)Enum.Parse(typeof(İlçeler), sub.Trim(),true);
                    string t = a.SelectSingleNode(".//h2[@class='name third-title']").InnerText;
                    Hastane hastane = new Hastane(t.Trim(), ilçe);
                    hastanes.Add(hastane);
                }
            }
            html = @"http://www.istanbulhastaneleri.net/universite-hastaneleri.html";
            htmlDoc = web.Load(html);
            node = htmlDoc.DocumentNode.SelectNodes("//div[@class='list']/div[@class='item']");
            foreach (var a in node)
            {
                if (a.ChildNodes.Contains(a.SelectSingleNode(".//div[@class='district']")))
                {
                    string b = a.SelectSingleNode(".//div[@class='district']").InnerText;
                    b.Trim();
                    string sub = b.Substring(b.IndexOf(':') + 1, b.Length - b.IndexOf(':') - 1);
                    İlçeler ilçe = (İlçeler)Enum.Parse(typeof(İlçeler), sub.Trim(),true);
                    string t = a.SelectSingleNode(".//h2[@class='name third-title']").InnerText;
                    Hastane hastane = new Hastane(t.Trim(), ilçe);
                    hastanes.Add(hastane);
                }
            }
            return hastanes;
        }
    }
}
