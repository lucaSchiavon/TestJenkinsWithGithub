using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJenkinsEFPipelines
{
    public class Manager
    {
        public string HelloWorld()
        {
            HelloWorldDTO helloWorldDto = new HelloWorldDTO()
            {
                Message = "Hello world",
                Other = "altro contenuto xxx ggg fff ooo and after"
        };
            string json = JsonConvert.SerializeObject(helloWorldDto, Formatting.Indented);
            return json;
        }
    }
}
