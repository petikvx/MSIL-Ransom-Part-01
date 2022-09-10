using System;
using System.Xml;

namespace ns12;

internal class Class60 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class60(XmlWriter xmlWriter, string name)
	{
		while (true)
		{
			base._002Ector();
			if (IvfGLhRoSbivVOgME0h())
			{
				switch (3)
				{
				case 0:
				case 4:
					continue;
				case 1:
				case 3:
					xmlWriter_0 = xmlWriter;
					break;
				case 5:
					return;
				}
				break;
			}
			return;
		}
		xmlWriter_0.WriteStartElement(name);
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}

	internal static bool IvfGLhRoSbivVOgME0h()
	{
		return true;
	}

	internal static bool wvPJkMRwv5lD9Mdj9Ik()
	{
		return false;
	}
}
