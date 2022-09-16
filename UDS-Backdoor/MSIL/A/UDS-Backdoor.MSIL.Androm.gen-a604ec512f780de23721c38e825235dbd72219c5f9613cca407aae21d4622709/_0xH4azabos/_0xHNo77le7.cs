using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Microsoft.Win32;
using _0xHHalf6eartedness;
using _0xHPilf2rag2s;

namespace _0xH4azabos;

internal class _0xHNo77le7 : IAzureSDKVersionInfo
{
	private string _0xHOverrel5ance;

	private string _0xHMic8ovilla8;

	private string _0xHKrub4;

	private string _0xHR0v0rsos;

	private string _0xHCom6ngs;

	private string _0xHHor8ble8des;

	private string _0xHRifl8ry;

	private string _0xHDiffu7ional;

	private string _0xHHum2ng2us;

	private string _0xHSt4min4l;

	private string _0xHSomeone5;

	private string _0xHAphtha8;

	private string _0xHToo5;

	public Version ProductVersion { get; private set; }

	public string ProductDirectoryPath
	{
		get
		{
			if (_0xHOverrel5ance == null)
			{
				_0xHOverrel5ance = (string)Registry.GetValue(_0xHMic8ovilla8, _0xHKrub4, null);
			}
			return _0xHOverrel5ance;
		}
	}

	public string SchemaVersion
	{
		get
		{
			if (_0xHHum2ng2us == null)
			{
				_0xHHum2ng2us = _0xHBla7dest();
			}
			return _0xHHum2ng2us;
		}
	}

	public string RegKeyPath => _0xHMic8ovilla8;

	public string SDKFullNameString { get; private set; }

	public string BinPath
	{
		get
		{
			if (_0xHR0v0rsos == null)
			{
				_0xHR0v0rsos = Path.Combine(ProductDirectoryPath, "Bin");
			}
			return _0xHR0v0rsos;
		}
	}

	public string RefPath
	{
		get
		{
			if (_0xHCom6ngs == null)
			{
				_0xHCom6ngs = Path.Combine(ProductDirectoryPath, "Ref");
			}
			return _0xHCom6ngs;
		}
	}

	public string PluginsPath
	{
		get
		{
			if (_0xHHor8ble8des == null)
			{
				_0xHHor8ble8des = Path.Combine(ProductDirectoryPath, _0xHQuixoti5m5._0xHMultip8ocesso8);
			}
			return _0xHHor8ble8des;
		}
	}

	public string VSExtensionsPath
	{
		get
		{
			if (_0xHRifl8ry == null)
			{
				_0xHRifl8ry = Path.Combine(ProductDirectoryPath, _0xHQuixoti5m5._0xHR8lles);
			}
			return _0xHRifl8ry;
		}
	}

	public string DiagnosticsTraceListenerName => _0xHSt4min4l;

	public string ServiceDefinitionSchemaFile
	{
		get
		{
			if (_0xHSomeone5 == null)
			{
				string text = (string)Registry.GetValue(_0xHMic8ovilla8, "SchemaPath", null);
				if (text == null)
				{
					return null;
				}
				_0xHSomeone5 = Path.Combine(text, "ServiceDefinitionSchema.xsd");
			}
			return _0xHSomeone5;
		}
	}

	public string ServiceConfigurationSchemaFile
	{
		get
		{
			if (_0xHAphtha8 == null)
			{
				string text = (string)Registry.GetValue(_0xHMic8ovilla8, "SchemaPath", null);
				if (text == null)
				{
					return null;
				}
				_0xHAphtha8 = Path.Combine(text, "ServiceConfigurationSchema.xsd");
			}
			return _0xHAphtha8;
		}
	}

	public string WadCfgSchemaFile
	{
		get
		{
			if (_0xHToo5 == null)
			{
				string text = (string)Registry.GetValue(_0xHMic8ovilla8, "SchemaPath", null);
				if (text == null)
				{
					return null;
				}
				_0xHToo5 = Path.Combine(text, "DiagnosticsConfig201010.xsd");
			}
			return _0xHToo5;
		}
	}

	public _0xHNo77le7(Version productVersion, string installPathRegKey, string installPathRegValue, string defaultSchemaVersion, string diagnosticsTraceListenerName)
	{
		ProductVersion = productVersion;
		_0xHMic8ovilla8 = installPathRegKey;
		_0xHKrub4 = installPathRegValue;
		_0xHDiffu7ional = defaultSchemaVersion;
		_0xHSt4min4l = diagnosticsTraceListenerName;
	}

	public _0xHNo77le7(Version productVersion, string installPathRegKey, string installPathRegValue, string schemaVersion, string diagnosticsTraceListenerName, string sdkFullName)
		: this(productVersion, installPathRegKey, installPathRegValue, schemaVersion, diagnosticsTraceListenerName)
	{
		SDKFullNameString = sdkFullName;
	}

	public bool _0xHSkele6onizer()
	{
		if (!string.IsNullOrEmpty(ProductDirectoryPath))
		{
			return Directory.Exists(ProductDirectoryPath);
		}
		return false;
	}

	private string _0xHBla7dest()
	{
		if (!_0xHSkele6onizer())
		{
			return _0xHDiffu7ional;
		}
		string text = (string)Registry.GetValue(_0xHMic8ovilla8, "SchemaPath", null);
		if (text == null)
		{
			return _0xHDiffu7ional;
		}
		string text2 = Path.Combine(text, "ServiceDefinitionSchema.xsd");
		if (!File.Exists(text2))
		{
			return _0xHDiffu7ional;
		}
		try
		{
			return (from el in ((XContainer)XElement.Load(text2)).Elements(XName.Get("simpleType", "http://www.w3.org/2001/XMLSchema"))
				where StringComparer.InvariantCultureIgnoreCase.Equals(el.Attribute(XName.op_Implicit("name")).get_Value(), "SchemaVersion")
				from el2 in ((XContainer)el).Descendants(XName.Get("enumeration", "http://www.w3.org/2001/XMLSchema"))
				select el2).FirstOrDefault((Func<XElement, bool>)((XElement element) => !StringComparer.InvariantCultureIgnoreCase.Equals(element.Attribute(XName.Get("value")).get_Value(), "unspecified")))!.Attribute(XName.Get("value")).get_Value();
		}
		catch (Exception)
		{
			return _0xHDiffu7ional;
		}
	}
}
