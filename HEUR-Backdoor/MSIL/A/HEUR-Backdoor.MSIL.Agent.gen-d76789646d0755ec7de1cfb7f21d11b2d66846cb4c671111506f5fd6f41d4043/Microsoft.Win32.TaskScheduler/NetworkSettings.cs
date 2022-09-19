using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[XmlType(IncludeInSchema = false)]
public sealed class NetworkSettings : IDisposable
{
	private INetworkSettings v2Settings;

	[DefaultValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")]
	public Guid Id
	{
		get
		{
			string text = null;
			if (v2Settings != null)
			{
				text = v2Settings.Id;
			}
			if (!string.IsNullOrEmpty(text))
			{
				return new Guid(text);
			}
			return Guid.Empty;
		}
		set
		{
			if (v2Settings == null)
			{
				throw new NotV1SupportedException();
			}
			v2Settings.Id = ((value == Guid.Empty) ? null : value.ToString());
		}
	}

	[DefaultValue(null)]
	public string Name
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.Name;
			}
			return null;
		}
		set
		{
			if (v2Settings == null)
			{
				throw new NotV1SupportedException();
			}
			v2Settings.Name = value;
		}
	}

	internal NetworkSettings(INetworkSettings iSettings)
	{
		v2Settings = iSettings;
	}

	public void Dispose()
	{
		if (v2Settings != null)
		{
			Marshal.ReleaseComObject(v2Settings);
		}
	}

	internal bool IsSet()
	{
		if (v2Settings != null)
		{
			if (string.IsNullOrEmpty(v2Settings.Id))
			{
				return !string.IsNullOrEmpty(v2Settings.Name);
			}
			return true;
		}
		return false;
	}
}
