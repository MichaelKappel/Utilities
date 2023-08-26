using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration.Common.Models.ChatGpt.Response
{
    public class ChatCompletion
    {
        public string Id { get; set; } = string.Empty;
        public string Object { get; set; } = string.Empty;
        public int Created { get; set; } = 0;
        public string Model { get; set; } = string.Empty;
        public List<Choice> Choices { get; set; } = new List<Choice>();
        public Usage Usage { get; set; } = new Usage();
    }
}
