# Google Ads API Integration (.NET Core)

This is a demo project for integrating with the Google Ads API using .NET 6 and the official Google Ads .NET SDK.

## Features

- Connect to Google Ads Test Account
- Fetch and display campaigns
- Console-based app for testing API integration

## Requirements

- .NET 6 SDK or higher
- Google Ads API Developer Token (Test Mode)
- OAuth2 credentials (Client ID, Client Secret, Refresh Token)

## Configuration

Create a `google-ads.yaml` file in the root directory with the following:

```yaml
developer_token: "YOUR_TOKEN"
client_id: "YOUR_CLIENT_ID"
client_secret: "YOUR_CLIENT_SECRET"
refresh_token: "YOUR_REFRESH_TOKEN"
login_customer_id: "YOUR_MCC_ID"
client_customer_id: "YOUR_TEST_ACCOUNT_ID"
```

## Run the App

```bash
dotnet restore
dotnet run
```

## Notes

This project is for test mode only and uses test accounts created under a Google Ads MCC.
