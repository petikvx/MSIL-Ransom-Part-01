using System;
using System.Xml;

namespace ns9;

internal class Class43 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class43(XmlWriter xmlWriter, string name)
	{
		if (ktV6o94H5glUffltu38())
		{
		}
		switch (1)
		{
		case 0:
		case 1:
			base._002Ector();
			goto case 3;
		case 3:
			xmlWriter_0 = xmlWriter;
			break;
		case 5:
			return;
		}
		xmlWriter_0.WriteStartElement(name);
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}

	internal static bool qshFyJ4ArXvRZjoB5Ji()
	{
		return true;
	}

	internal static bool ktV6o94H5glUffltu38()
	{
		return false;
	}
}
