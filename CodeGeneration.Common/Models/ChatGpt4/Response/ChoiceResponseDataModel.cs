using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGeneration.Common.Models.ChatGpt4;

namespace CodeGeneration.Common.Models.ChatGpt4.Response
{
    public class ChoiceDataModel
    {
        public int Index { get; set; } = 0;
        public MessageDataModel Message { get; set; } = new MessageDataModel();
        public string FinishReason { get; set; } = string.Empty;
    }
}
