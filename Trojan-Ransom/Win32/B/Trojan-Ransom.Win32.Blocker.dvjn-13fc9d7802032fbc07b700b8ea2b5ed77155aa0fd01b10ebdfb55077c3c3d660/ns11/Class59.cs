using System;
using System.Xml;

namespace ns11;

internal class Class59 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class59(XmlWriter xmlWriter, string name)
	{
		if (!ehRNvvpn5Tbp3XUAbVC())
		{
			switch (0)
			{
			case 0:
				break;
			case 1:
			case 3:
				goto IL_0034;
			default:
				goto IL_003b;
			case 5:
				return;
			}
		}
		base._002Ector();
		goto IL_0034;
		IL_003b:
		xmlWriter_0.WriteStartElement(name);
		return;
		IL_0034:
		xmlWriter_0 = xmlWriter;
		goto IL_003b;
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}

	internal static bool IvRFgRpU9dGYD4GVIhs()
	{
		return true;
	}

	internal static bool ehRNvvpn5Tbp3XUAbVC()
	{
		return false;
	}
}
