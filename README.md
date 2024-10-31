# ASP.NET Core Authentication with Azure Active Directory

This repository contains a sample project demonstrating how to set up **ASP.NET Core** authentication with **Azure Active Directory (Azure AD)**. It allows users to authenticate using their Microsoft accounts and access secure parts of the application based on Azure AD configurations.

## Table of Contents
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
  - [Clone the Repository](#clone-the-repository)
  - [Azure AD Setup](#azure-ad-setup)
  - [Configure Application](#configure-application)
- [Running the Application](#running-the-application)
- [Contributing](#contributing)
- [License](#license)

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or later
- [Azure AD Tenant](https://portal.azure.com/) (You need an Azure account to create a tenant)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the Repository

1. Clone this repository to your local machine:
   ```bash
   git clone https://github.com/stevsharp/Asp.netCoreAuthenticationAzureAD.git
   cd Asp.netCoreAuthenticationAzureAD
Azure AD Setup
To configure Azure Active Directory for this application:

Log in to the Azure portal.
Navigate to Azure Active Directory > App registrations > New registration.
Enter a name for your app, select Accounts in this organizational directory only, and set the Redirect URI to https://localhost:5001/signin-oidc.
After registering the app, note the Application (client) ID and Directory (tenant) ID.
Under Certificates & secrets, create a new client secret and note the generated value (you'll need it for configuration).
Under API permissions, add the following:
Microsoft Graph > Delegated permissions: User.Read
Configure Application
In the project, open appsettings.json and update the following section with your Tenant ID, Client ID, and Client Secret from the Azure AD setup:

"AzureAd": {
  "Instance": "https://login.microsoftonline.com/",
  "Domain": "<your-domain>.onmicrosoft.com",
  "TenantId": "<Your-Tenant-ID>",
  "ClientId": "<Your-Client-ID>",
  "ClientSecret": "<Your-Client-Secret>",
  "CallbackPath": "/signin-oidc"
}

Save the appsettings.json file.

Running the Application
Open the project in Visual Studio or Visual Studio Code.

Run the application by pressing F5 or using the command:

bash
Copy code
dotnet run
Navigate to https://localhost:5001 in your browser. You should be redirected to the Azure AD login page for authentication.

Once authenticated, you’ll be redirected back to the application with access to secure parts of the application.

## Connect with Me

[![LinkedIn](https://img.shields.io/badge/LinkedIn-Profile-blue)](https://www.linkedin.com/in/spyros-ponaris-913a6937/)
