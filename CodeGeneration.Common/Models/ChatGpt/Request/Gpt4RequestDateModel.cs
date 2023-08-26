using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration.Common.Models.ChatGpt.Request
{
    public class Gpt4RequestDateModel
    {
        public string Model { get; set; } = string.Empty;
        public IList<Message> Messages { get; set; } = new List<Message>();
        public double Temperature { get; set; } = 0.0;
    }
}
