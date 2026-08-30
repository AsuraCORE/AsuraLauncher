# Burralis Game Launcher
A game launcher for World of Warcraft that allows you to connect to custom servers with a valid tls certificate attached.

### License & Contributions

Licensed under the MIT license. See the [LICENSE](LICENSE) file for full license information.

## Important Scope & Limitations

This launcher has a very strict and intentionally limited feature set.

### What is not included
- No developer mode
- No mod loading
- No experimental or legacy features
- No support for deprecated client branches

### What This Launcher Can Do

- Launch modern World of Warcraft clients
- Connect to custom servers with a valid TLS certificate attached
- Allow custom client version & cdn urls  
  Useful for launching older clients or serving data from your own CDN

## Supported Clients
| Client Branch | Min Supported Version | Max Supported Version |
|-------------------------|------------|------------|
| Mainline                | 10.1.5     | **12.0.5** |
| Classic Era             | 1.14.4     | **\*** |
| Classic                 | 3.4.2      | **5.5.3** |
| Classic Anniversary     | 2.5.5      | **\*** |
| Classic Titan           | 3.80.0     | **\*** |

**\* = all future versions in that branch (unless otherwise stated)**

### NOTE FOR SERVER CONNECTIONS
* A valid certificate matching your authentication/bnet server host name.
  That certificate needs to be loaded by the authentication/bnet server too

## Building

### Build Prerequisites
* [.NET Core SDK 10.0.0 or later](https://dotnet.microsoft.com/download/dotnet/10.0)
* Optional for native builds: C++ workload through Visual Studio 2026 or latest C++ build tools

### Build Instructions Windows (native)
* Execute `dotnet publish -r win-x64 -c Configuration -p:platform="x64" -p:PublishAot=true`
* Native output is placed in the `build` folder.

## Usage

### Windows Usage
1. Copy `Burralis Game Launcher.exe` to your World of Warcraft folder.
2. Edit the `WTF/Config.wtf` to set your portal or use a different config file with the `-config Config2.wtf` launch arg.
3. Run the `Burralis Game Launcher.exe`

### Launch Parameters
Use `--help`
