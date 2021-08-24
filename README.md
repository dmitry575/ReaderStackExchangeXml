# ReaderStackExchangeXml
Reading Stackexchange data's from XML to model. The popular system of questions and answers stackexchange.com has published its databases into XML format.
This package help you read and convert data to the models.
Example how use this library in cosole application you can see in project [ImportStackexchange to PSQL database](https://github.com/dmitry575/ImportStackexchange)

ReaderStackExchangeXml is available via NuGet:

```PowerShell
Install-Package ReaderStackExchangeXml
```

Or alternatively via the .NET Core CLI:

```bash
dotnet add package ReaderStackExchangeXml
```

First using
-------------------

```PowerShell
var reader = new ReaderStackExchangeXml<Post>();
await foreach (var data = await reader.ReadAsync())
  {
   Console.WriteLine($"{data.Id} {data.Title}");
  }
```
