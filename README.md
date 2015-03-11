# Endjin's SpecFlow extensions

##Endjin.SpecFlow
Library that contains:
- Path & ScenarioContext extensions
- Shared Steps for dealing with Exceptions:
```
[Then(@"an ""(.*)"" should be thrown")]
[Then(@"a ""(.*)"" should be thrown")]
```
And Results:
```
[Then(@"the result count should be (.*)")]
[Then(@"the result should equal the datetime (.*)")]
[Then(@"the result should equal the datetimeoffset (.*)")]
[Then(@"the result should equal the integer (.*)")]
[Then(@"the result should equal the string ""(.*)""")]
[Then(@"the result should be false")]
[Then(@"the result should be greater than the datetime (.*)")]
[Then(@"the result should be greater than the datetimeoffset (.*)")]
[Then(@"the result should be greater than the integer (.*)")]
[Then(@"the result should be greater than or equal to the datetime (.*)")]
[Then(@"the result should be greater than or equal to the datetimeoffset (.*)")]
[Then(@"the result should be greater than or equal to the integer (.*)")]
[Then(@"the result should be less than the datetime (.*)")]
[Then(@"the result should be less than the datetimeoffset (.*)")]
[Then(@"the result should be less than the integer (.*)")]
[Then(@"the result should be less than or equal to the datetime (.*)")]
[Then(@"the result should be less than or equal to the datetimeoffset (.*)")]
[Then(@"the result should be less than or equal to the integer (.*)")]
[Then(@"the result should be null")]
[Then(@"the result should be of type (.*)")]
[Then(@"the result should be true")]
[Then(@"the result should contain")]
[Then(@"the result should equal the context value (.*)")]
[Then(@"the result should not be null")]
[Then(@"the result should not equal the string ""(.*)""")]
```

To install via NuGet, use:
```
Install-Package Endjin.SpecFlow
```
##Endjin.SpecFlow.Composition
Library that contains:
- Feature & Scenario Hooks for setting up and tearing down instances of the [Endjin Composition Framework](https://github.com/endjin/Endjin.Composition)

To use the tags:
```
@container
```

To install via NuGet, use:
```
Install-Package Endjin.SpecFlow.Composition
```
##Endjin.SpecFlow.Owin.Hosting
Library that contains:
- Feature & Scenario Hooks for setting up and tearing down an in-memory Owin based Web App, so that you can run integration tests against static files and WebApi Controllers

To use Endjin.SpecFlow.Owin.Hosting, two app settings keys are required, to set the relative file path for locally stored static file and the host URL they will be served from inside the specification:

```
<appSettings>
  <add key="Endjin.SpecFlow.Owin.Hosting.Url" value="http://localhost:12345" />
  <add key="Endjin.SpecFlow.Owin.Hosting.StaticFilePath" value="/Data" />
</appSettings>
```

To install via NuGet, use:
```
Install-Package Endjin.SpecFlow.Owin.Hosting
```

To use the tags:
```
@web_app
```

##Notes about installation
Specflow requires all extensions to be listed in the app.config file of the SpecFlow project.

These entries should be added automatically by the nuget packages:
```
<stepAssemblies>
  <stepAssembly assembly="Endjin.SpecFlow" />
  <stepAssembly assembly="Endjin.SpecFlow.Composition" />
  <stepAssembly assembly="Endjin.SpecFlow.Owin.Hosting" />
</stepAssemblies>
```
to the ``<specFlow>`` section in your app.config.
