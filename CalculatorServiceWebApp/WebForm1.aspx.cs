using CalculatorServiceWebApp.CalculatorWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorServiceWebApp {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void button1_Click(object sender, EventArgs e) {
            // We have two endpoints in the web.config. We need to speicy which one we want to use.
            CalculatorServiceClient proxy = new CalculatorServiceClient("BasicHttpBinding_ICalculatorService");
            double x = Convert.ToSingle(textBox1.Text.ToString());
            double y = Convert.ToSingle(textBox2.Text.ToString());
            double rst = proxy.Add(x, y);
            label1.Text = rst.ToString();
        }
    }
}