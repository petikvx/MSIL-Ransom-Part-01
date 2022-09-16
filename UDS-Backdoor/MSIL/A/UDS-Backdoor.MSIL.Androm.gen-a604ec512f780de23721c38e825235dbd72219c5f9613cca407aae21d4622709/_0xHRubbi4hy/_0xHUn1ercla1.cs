using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using _0xH1nvocates;
using _0xH2odel;
using _0xHHalf6eartedness;
using _0xHInex5erts;
using _0xHTur1hall;

namespace _0xHRubbi4hy;

internal class _0xHUn1ercla1 : IAzureToolsVersionInfo
{
	public IEnumerable<Type> ImplementedInterfaces { get; private set; }

	public string ProductDownloadFwlink { get; private set; }

	public string FullProductNameString { get; private set; }

	public string ProductVersionString { get; private set; }

	public Version ProductVersion { get; private set; }

	public Guid PackageGuid { get; private set; }

	public string BuildPath { get; private set; }

	public string ProductDirectoryPath { get; private set; }

	public string[] SupportedFrameworkVersions { get; private set; }

	public KeyValuePair<string, string>[] OSFamily { get; private set; }

	public IAzureSDKVersionInfo TargetAzureSDK { get; private set; }

	public IAzureLibrariesVersionInfo TargetAzureLibraries { get; private set; }

	public string IntellisenseServiceDefinitionSchema { get; private set; }

	public string IntellisenseServiceConfigurationSchema { get; private set; }

	public string IntellisenseWadCfgSchema { get; private set; }

	public _0xHUn1ercla1(string productVersionString, Version productVersion, Guid packageGuid, string buildPath, string productDirectoryPath, string[] supportedFrameworkVersions, IAzureSDKVersionInfo targetAzureSDK, IAzureLibrariesVersionInfo targetAzureLibraries, string fullProductNameString, string productDownloadFwlink, KeyValuePair<string, string>[] osFamily, string intellisenseServiceDefinitionSchema, string intellisenseServiceConfigurationSchema, string intellisenseWadCfgSchema, IEnumerable<Type> implementedInterfaces = null)
	{
		ProductVersionString = productVersionString;
		ProductVersion = productVersion;
		PackageGuid = packageGuid;
		BuildPath = buildPath;
		ProductDirectoryPath = productDirectoryPath;
		SupportedFrameworkVersions = supportedFrameworkVersions;
		ProductDownloadFwlink = productDownloadFwlink;
		FullProductNameString = fullProductNameString;
		ImplementedInterfaces = implementedInterfaces ?? Enumerable.Empty<Type>();
		OSFamily = osFamily;
		IntellisenseServiceConfigurationSchema = intellisenseServiceConfigurationSchema;
		IntellisenseServiceDefinitionSchema = intellisenseServiceDefinitionSchema;
		IntellisenseWadCfgSchema = intellisenseWadCfgSchema;
		string text = _0xH4table._0xHReemphas8ze(targetAzureSDK.ProductVersion);
		if (!string.IsNullOrEmpty(text))
		{
			TargetAzureSDK = _0xH4table._0xHBe8ails(new Version(text));
		}
		else
		{
			TargetAzureSDK = targetAzureSDK;
		}
		if (targetAzureLibraries == null)
		{
			TargetAzureLibraries = targetAzureLibraries;
			return;
		}
		string text2 = _0xHOvertrum5._0xHMave4icks(targetAzureLibraries.ProductVersion);
		if (!string.IsNullOrEmpty(text2))
		{
			TargetAzureLibraries = _0xHOvertrum5._0xHLuc4ies(new Version(text2));
		}
		else
		{
			TargetAzureLibraries = targetAzureLibraries;
		}
	}

	public bool _0xHInten3ance(IServiceProvider _0xHDeme0tia)
	{
		return _0xHCa4nal(PackageGuid, _0xHDeme0tia);
	}

	private static bool _0xHCa4nal(Guid _0xHInw7av7, IServiceProvider _0xHGanglie8t)
	{
		object? service = _0xHGanglie8t.GetService(typeof(SVsShell));
		object? obj = ((service is IVsShell) ? service : null) ?? throw new InvalidOperationException();
		Guid guid = _0xHInw7av7;
		int num = default(int);
		ErrorHandler.ThrowOnFailure(((IVsShell)obj).IsPackageInstalled(ref guid, ref num));
		return num != 0;
	}

	public override string _0xHR3nnas3s()
	{
		return FullProductNameString;
	}
}
