# Endjin.SpecFlow
Library to help write SpecFlow specification.
Contains Hooks for setting up and tearing down the Endjin.Composition Framework & various useful extension methods.
Also contains Hooks for hosting static web files (and Web Api Controllers) for testing

Currently a manual step is required to load the assemblied in your SpecFlow project.

Add:

```
<stepAssemblies>
  <stepAssembly assembly="Endjin.SpecFlow" />
  <stepAssembly assembly="Endjin.SpecFlow.Owin.Hosting" />
</stepAssemblies>
```

to the ``<specFlow>`` section in your app.config.

To use Endjin.SpecFlow.Owin.Hosting, two app settings keys are required, to set the relative file path for locally stored static file and the host URL they will be served from inside the specification:

```
<appSettings>
  <add key="Endjin.SpecFlow.Owin.Hosting.Url" value="http://localhost:12345" />
  <add key="Endjin.SpecFlow.Owin.Hosting.StaticFilePath" value="/Data" />
</appSettings>
```
