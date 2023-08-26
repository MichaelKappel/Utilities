using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration.Common.Models.ChatGpt4.Response
{
    public class ChatCompletionResponseDataModel
    {
        public string Id { get; set; } = string.Empty;
        public string Object { get; set; } = string.Empty;
        public int Created { get; set; } = 0;
        public string Model { get; set; } = string.Empty;
        public List<ChoiceDataModel> Choices { get; set; } = new List<ChoiceDataModel>();
        public UsageResponseDataModel Usage { get; set; } = new UsageResponseDataModel();
    }
}
