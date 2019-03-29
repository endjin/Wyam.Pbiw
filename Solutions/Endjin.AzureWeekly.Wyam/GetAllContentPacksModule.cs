namespace Endjin.AzureWeekly.WyamModules
{
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    using Wyam.Common.Documents;
    using Wyam.Common.Execution;
    using Wyam.Common.Modules;

    public class GetAllContentPacksModule : IModule
    {
        private string contentPackageDirectory;

        public GetAllContentPacksModule(string contentPackageDirectory)
        {
            this.contentPackageDirectory = contentPackageDirectory;
        }

        public IEnumerable<IDocument> Execute(IReadOnlyList<IDocument> inputs, IExecutionContext context)
        {
            var contentPackages = new List<ContentPackage>();

            foreach (var filePath in Directory.EnumerateFiles(this.contentPackageDirectory))
            {
                yield return context.GetDocument(new List<KeyValuePair<string, object>>
                {
                    new KeyValuePair<string, object>("ContentPackage", JsonConvert.DeserializeObject<ContentPackage>(File.ReadAllText(filePath))),
                });
            }
        }
    }
}