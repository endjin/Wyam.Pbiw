namespace Endjin.AzureWeekly.WyamModules
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using Wyam.Common.Documents;
    using Wyam.Common.Execution;
    using Wyam.Common.Modules;

    public class GetContentPackagesForFrontPage : IModule
    {
        private string contentPackageDirectory;

        public GetContentPackagesForFrontPage(string contentPackageDirectory)
        {
            this.contentPackageDirectory = contentPackageDirectory;
        }

        public IEnumerable<IDocument> Execute(IReadOnlyList<IDocument> inputs, IExecutionContext context)
        {
            var contentPackages = new List<ContentPackage>();

            foreach (var filePath in Directory.EnumerateFiles(this.contentPackageDirectory))
            {
                contentPackages.Add(JsonConvert.DeserializeObject<ContentPackage>(File.ReadAllText(filePath)));
            }

            var metadata = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("ContentPackages", contentPackages.OrderByDescending(x => x.Issue).Take(4)),
            };

            yield return context.GetDocument(metadata);
        }
    }
}