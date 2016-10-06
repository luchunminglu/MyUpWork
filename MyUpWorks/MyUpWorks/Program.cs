using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyUpWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = ParseXml.Parse(@"<ApiResponse Status=""OK"" xmlns=""http://api.namecheap.com/xml.response"">
  <Errors />
  <Warnings />
  <RequestedCommand>namecheap.domains.check</RequestedCommand>
  <CommandResponse>
    <DomainCheckResult Domain=""google.com"" Available=""fAlse"" />
  </CommandResponse>
  <Server>WEB1-SANDBOX1</Server>
  <GMTTimeDifference>--4:00</GMTTimeDifference>
  <ExecutionTime>0.875</ExecutionTime>
</ApiResponse>
");
            Console.WriteLine(result);
        }
    }
}
