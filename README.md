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

to the <specFlow> section in your app.config.
