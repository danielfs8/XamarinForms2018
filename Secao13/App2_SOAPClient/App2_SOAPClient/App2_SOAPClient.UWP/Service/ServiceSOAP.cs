using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly:Xamarin.Forms.Dependency(typeof(App2_SOAPClient.UWP.Service.ServiceSOAP))]
namespace App2_SOAPClient.UWP.Service
{
    public class ServiceSOAP : IServiceSOAP
    {
        public string Somar(int num1, int num2)
        {
            var Serv = new ServiceWS.CalculatorSoapClient();
            var resposta = Serv.AddAsync(num1, num2).GetAwaiter().GetResult();

            return "Servico UWP: " + resposta;
        }
    }
}
