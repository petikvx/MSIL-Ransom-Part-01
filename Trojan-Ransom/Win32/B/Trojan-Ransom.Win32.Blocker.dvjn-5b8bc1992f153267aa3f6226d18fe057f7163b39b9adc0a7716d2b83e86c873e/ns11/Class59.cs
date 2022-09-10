using System;
using System.Xml;

namespace ns11;

internal class Class59 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class59(XmlWriter xmlWriter, string name)
	{
		while (true)
		{
			base._002Ector();
			if (mLUpmqvU3GLHHaLlSkf())
			{
				switch (4)
				{
				case 3:
					continue;
				case 1:
				case 4:
					xmlWriter_0 = xmlWriter;
					break;
				case 5:
					return;
				}
			}
			break;
		}
		xmlWriter_0.WriteStartElement(name);
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}

	internal static bool mLUpmqvU3GLHHaLlSkf()
	{
		return true;
	}

	internal static bool d7YjDJvdBRs2ZvGQP44()
	{
		return false;
	}
}
