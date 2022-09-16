using System;
using System.IO;
using Microsoft.Win32;
using _0xHInex5erts;

namespace _0xHLinn3;

internal class _0xHCa2aclysms : IAzureLibrariesVersionInfo
{
	private string _0xHP1p1ins;

	private string _0xHTroth3light;

	private string _0xHCras4ed;

	private string _0xHPat7etic;

	private string _0xHC1r1w1y;

	public Version ProductVersion { get; private set; }

	public string ProductDirectoryPath
	{
		get
		{
			if (_0xHCras4ed == null)
			{
				_0xHCras4ed = (string)Registry.GetValue(_0xHP1p1ins, _0xHTroth3light, null);
			}
			return _0xHCras4ed;
		}
	}

	public string LibrariesFullNameString { get; private set; }

	public string RegKeyPath => _0xHP1p1ins;

	public string PackagesPath
	{
		get
		{
			if (_0xHPat7etic == null)
			{
				_0xHPat7etic = Path.Combine(ProductDirectoryPath, "Packages");
			}
			return _0xHPat7etic;
		}
	}

	public string ToolsRefPath
	{
		get
		{
			if (_0xHC1r1w1y == null)
			{
				_0xHC1r1w1y = Path.Combine(ProductDirectoryPath, "ToolsRef");
			}
			return _0xHC1r1w1y;
		}
	}

	public _0xHCa2aclysms(Version productVersion, string installPathRegKey, string installPathRegValue, string librariesFullName)
	{
		ProductVersion = productVersion;
		_0xHP1p1ins = installPathRegKey;
		_0xHTroth3light = installPathRegValue;
		LibrariesFullNameString = librariesFullName;
	}

	public bool _0xHSpasmoly8ic()
	{
		if (!string.IsNullOrEmpty(ProductDirectoryPath))
		{
			return Directory.Exists(ProductDirectoryPath);
		}
		return false;
	}
}
