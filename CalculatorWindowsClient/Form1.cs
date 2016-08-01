using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorWindowsClient.CalculatorWcfService;
namespace CalculatorWindowsClient {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            CalculatorServiceClient proxy = new CalculatorServiceClient("NetTcpBinding_ICalculatorService");
            double x = Convert.ToSingle(textBox1.Text.ToString());
            double y = Convert.ToSingle(textBox2.Text.ToString());
            double rst = proxy.Add(x, y);
            label1.Text = rst.ToString();
        }
    }
}
