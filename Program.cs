using System;
using Google.Ads.GoogleAds;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V16.Services;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Initializing Google Ads API Client...");

        GoogleAdsClient client = new GoogleAdsClient();

        GoogleAdsServiceClient service = client.GetService(Services.V16.GoogleAdsService);

        string query = "SELECT campaign.id, campaign.name FROM campaign ORDER BY campaign.id";

        try
        {
            var response = service.Search(long.Parse(client.Config.ClientCustomerId), query);
            foreach (var row in response)
            {
                Console.WriteLine($"Campaign ID: {row.Campaign.Id}, Name: {row.Campaign.Name}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
