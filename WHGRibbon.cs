using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace WHGWordAddin
{
    public partial class WHGRibbon
    {
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void WHGRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, RibbonControlEventArgs e)
        {

        }

        private void connectionButton_Click(object sender, RibbonControlEventArgs e)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://dir-inc.org:8080");
            var request = new RestRequest("/webservice/GetGlossary", Method.GET);

            IRestResponse response = client.Execute(request);
            var r = JsonConvert.DeserializeObject<RootObject>(response.Content);
            //WHGApi api = new WHGApi();
            //var glossary = api.GetGlossary();
            //RibbonDropDownItem glos = Factory.CreateRibbonDropDownItem(); ;

            foreach (var item in r.json_category)
            {
               // MessageBox.Show(item.category);
                //glos.Label = item.category;
                //glos.Tag = item.id.ToString();
                RibbonDropDownItem thing = Globals.Factory.GetRibbonFactory().CreateRibbonDropDownItem();
                thing.Label = item.category;
                thing.Tag = item.id.ToString();
                glossaryBox.Items.Add(thing);
            }
            

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            var glossary = glossaryBox.Tag;
            MessageBox.Show("You pressed enter! Good job! " + glossary);
        }
    }
}
