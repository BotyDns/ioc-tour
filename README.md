# ioc-tour

The purpose of this repository is to have an IoC container that is as simple as possible for education purpoces, while shines light on most of the "magic" features that Asp.Net DI has (i.e: automatic dependency resolution, lifetimes etc).

## Solution structure

The solution has two projects in it (each project has a readme file containing relevant info about further project structures):

- `DiContainer`: This project contains the implementation for the container. Currently implemented features:
    - automatic dependency resolution (TODO: nullable parameters)
- `DiTest`: This test project contains examples on the usage of the container, while also showcases the current capabilities of it.

Usage example (for more examples, check the `DiTest` project folder):
```c#
var builder = DIContainer.CreateBuilder();
builder.ClassCollection.AddClass<IInterface, ClassWithInterface>();

var container = builder.Build();

var instance = container.GetInstance<IInterface>()
```