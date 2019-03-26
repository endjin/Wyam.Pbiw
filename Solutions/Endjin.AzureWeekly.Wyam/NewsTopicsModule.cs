namespace Endjin.AzureWeekly.WyamModules
{
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Wyam.Common.Documents;
    using Wyam.Common.Execution;
    using Wyam.Common.Modules;

    public class NewsTopicModule : IModule
    {
        private string newscollectionFilePath;

        public NewsTopicModule(string newscollectionFilePath)
        {
            this.newscollectionFilePath = newscollectionFilePath;
        }

        public IEnumerable<IDocument> Execute(IReadOnlyList<IDocument> inputs, IExecutionContext context)
        {
            var newscollection = JsonConvert.DeserializeObject<NewsCollection>(File.ReadAllText(this.newscollectionFilePath));

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