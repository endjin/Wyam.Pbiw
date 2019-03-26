namespace Endjin.AzureWeekly.WyamModules
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class NewsCollection
    {
        public Guid Id { get; set; }

        public Guid NewsTopicId { get; set; }

        public List<ProcessedArticle> Articles { get; set; }

        public DateTimeOffset FromDate { get; set; }

        public DateTimeOffset ToDate { get; set; }

        public Newsletter Newsletter { get; set; }

        public TweetCollection TweetCollection { get; set; }

        public List<ProcessedArticle> ExcludedArticles { get; set; }

        public DateTimeOffset LastUpdated { get; set; }
    }

    public class NewsletterItem
    {
        public Guid Id { get; set; }

        public Guid ArticleId { get; set; }

        [JsonIgnore]
        public ProcessedArticle Article { get; set; }

        public NewsletterItemContent Content { get; set; }

        public bool IsFeatured { get; set; }
    }

    public class NewsletterItemContent
    {
        public string Text { get; set; }

        public string Image { get; set; }

        public string ImageAltText { get; set; }

        public string Title { get; set; }

        public string Link { get; set; }
    }

    public class NewsletterDisplayItem
    {
        public Guid Id { get; set; }

        public List<Guid> NewsletterItemIds { get; set; }

        [JsonIgnore]
        public List<NewsletterItem> NewsletterItems { get; set; }

        public int OrderInCategory { get; set; }

        public Guid CategoryId { get; set; }

        public string Content { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        public string ImageAltText { get; set; }

        public string Link { get; set; }

        [JsonIgnore]
        public ArticleCategory Category { get; set; }

        public bool Ready { get; set; }
    }

    public class Newsletter
    {
        public IEnumerable<NewsletterItem> NewsletterItems { get; set; }

        public IEnumerable<NewsletterDisplayItem> NewsletterDisplayItems { get; set; }

        public int IssueNumber { get; set; }

        public bool IsPublished { get; set; }

        public string PublicationDateDescription { get; set; }

        public string Editorial { get; set; }
    }

    public class ProcessedArticle
    {
        private List<Exclusion> exclusions;

        public Guid Id { get; set; }

        public Guid? KnownAuthorId { get; set; }

        [JsonIgnore]
        public Author KnownAuthor { get; set; }

        public Guid CategoryId { get; set; }

        [JsonIgnore]
        public ArticleCategory Category { get; set; }

        public double CategoryScore { get; set; }

        public string Link { get; set; }

        public string Image { get; set; }

        public string ImageAltText { get; set; }

        public string Site { get; set; }

        public string Title { get; set; }

        public string Verb { get; set; }

        public string ArticleContent { get; set; }

        public bool AuthorNameIsInvalid { get; set; }

        public string SiteDescription { get; set; }

        public Guid FeedSourceId { get; set; }

        public string OriginalArticleId { get; set; }

        public string[] KeywordsMatched { get; set; }

        public string AuthorDisplayName { get; set; }

        public bool CategoryChanged { get; set; }

        public List<Exclusion> Exclusions
        {
            get
            {
                return this.exclusions ?? (this.exclusions = new List<Exclusion>());
            }
            set { this.exclusions = value; }
        }

    }


    public class TweetCollection
    {
        public bool IsPublished { get; set; }

        public IEnumerable<TweetItem> TweetItems { get; set; }
    }

    public class Exclusion
    {
        public string ArticleExclusionType { get; set; }

        public string Message { get; set; }
    }

    public class TweetItem
    {
        public Guid Id { get; set; }

        public Guid ArticleId { get; set; }

        public string TweetContent { get; set; }

        [JsonIgnore]
        public ProcessedArticle Article { get; set; }
    }

    public class ArticleCategory
    {
        private List<string> requiredClassificationTerms;
        private List<string> optionalClassificationTerms;
        private List<Guid> feedSources;

        public Guid Id { get; set; }

        public string Description { get; set; }

        public List<string> RequiredClassificationTerms
        {
            get { return this.requiredClassificationTerms ?? (this.requiredClassificationTerms = new List<string>()); }
            set { this.requiredClassificationTerms = value; }
        }

        public List<string> OptionalClassificationTerms
        {
            get { return this.optionalClassificationTerms ?? (this.optionalClassificationTerms = new List<string>()); }
            set { this.optionalClassificationTerms = value; }
        }

        public List<Guid> FeedSources
        {
            get { return this.feedSources ?? (this.feedSources = new List<Guid>()); }
            set { this.feedSources = value; }
        }

        public int Order { get; set; }

        public string LongDescription { get; set; }

        public Guid NewsTopicId { get; set; }

        protected bool Equals(ArticleCategory other)
        {
            return this.Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return this.Equals((ArticleCategory)obj);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public static bool operator ==(ArticleCategory left, ArticleCategory right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ArticleCategory left, ArticleCategory right)
        {
            return !Equals(left, right);
        }
    }

    public class Author
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string TwitterHandle { get; set; }

        public string JobTitle { get; set; }

        public List<string> Aliases { get; set; }

        public Guid NewsTopicId { get; set; }
    }
}