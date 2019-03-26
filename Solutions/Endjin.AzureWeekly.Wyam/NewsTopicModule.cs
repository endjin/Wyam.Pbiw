namespace Endjin.AzureWeekly.WyamModules
{
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Wyam.Common.Documents;
    using Wyam.Common.Execution;
    using Wyam.Common.Modules;

    public class NewsTopicsModule : IModule
    {
        private string newscollectionsFilePath;

        public NewsTopicsModule(string newscollectionsFilePath)
        {
            this.newscollectionsFilePath = newscollectionsFilePath;
        }

        public IEnumerable<IDocument> Execute(IReadOnlyList<IDocument> inputs, IExecutionContext context)
        {
            foreach (var filePath in Directory.EnumerateFiles(this.newscollectionsFilePath))
            {
                var newscollection = JsonConvert.DeserializeObject<NewsCollection>(File.ReadAllText(filePath));

                var metadata = new List<KeyValuePair<string, object>>
                {
                    new KeyValuePair<string, object>("NewsletterContent", newscollection.Newsletter),
                    new KeyValuePair<string, object>("NewsletterFrom", newscollection.FromDate),
                    new KeyValuePair<string, object>("NewsletterTo", newscollection.ToDate)
                };

                yield return context.GetDocument(metadata);
            }
        }
    }
}