# ast-provider

PowerShell provider that allows you to mount script file syntax trees as PowerShell drives.

## Note

The project was brought to this point in about two hours at the PowerShell Summit 2014.  There is still a LOT of cleanup to do, but it is functional.

# QuickStart

    > # import the provider dll into your session
	> import-module ./astprovider.dll
			
	> # mount the AST for a script file:
    > new-psdrive -name ast -psprovider ast -root "c:\my\path\to\script.ps1"

    > # go to provider town on your script file syntax tree
	> dir ast:\ | where asttype -match 'constant'


