# Endjin's SpecFlow extensions

##Endjin.SpecFlow
Library that contains:
- Path & ScenarioContext extensions
- Shared Steps for dealing with Exceptions & Results

To install via NuGet, use:
```
Install-Package Endjin.SpecFlow
```
##Endjin.SpecFlow.Composition
Library that contains:
- Feature & Scenario Hooks for setting up and tearing down instances of the [Endjin Composition Framework](https://github.com/endjin/Endjin.Composition)

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
