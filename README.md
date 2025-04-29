## Backported Parsers for OpenTabletDriver 0.6.5.1

### Credits

- @nahkd123 (PTK-470 & 670 Configuration / Parsers)

### Download

Download the parsers from the [latest release](https://github.com/Backported.Parsers/releases/latest)
Pick the configuration override for your tablet [In the Configurations Directory of this Repo](https://github.com/Backported.Parsers/releases/latest)

### Installation

1. Open the Plugin Manager,
2. Go to File > Install Plugin...,
3. Look for the downloaded Dll file,
4. Look for the downloaded Configuration Override for you tablet,
5. Create a `Configurations` in the appropriate location :
    - For Windows : It needs to be placed next to `OpenTabletDriver.Daemon.exe`
    - For Linux : `~/.config/OpenTabletDriver/Configurations/` or `~/.local/share/OpenTabletDriver/Configurations/`
    - For MacOS : `~/Library/Application Support/OpenTabletDriver/Configurations/`
6. Place the downloaded Configuration Override in the `Configurations` folder.

If all went accordingly, you should be seeing the same parser as the `ReportParser` value for the Configuration Override in OpenTabletDriver's Console.