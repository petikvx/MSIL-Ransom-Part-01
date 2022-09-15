# MSIL-Ransom
Source Code of MSIL Ransom

## Tools


You can also use this decompilers :
https://github.com/icsharpcode/ILSpy
https://github.com/dnSpyEx

And this deobfuscator :
https://github.com/ViRb3/de4dot-cex

## Script

_1_Deobfuscate.cmd
```
for /r %%G in ("*.exe";"*.dll") do de4dot.exe "%%G"
```

_2_Decompile.cmd
```
for /r %%G in ("*.exe";"*-cleaned.dll") do (
mkdir "%%G-dir"
dotnet ilspycmd "%%G" -p -o "%%G-dir"
)
```

## Under Linux

```
function decompiledotnet {

	# https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.400-linux-x64-binaries
	# mkdir -p $HOME/dotnet && tar zxf dotnet-sdk-6.0.400-linux-x64.tar.gz -C $HOME/dotnet
	# export DOTNET_ROOT=$HOME/dotnet
	# export PATH=$PATH:$HOME/dotnet
	# 
	#
	# dotnet new tool-manifest # if you are setting up this repo
	# dotnet tool install --local ilspycmd --version 7.2.1.6856
	# 

	for directorytoscan in ${@}
	do

		cd $directorytoscan

		for t in *-cleaned.exe
		do
			newname=$(echo $t|sed s/'-cleaned.exe'/'.exe'/g)
			mv $t $newname
		done

		for t in *exe
		do
			newdirectory=$(echo $t|sed s/'.exe'/''/g)
			mkdir -p $newdirectory
			echo "Create $newdirectory"

			dotnet ilspycmd $t -p -o $newdirectory
			echo "$t is now decompile"

			rm $t


		done

		# Delete empty directories
		rm $(find . -name "*" -type d -empty)

		cd ..

	done

}
```
- Thu 15 Sep 2022 10:07:27 AM UTC  :  3661 samples
