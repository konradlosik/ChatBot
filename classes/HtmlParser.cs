//https://www.c-sharpcorner.com/UploadFile/9b86d4/getting-started-with-html-agility-pack/
namespace MyBot
{
    using HtmlAgilityPack;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    public class HtmlParser
    {
        public HtmlParser()
        {
            HtmlWeb web = new HtmlWeb();  
            HtmlDocument document = web.Load("http://www.c-sharpcorner.com");
            
            HtmlDocument document2 = new HtmlDocument();  
            document2.Load("file/sample.html"); 
            //HtmlNode[] nodes = document2.DocumentNode.SelectNodes("//a").ToArray();  
            //foreach (HtmlNode item in nodes)  
            //    Console.WriteLine(item.InnerHtml);  
            HtmlNode node = document2.DocumentNode.SelectNodes("//div[@id='div1']").First();
            //HtmlNode [] aNodes = node.SelectNodes(".//a").ToArray();  
            //Approach 2  
            //HtmlNode [] aNodes2 = document2.DocumentNode.SelectNodes("//div[@id='div1']//a").ToArray();

            HtmlNode[] nodes = document2.DocumentNode.SelectNodes("//a").Where(x=>x.InnerHtml.Contains("div2")).ToArray();  
            foreach (HtmlNode item in nodes)  
            {  
                Console.WriteLine(item.InnerHtml);  
            } 
        }
    }
}