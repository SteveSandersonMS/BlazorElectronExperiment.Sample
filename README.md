This is a sample exploring how a Blazor could be used to build a cross-platform desktop application.

It's a [Blazor](https://github.com/aspnet/blazor) UI inside an [Electron](https://electronjs.org/) shell, with the .NET part running natively
on CoreCLR (not on WebAssembly).

The benefits of running on CoreCLR instead of on Mono WebAssembly are:

* Faster code execution speed
* Full debugger support
* Works with all .NET Core packages (because it's literally a standard .NET Core console application)
* Access to all OS APIs available to desktop applications, e.g., file I/O

# How to use

1. First make sure you can create and run regular browser-based Blazor apps by [installing the usual Blazor prerequisites](https://blazor.net/docs/get-started.html). Test and be sure you can create and run a Blazor app.
1. Clone this repo, then build and run the project it contains

# Extra-experimental and unsupported

This repo is purely a short-term spike to help us understand how such a hosting model would
be implemented and how it would be likely to perform.

The code in this repo is **not maintained**. If you wish to post any issues to let us know
how you've got on with it, please feel free to do so. But please **don't expect any issues to be
fixed, nor any support questions to be answered**.

Likewise, I won't be updating any code here to match newer versions of Blazor. It's a one-time spike only.

**Summary**: This is just a demo. Don't build real apps on top of this. But if you would be interested in building real Blazor+Electron apps, [tell us about your scenarios](https://github.com/aspnet/Blazor/issues/74).

# Prebuilt packages

For convenience, the `packages` directory contains prebuilt NuGet packages that support this sample. Sources for those packages are at http://github.com/SteveSandersonMS/BlazorElectronExperiment.Packages