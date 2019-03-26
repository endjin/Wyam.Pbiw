# Overview

I'm trying to use Wyam to generate a static site for the Azure Weekly Newsletter: http://azureweekly.info.

Currently the newsletter is generated via a tool which deals with publishing the email and sending out tweets of content. Every issue of the newsletter can be exported to JSON, which I want to use to drive Wyam. Here's a minimal example of the JSON document:
  

```json
{
  "Id": "7835a652-f2ac-405d-b357-92dd01357393",
  "NewsTopicId": "50774e3c-3e7d-4cda-8edc-cf714c55832d",
  "Articles": [
    {
      "Id": "a7ed08aa-c8a6-43c4-9507-14cad026ee48",
      "KnownAuthorId": "0688f858-1846-41a0-9cd0-7f94def5a0a6",
      "CategoryId": "4a87d8ec-a0d8-4a15-82fe-267445b345f4",
      "CategoryScore": 0.0076839508593005146,
      "Link": "https://channel9.msdn.com/Shows/Azure-Friday/Using-Habitat-in-Azure",
      "Image": null,
      "ImageAltText": null,
      "Site": "https://s.ch9.ms/Feeds/RSS",
      "Title": "Using Habitat in Azure with Nick Rycar on Azure Friday",
      "Verb": "talks about",
      "ArticleContent": "Nick Rycar from Chef stops by Azure Friday to chat with Donovan Brown about Habitat, a simple, flexible way to build, deploy, and manage cloud-native applications. Habitat makes it easier to develop and promote changes by enabling each instance of your application to continually and independently apply updates as soon as they're ready.For more information, see:Habitat homeHabitat docsHabitat bldr public depotCreate a Free Account AzureFollow donovanbrown Follow AzureFriday Follow rycar ",
      "AuthorNameIsInvalid": false,
      "SiteDescription": "On Channel 9",
      "FeedSourceId": "007989c5-b4c4-46fc-8d25-33d965366eae",
      "OriginalArticleId": "2018/03/22/2rDzEQnNFAeTUbldTQ2puXSpSF3G0hlstaTa36SRW0U=",
      "KeywordsMatched": [
        "Azure"
      ],
      "AuthorDisplayName": "Donovan Brown",
      "CategoryChanged": true,
      "Exclusions": []
    }
  ],
  "FromDate": "2018-03-22T08:16:13.347+00:00",
  "ToDate": "2018-04-01T07:16:00-05:00",
  "Newsletter": {
    "NewsletterItems": [
      {
        "Id": "40bb77d2-efa3-4a87-a57c-b5486ee366e6",
        "ArticleId": "a7ed08aa-c8a6-43c4-9507-14cad026ee48",
        "Content": {
          "Text": "On Channel 9, Donovan Brown Rob Caron talks about <a href=\"https://channel9.msdn.com/Shows/Azure-Friday/Using-Habitat-in-Azure\">Using Habitat in Azure  Azure Friday</a>",
          "Image": null,
          "ImageAltText": null,
          "Title": null,
          "Link": null
        },
        "IsFeatured": false
      }
    ],
    "IssueNumber": 168,
    "IsPublished": true,
    "PublicationDateDescription": "1 April 2018",
    "Editorial": "<p>It's a huge edition of Azure Weekly this week, so brace yourselves.</p><p>Some particularly interesting announcements: there is now <a href=\"https://azure.microsoft.com/blog/virtual-machine-serial-console-access/\" data-mce-href=\"https://azure.microsoft.com/blog/virtual-machine-serial-console-access/\">Virtual Machine Serial Console access</a>, <a href=\"https://blogs.msdn.microsoft.com/devops/2018/03/26/deployment-groups-is-now-generally-available-sharing-of-targets-and-more/\" data-mce-href=\"https://blogs.msdn.microsoft.com/devops/2018/03/26/deployment-groups-is-now-generally-available-sharing-of-targets-and-more/\">Deployment Groups in VSTS/TFS is now generally available</a>, and <a href=\"https://azure.microsoft.com/blog/soft-delete-for-azure-storage-blobs-now-in-public-preview/\" data-mce-href=\"https://azure.microsoft.com/blog/soft-delete-for-azure-storage-blobs-now-in-public-preview/\">Soft delete for Azure Storage Blobs is now in public preview</a>.</p><p>Now for the other announcements, which I've put in the order of the newsletter's categories:</p><ul><li><a href=\"https://azure.microsoft.com/en-us/updates/general-availability-azure-scheduled-events-2/\" data-mce-href=\"https://azure.microsoft.com/en-us/updates/general-availability-azure-scheduled-events-2/\">General availability: Azure Scheduled Events</a></li><li><a href=\"https://azure.microsoft.com/blog/azure-dns-private-zones-now-available-in-public-preview/\" data-mce-href=\"https://azure.microsoft.com/blog/azure-dns-private-zones-now-available-in-public-preview/\">Azure DNS Private Zones now available in public preview</a></li><li><a href=\"https://azure.microsoft.com/en-us/updates/disable-route-propagation-ga-udr/\" data-mce-href=\"https://azure.microsoft.com/en-us/updates/disable-route-propagation-ga-udr/\">General availability: Disable BGP route propagation for virtual network routes</a></li><li><a href=\"https://azure.microsoft.com/en-us/updates/standardlbga/\" data-mce-href=\"https://azure.microsoft.com/en-us/updates/standardlbga/\">General availability: Standard Load Balancer</a></li><li><a href=\"https://azure.microsoft.com/blog/announcing-the-general-availability-of-azure-files-share-snapshot/\" data-mce-href=\"https://azure.microsoft.com/blog/announcing-the-general-availability-of-azure-files-share-snapshot/\">Announcing the general availability of Azure Files share snapshot</a></li><li><a href=\"https://azure.microsoft.com/en-us/updates/azure-sdk-go-v15/\" data-mce-href=\"https://azure.microsoft.com/en-us/updates/azure-sdk-go-v15/\">Azure SDK for Go v15 is available</a></li><li><a href=\"https://azure.microsoft.com/blog/azure-sql-data-warehouse-now-generally-available-in-all-azure-regions-worldwide/\" data-mce-href=\"https://azure.microsoft.com/blog/azure-sql-data-warehouse-now-generally-available-in-all-azure-regions-worldwide/\">Azure SQL Data Warehouse now generally available in all Azure regions worldwide</a></li><li><a href=\"https://azure.microsoft.com/en-us/updates/azure-data-factory-supports-aad-authentication-for-azure-sql-database-and-sql-data-warehouse/\" data-mce-href=\"https://azure.microsoft.com/en-us/updates/azure-data-factory-supports-aad-authentication-for-azure-sql-database-and-sql-data-warehouse/\">Azure Data Factory now supports Azure AD authentication</a></li><li><a href=\"https://azure.microsoft.com/blog/azure-databricks-industry-leading-analytics-platform-powered-by-apache-spark/\" data-mce-href=\"https://azure.microsoft.com/blog/azure-databricks-industry-leading-analytics-platform-powered-by-apache-spark/\">Azure Databricks, industry-leading analytics platform powered by Apache Spark</a></li><li><a href=\"https://powerbi.microsoft.com/en-us/blog/microsoft-power-bi-achieves-hitrust-csf-certification/\" data-mce-href=\"https://powerbi.microsoft.com/en-us/blog/microsoft-power-bi-achieves-hitrust-csf-certification/\">Microsoft Power BI achieves HITRUST CSF certification</a></li><li><a href=\"https://azure.microsoft.com/blog/azure-event-hubs-integration-with-apache-spark-now-generally-available/\" data-mce-href=\"https://azure.microsoft.com/blog/azure-event-hubs-integration-with-apache-spark-now-generally-available/\">Azure Event Hubs integration with Apache Spark now generally available</a></li><li><a href=\"https://blogs.msdn.microsoft.com/eventhubs/2018/03/28/azure-event-hubs-geo-dr-configurations-now-enabled-in-all-azure-regions/\" data-mce-href=\"https://blogs.msdn.microsoft.com/eventhubs/2018/03/28/azure-event-hubs-geo-dr-configurations-now-enabled-in-all-azure-regions/\">Azure Event Hubs Geo-DR configurations, now enabled in all Azure regions</a></li><li><a href=\"https://azure.microsoft.com/en-us/updates/event-hubs-go-preview/\" data-mce-href=\"https://azure.microsoft.com/en-us/updates/event-hubs-go-preview/\">Public preview: Event Hubs for Go</a></li><li><a href=\"https://blogs.msdn.microsoft.com/streamanalytics/2018/03/23/now-in-public-preview-visual-studio-tools-for-azure-stream-analytics-on-iot-edge/\" data-mce-href=\"https://blogs.msdn.microsoft.com/streamanalytics/2018/03/23/now-in-public-preview-visual-studio-tools-for-azure-stream-analytics-on-iot-edge/\">Now in Public Preview: Visual Studio tools for Azure Stream Analytics on IoT Edge</a></li><li><a href=\"https://azure.microsoft.com/blog/announcing-terraform-availability-in-the-azure-marketplace/\" data-mce-href=\"https://azure.microsoft.com/blog/announcing-terraform-availability-in-the-azure-marketplace/\">Announcing Terraform availability in the Azure Marketplace</a></li><li><a href=\"https://azure.microsoft.com/blog/announcing-azure-service-health-general-availability-configure-your-alerts-today/\" data-mce-href=\"https://azure.microsoft.com/blog/announcing-azure-service-health-general-availability-configure-your-alerts-today/\">Announcing Azure Service Health general availability – configure your alerts today</a></li><li><a href=\"https://azure.microsoft.com/blog/azure-monitor-general-availability-of-multi-dimensional-metrics-apis/\" data-mce-href=\"https://azure.microsoft.com/blog/azure-monitor-general-availability-of-multi-dimensional-metrics-apis/\">Azure Monitor - General availability of multi-dimensional metrics APIs</a></li><li><a href=\"https://azure.microsoft.com/blog/announcing-the-support-for-tags-in-cost-management-apis/\" data-mce-href=\"https://azure.microsoft.com/blog/announcing-the-support-for-tags-in-cost-management-apis/\">Support for tags in cost management APIs is now available</a></li></ul><p>If you're into game development, there has been an influx of videos on Channel 9 from the Level Up show in the past week. View them all on the <a href=\"https://channel9.msdn.com/Shows/Level-Up\" data-mce-href=\"https://channel9.msdn.com/Shows/Level-Up\">Level Up channel</a>.</p><p>There is an article describing how to <a href=\"https://blogs.msdn.microsoft.com/premier_developer/2018/03/22/accelerate-your-gdpr-compliance-with-microsoft-cloud/\" data-mce-href=\"https://blogs.msdn.microsoft.com/premier_developer/2018/03/22/accelerate-your-gdpr-compliance-with-microsoft-cloud/\">Accelerate Your GDPR compliance with Microsoft Cloud</a>, a wide-spanning video on how to <a href=\"https://mountainss.wordpress.com/2018/03/22/build-a-company-in-azure-video/\" data-mce-href=\"https://mountainss.wordpress.com/2018/03/22/build-a-company-in-azure-video/\">Build a Company in Azure</a>, and Tony Smith writes: <a href=\"https://abocd.blog/2018/03/25/azure-hothouse/\" data-mce-href=\"https://abocd.blog/2018/03/25/azure-hothouse/\">So you want to run an Azure Hothouse?</a></p><p>In another interesting article, we're told how to <a href=\"https://www.patrickvankleef.com/2018/03/28/collect-data-with-azure-functions-and-cognitive-services/\" data-mce-href=\"https://www.patrickvankleef.com/2018/03/28/collect-data-with-azure-functions-and-cognitive-services/\">Use the power of Azure Functions and Cognitive Services to collect Geolocation information</a> by Patrick van Kleef.</p><p>Finally, a gentle reminder about the <a href=\"https://azure.microsoft.com/blog/globalazure-bootcamp-2018/\" data-mce-href=\"https://azure.microsoft.com/blog/globalazure-bootcamp-2018/\">Global Azure Bootcamp 2018</a>. Do get involved!</p>"
  },
  "TweetCollection": {
    "IsPublished": false,
    "TweetItems": [
      {
        "Id": "3b22057c-7d06-4158-a9fb-194fb5615378",
        "ArticleId": "a7ed08aa-c8a6-43c4-9507-14cad026ee48",
        "TweetContent": "Using Habitat in #Azure with Nick Rycar on Azure Friday from Donovan Brown https://channel9.msdn.com/Shows/Azure-Friday/Using-Habitat-in-Azure"
      }
    ]
  },
  "ExcludedArticles": null,
  "LastUpdated": "2018-03-31T09:15:25+00:00"
}

```