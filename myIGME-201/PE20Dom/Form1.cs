using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            // if you want to use example.html from a local folder (saved in c:\temp for example):
            //this.webBrowser1.Navigate("c:\\temp\\example.html");

            // or if you want to use the URL  (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");


        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            htmlElement = webBrowser.Document.GetElementsByTagName("h1")[0];
            htmlElement.InnerText = "My UFO Page";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            htmlElementCollection[0].InnerText = "My UFO Info";
            htmlElementCollection[1].InnerText = "My UFO Pictures";
            htmlElementCollection[2].InnerText = "";

            htmlElement = webBrowser.Document.Body;
            htmlElement.Style = "color: #db1409;  font-family: sans-serif;";


            htmlElementCollection = webBrowser.Document.GetElementsByTagName("p");
            htmlElementCollection[0].InnerHtml = "Report your UFO sightings here: " + "<a href='http://www.nuforc.org'>www.nuforc.org</a>";
            htmlElementCollection[0].Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44";

            htmlElementCollection[1].InnerText = "";

            htmlElement = webBrowser.Document.CreateElement("img");
            htmlElement.SetAttribute("src", "https://media-cldnry.s-nbcnews.com/image/upload/newscms/2018_01/2280531/180103-ufo-illustration-mn-1015.jpg");
            htmlElement.SetAttribute("width", "500");
            htmlElementCollection[2].AppendChild(htmlElement);
            //webBrowser.Document.Body.AppendChild(htmlElement);
            //htmlElementCollection[2].InnerHtml = "<img src=''>";

            htmlElement = webBrowser.Document.CreateElement("footer");
            htmlElement.InnerHtml = "&copy 2023 Reva Sathe";

            webBrowser.Document.Body.AppendChild(htmlElement);
        }

    }
}
