using System.IO;
using System.Xml;

namespace Microsoft.Xsl;

public class XslDebuggerPlugin : XslPlugin
{
	public override XmlWriter CreateWriter(Stream output, XmlWriterSettings settings)
	{
		return new DebugXmlWriter(XmlWriter.Create(output, settings), settings);
	}

	public override object InitializeLifetimeService()
	{
		return null;
	}
}
