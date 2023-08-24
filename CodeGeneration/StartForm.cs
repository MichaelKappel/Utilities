using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CodeGeneration
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            String textRaw = txtInput.Text;
            String inheritanceTextRaw = txtInheritance.Text;

            String[] words = Regex.Split(textRaw, @"\W+");


            TemplateTypes templateType = (TemplateTypes)ddlTemplate.SelectedItem;

            String directoryPath = "GeneratedCode";

            String templateRaw = txtTemplate.Text;

            foreach (String word in words)
            {
                if (String.IsNullOrWhiteSpace(word))
                {
                    continue;
                }
                String customTemplate = templateRaw;

                String propertyName = "name";

                if (templateType == TemplateTypes.InterfaceWithInheritance)
                {
                    String inheritanceText = Regex.Replace(inheritanceTextRaw, @"\{" + propertyName + @"\}", word);
                    customTemplate = Regex.Replace(customTemplate, @"\{inheritance\}", inheritanceText);
                }

                customTemplate = Regex.Replace(customTemplate, @"\{" + propertyName + @"\}", word);

                Directory.CreateDirectory(directoryPath);

                using (FileStream file = File.Create(this.GetFileName(directoryPath, txtPrefix.Text, word, templateType)))
                {
                    using (StreamWriter sw = new StreamWriter(file))
                    {
                        sw.Write(customTemplate);
                    }
                }
            }
        }

        public enum TemplateTypes
        {
            Interface,
            InterfaceWithInheritance,
            Model,
            DataModel,
            ViewModel
        }

        public String GetTemplate(TemplateTypes templateType)
        {
            String file = File.ReadAllText($@"Templates\{templateType}Template.txt");

            return file;
        }

        public String GetFileName(string directoryPath, String prefix, String fileName, TemplateTypes templateType)
        {
            if (!String.IsNullOrEmpty(prefix))
            {
                fileName = prefix.Trim() + fileName;
            }
            if (templateType == TemplateTypes.Interface || templateType == TemplateTypes.InterfaceWithInheritance)
            {
                fileName = $"I{fileName}.cs";
            }
            else
            {
                fileName = $"{fileName}{templateType}.cs";
            }

            return directoryPath + "/" + fileName;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            foreach (TemplateTypes template in Enum.GetValues(typeof(TemplateTypes)))
            {
                ddlTemplate.Items.Add(template);
            }
        }

        private void btnUpdateTemplate_Click(object sender, EventArgs e)
        {
            TemplateTypes selectedItem = (TemplateTypes)ddlTemplate.SelectedItem;

            String template = this.GetTemplate(selectedItem);

            String prefixText = txtPrefix.Text;
            if (!String.IsNullOrWhiteSpace(prefixText))
            {
                template = Regex.Replace(template, @"\{name\}", @$"{prefixText}{{name}}");
            }
            txtTemplate.Text = template;
        }

        private void btnAskAi_Click(object sender, EventArgs e)
        {

        }
    }
}
