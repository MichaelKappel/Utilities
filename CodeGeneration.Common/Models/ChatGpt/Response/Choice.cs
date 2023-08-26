using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration.Common.Models.ChatGpt.Response
{
    public class Choice
    {
        public int Index { get; set; } = 0;
        public Message Message { get; set; } = new Message();
        public string FinishReason { get; set; } = string.Empty;
    }
}
