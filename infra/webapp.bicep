// Azure App Service (Free F1 tier) for msdos-web backend (.NET 10 on Linux)
// Shared backend for the full MS-DOS terminal app — not just Snake.
//
// Deploy:
//   az group create --name msdos-web-rg --location westeurope
//   az deployment group create \
//     --resource-group msdos-web-rg \
//     --template-file infra/webapp.bicep \
//     --parameters appName=msdos-web
//
// After deploy — set the Supabase connection string (keeps secret out of source):
//   az webapp config appsettings set \
//     --name msdos-web \
//     --resource-group msdos-web-rg \
//     --settings "SUPABASE_CONN=Host=db.tfyosdbcfjkglkzilpfm.supabase.co;Port=5432;Database=postgres;Username=postgres;Password=<pw>;SSL Mode=Require;Trust Server Certificate=true"

@description('Globally unique name for the Web App — becomes <name>.azurewebsites.net')
param appName string

@description('Azure region. Defaults to the resource group location.')
param location string = resourceGroup().location

var planName = '${appName}-plan'

resource appServicePlan 'Microsoft.Web/serverfarms@2023-01-01' = {
  name: planName
  location: location
  kind: 'linux'
  sku: {
    name: 'F1'
    tier: 'Free'
  }
  properties: {
    reserved: true  // required for Linux plans
  }
}

resource webApp 'Microsoft.Web/sites@2023-01-01' = {
  name: appName
  location: location
  properties: {
    serverFarmId: appServicePlan.id
    httpsOnly: true
    siteConfig: {
      linuxFxVersion: 'DOTNETCORE|10.0'
      minTlsVersion: '1.2'
    }
  }
}

output appUrl string = 'https://${webApp.properties.defaultHostName}'
output appName string = webApp.name
