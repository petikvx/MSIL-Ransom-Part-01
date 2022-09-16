using System;

namespace _0xHHalf6eartedness;

internal interface IAzureSDKVersionInfo
{
	Version ProductVersion { get; }

	string ProductDirectoryPath { get; }

	string SDKFullNameString { get; }

	string SchemaVersion { get; }

	string ServiceDefinitionSchemaFile { get; }

	string ServiceConfigurationSchemaFile { get; }

	string WadCfgSchemaFile { get; }

	string RegKeyPath { get; }

	string BinPath { get; }

	string RefPath { get; }

	string PluginsPath { get; }

	string VSExtensionsPath { get; }

	string DiagnosticsTraceListenerName { get; }

	bool IsSDKInstalled();
}
