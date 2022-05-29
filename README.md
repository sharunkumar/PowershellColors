# PowershellColors

Simple library to maintain a list of colors with a mapping for use in PowerShell.

## Usage

```powershell
# add the type to the PowerShell session
Add-Type -AssemblyName C:\path\to\PowershellColors.dll

# initialize a mapping object
$colors = New-Object PowershellColors.MappedColorPool[string] # [string] here specifies the mapping key type

# for excluding certain colors (colors are in range 0-15)
$colors = New-Object PowershellColors.MappedColorPool[string] -ArgumentList 0,1 # excludes the colors black and (dark) blue
```

# Example

![image](https://user-images.githubusercontent.com/715417/170884406-90260571-96e3-4b29-ab2e-993650b4b240.png)


# Color list for reference

![image](https://user-images.githubusercontent.com/715417/170884290-dada9b6c-1020-4cef-9ff7-697e83664a97.png)
