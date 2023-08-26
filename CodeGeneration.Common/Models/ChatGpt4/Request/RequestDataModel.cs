using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGeneration.Common.Models.ChatGpt4;

namespace CodeGeneration.Common.Models.ChatGpt4.Request
{
    public class RequestDataModel
    {
        public string Model { get; set; } = string.Empty;
        public IList<MessageDataModel> Messages { get; set; } = new List<MessageDataModel>();
        public double Temperature { get; set; } = 0.0;
    }
}