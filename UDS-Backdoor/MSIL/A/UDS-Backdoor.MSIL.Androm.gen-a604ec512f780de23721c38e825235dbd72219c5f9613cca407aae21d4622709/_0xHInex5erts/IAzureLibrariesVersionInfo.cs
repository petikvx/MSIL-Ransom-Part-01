using System;

namespace _0xHInex5erts;

internal interface IAzureLibrariesVersionInfo
{
	Version ProductVersion { get; }

	string ProductDirectoryPath { get; }

	string LibrariesFullNameString { get; }

	string RegKeyPath { get; }

	string PackagesPath { get; }

	string ToolsRefPath { get; }

	bool IsLibrariesInstalled();
}
