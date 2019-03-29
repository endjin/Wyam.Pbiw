namespace Endjin.AzureWeekly.WyamModules
{
    using System;
    using System.Collections.Generic;

    public class ContentPackage
    {
        public int Issue { get; set; }

        public string Editorial { get; set; }

        public DateTimeOffset FromDate { get; set; }

        public DateTimeOffset ToDate { get; set; }

        public List<Group> Groups { get; set; } = new List<Group>();
    }

    public class Group
    {
        public string Description { get; set; }

        public Guid Id { get; set; }

        public List<ContentItem> Items { get; set; } = new List<ContentItem>();

        public List<string> Keywords { get; set; } = new List<string>();

        public string Name { get; set; }

        public int Position { get; set; }
    }

    public class ContentItem
    {
        public string Content { get; set; }

        public Guid Id { get; set; }


    }
}