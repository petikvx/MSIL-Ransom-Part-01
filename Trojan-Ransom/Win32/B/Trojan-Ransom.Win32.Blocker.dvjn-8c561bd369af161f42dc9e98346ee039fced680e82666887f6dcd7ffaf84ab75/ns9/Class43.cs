using System;
using System.Xml;

namespace ns9;

internal class Class43 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class43(XmlWriter xmlWriter, string name)
	{
		while (true)
		{
			base._002Ector();
			while (true)
			{
				xmlWriter_0 = xmlWriter;
				while (true)
				{
					xmlWriter_0.WriteStartElement(name);
					if (NVFpfyrWEBQpQYURbca())
					{
					}
					switch (5)
					{
					case 1:
					case 2:
						goto end_IL_0003;
					case 0:
					case 3:
						goto end_IL_003a;
					case 5:
						return;
					}
					continue;
					end_IL_0003:
					break;
				}
				continue;
				end_IL_003a:
				break;
			}
		}
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}

	internal static bool Kivh00rfIuyUWB5ysYo()
	{
		return true;
	}

	internal static bool NVFpfyrWEBQpQYURbca()
	{
		return false;
	}
}
