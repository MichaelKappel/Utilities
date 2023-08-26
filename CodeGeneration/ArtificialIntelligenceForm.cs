using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Net.WebRequestMethods;
using CodeGeneration.Common.Models.ChatGpt4;
using CodeGeneration.Common.Models.ChatGpt4.Request;
using CodeGeneration.Common.Models.ChatGpt4.Response;

namespace CodeGeneration
{
    public partial class ArtificialIntelligenceForm : Form
    {
        public ArtificialIntelligenceForm()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void PopulateTreview(ChatCompletionResponseDataModel chatCompletion)
        {
            // Populate the TreeView control
            TreeNode rootNode = new TreeNode("Chat Completion");
            rootNode.Nodes.Add($"ID: {chatCompletion.Id}");
            rootNode.Nodes.Add($"Object: {chatCompletion.Object}");
            rootNode.Nodes.Add($"Created: {chatCompletion.Created}");
            rootNode.Nodes.Add($"Model: {chatCompletion.Model}");

            TreeNode choicesNode = new TreeNode("Choices");
            foreach (var choice in chatCompletion.Choices)
            {
                TreeNode choiceNode = new TreeNode($"Choice {choice.Index}");
                choiceNode.Nodes.Add($"Role: {choice.Message.Role}");
                choiceNode.Nodes.Add($"Content: {choice.Message.Content}");
                choiceNode.Nodes.Add($"Finish Reason: {choice.FinishReason}");
                choicesNode.Nodes.Add(choiceNode);
            }
            rootNode.Nodes.Add(choicesNode);

            TreeNode usageNode = new TreeNode("Usage");
            usageNode.Nodes.Add($"Prompt Tokens: {chatCompletion.Usage.PromptTokens}");
            usageNode.Nodes.Add($"Completion Tokens: {chatCompletion.Usage.CompletionTokens}");
            usageNode.Nodes.Add($"Total Tokens: {chatCompletion.Usage.TotalTokens}");
            rootNode.Nodes.Add(usageNode);

            tvResponse.Nodes.Add(rootNode);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string apiKey = txtChatGptKey.Text;

            string apiUrl = "https://api.openai.com/v1/chat/completions";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                RequestDataModel requestData = new RequestDataModel
                {
                        Model = "gpt-4",
                        Messages = new MessageDataModel[] {
                        new MessageDataModel
                        {
                            Role = "user",
                            Content = txtQuestion.Text,
                        }
                    },
                    Temperature = 0.7
                };
                HttpResponseMessage response;
                try
                {
                     response = client.PostAsJsonAsync(apiUrl, requestData).Result;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return;
                }

                if (response.IsSuccessStatusCode)
                {
                    ChatCompletionResponseDataModel chatCompletion = response.Content.ReadFromJsonAsync<ChatCompletionResponseDataModel>().Result!;
                    PopulateTreview(chatCompletion);

                    String resultText = String.Empty; 
                    foreach (ChoiceDataModel choice in chatCompletion.Choices)
                    {
                        resultText += choice.Message.Content;
                    }

                    txtAnswer.Text = resultText;
                }
                else
                {
                    Console.WriteLine($"Request failed with status code: {response.StatusCode}");
                    string errorResponse = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine($"Error response: {errorResponse}");
                }
            }
        }
    }
}
