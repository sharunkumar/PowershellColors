# PowershellColors

Simple library to maintain a list of colors with a mapping for use in PowerShell.

## Usage

```powershell
# add the type to the PowerShell session
Add-Type -AssemblyName C:\path\to\PowershellColors.dll

# initialize a mapping object
$colors = New-Object PowershellColors.MappedColorPool[string]

# for excluding certain colors (colors are in range 0-15)
$colors = New-Object PowershellColors.MappedColorPool[string] -ArgumentList 0 # excludes the color black
```

# Example

