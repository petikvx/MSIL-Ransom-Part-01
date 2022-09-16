using System;
using System.Collections.Generic;
using _0xHHalf6eartedness;
using _0xHInex5erts;

namespace _0xH1nvocates;

internal interface IAzureToolsVersionInfo
{
	string ProductVersionString { get; }

	Version ProductVersion { get; }

	Guid PackageGuid { get; }

	string BuildPath { get; }

	string ProductDirectoryPath { get; }

	string[] SupportedFrameworkVersions { get; }

	IAzureSDKVersionInfo TargetAzureSDK { get; }

	IAzureLibrariesVersionInfo TargetAzureLibraries { get; }

	string ProductDownloadFwlink { get; }

	IEnumerable<Type> ImplementedInterfaces { get; }

	string FullProductNameString { get; }

	KeyValuePair<string, string>[] OSFamily { get; }

	string IntellisenseServiceDefinitionSchema { get; }

	string IntellisenseServiceConfigurationSchema { get; }

	string IntellisenseWadCfgSchema { get; }

	bool IsToolsInstalled(IServiceProvider serviceProvider);
}
