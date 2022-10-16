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
- Thu 15 Sep 2022 01:07:40 PM UTC  :  3667 samples
- Thu 15 Sep 2022 01:22:58 PM UTC  :  3671 samples
- Fri 16 Sep 2022 03:23:02 AM UTC  :  3710 samples
- Fri 16 Sep 2022 05:47:07 PM UTC  :  3750 samples
- Sat 17 Sep 2022 02:42:44 PM UTC  :  3761 samples
- Sat 17 Sep 2022 06:51:54 PM UTC  :  3811 samples
- Mon 19 Sep 2022 09:59:48 AM UTC  :  3883 samples
- Wed 21 Sep 2022 04:17:18 AM UTC  :  3946 samples
- Thu 22 Sep 2022 08:13:21 AM UTC  :  3994 samples
- Fri 23 Sep 2022 03:50:55 AM UTC  :  4023 samples
- Sat 24 Sep 2022 09:47:54 AM UTC  :  4044 samples
- Sun 25 Sep 2022 08:15:06 AM UTC  :  4179 samples
- Sun 25 Sep 2022 05:04:04 PM UTC  :  4198 samples
- Tue 27 Sep 2022 04:42:46 PM UTC  :  4224 samples
- Wed 28 Sep 2022 04:28:16 AM UTC  :  4267 samples
- Thu 29 Sep 2022 12:21:17 PM UTC  :  4328 samples
- Sun 02 Oct 2022 04:32:12 AM UTC  :  4383 samples
- Sun 02 Oct 2022 04:44:16 AM UTC  :  4400 samples
- Wed 05 Oct 2022 09:32:56 AM UTC  :  4458 samples
- Thu 06 Oct 2022 05:42:30 PM UTC  :  4491 samples
- Sat 15 Oct 2022 04:38:44 AM UTC  :  4523 samples
- Sun 16 Oct 2022 01:54:00 PM UTC  :  4555 samples
