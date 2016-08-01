﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CalculatorWcfService;

namespace CalculatorWcfServiceHost {
    class Program {
        static void Main(string[] args) {

            using (ServiceHost host = new ServiceHost(typeof(CalculatorService))) {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
