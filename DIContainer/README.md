# DiContainer

This project contains the IoC container. It uses some interfaces in order to stay true to the object oriented approach from C#, but other than that, it tries to stay as simple as possible while implementing as many features as possible.

## Project structure

The project is structured into 3 folders and on file:
- `Interfaces`: this contains the public interfaces that are exposed to the client code.
- `Implementations`: This folder contains the implementations of the interfaces, but they are hidden from client codes.
- `Util`: Utility classes.
- `DiContainer`: This file contains the implementation of the `DiContainer` class.