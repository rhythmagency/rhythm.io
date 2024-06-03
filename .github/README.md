# rhythm.io [![Publish to NuGet](https://github.com/rhythmagency/rhythm.io/actions/workflows/Publish-to-NuGet.yml/badge.svg)](https://github.com/rhythmagency/rhythm.io/actions/workflows/Publish-to-NuGet.yml) [![NuGet](https://img.shields.io/nuget/v/Rhythm.IO?logo=nuget)](https://www.nuget.org/packages/Rhythm.IO)
A .net library for common input/output tasks.

## Startup

To get started with Rhythm IO you will be the following;

 - .net 6+ web project
 - Install the Rhythm.IO NuGet package

Once installed add the following to your Program.cs during the `WebApplicationBuilder` before `Build()` is called.

```csharp
builder.AddRhythmIO();
```

Alternatively if you are using Startup.cs `ConfigureServices(IServiceCollection services)` add the following:

```csharp
public void ConfigureServices(IServiceCollection services) {
    services.AddRhythmIO();
}
```

# Contributing

If you would like to contibute please check our [contributing guide](CONTRIBUTING.md)!
