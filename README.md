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

![image](https://user-images.githubusercontent.com/715417/170884182-6129025c-be27-4ea1-9661-7188cf808369.png)


# Color list for reference

![image](https://user-images.githubusercontent.com/715417/170884290-dada9b6c-1020-4cef-9ff7-697e83664a97.png)
