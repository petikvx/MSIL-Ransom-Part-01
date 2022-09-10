using System.Globalization;
using System.Xml;

namespace Microsoft.Xsl;

internal class DebugXmlWriter : XmlWriter
{
	private XmlWriter writer;

	private XmlOutputMethod method;

	private bool isHtml;

	private string rootName;

	private bool IsHtml
	{
		get
		{
			if (method == XmlOutputMethod.AutoDetect && rootName != null)
			{
				isHtml = string.Compare(rootName, "html", ignoreCase: true, CultureInfo.CurrentUICulture) == 0;
			}
			return isHtml;
		}
	}

	public override WriteState WriteState => writer.WriteState;

	public DebugXmlWriter(XmlWriter inner, XmlWriterSettings settings)
	{
		writer = inner;
		method = settings.OutputMethod;
		isHtml = method == XmlOutputMethod.Html;
	}

	public override void WriteComment(string text)
	{
		writer.WriteComment(text);
		writer.Flush();
	}

	public override void WriteEndAttribute()
	{
		writer.WriteEndAttribute();
		writer.Flush();
	}

	public override string LookupPrefix(string ns)
	{
		return writer.LookupPrefix(ns);
	}

	public override void WriteCData(string text)
	{
		writer.WriteCData(text);
		writer.Flush();
	}

	public override void WriteCharEntity(char ch)
	{
		writer.WriteCharEntity(ch);
		writer.Flush();
	}

	public override void WriteString(string text)
	{
		writer.WriteString(text);
		writer.Flush();
	}

	public override void WriteProcessingInstruction(string name, string text)
	{
		writer.WriteProcessingInstruction(name, text);
		writer.Flush();
	}

	public override void WriteBase64(byte[] buffer, int index, int count)
	{
		writer.WriteBase64(buffer, index, count);
		writer.Flush();
	}

	public override void WriteChars(char[] buffer, int index, int count)
	{
		writer.WriteChars(buffer, index, count);
		writer.Flush();
	}

	public override void WriteSurrogateCharEntity(char lowChar, char highChar)
	{
		writer.WriteSurrogateCharEntity(lowChar, highChar);
		writer.Flush();
	}

	public override void WriteEntityRef(string name)
	{
		writer.WriteEntityRef(name);
		writer.Flush();
	}

	public override void WriteStartAttribute(string prefix, string localName, string ns)
	{
		writer.WriteStartAttribute(prefix, localName, ns);
		if (!IsHtml)
		{
			writer.Flush();
		}
	}

	public override void WriteStartElement(string prefix, string localName, string ns)
	{
		if (rootName == null)
		{
			rootName = localName;
		}
		writer.WriteStartElement(prefix, localName, ns);
		if (!IsHtml)
		{
			writer.Flush();
		}
	}

	public override void WriteDocType(string name, string pubid, string sysid, string subset)
	{
		writer.WriteDocType(name, pubid, sysid, subset);
		writer.Flush();
	}

	public override void WriteEndElement()
	{
		writer.WriteEndElement();
		writer.Flush();
	}

	public override void Flush()
	{
		writer.Flush();
	}

	public override void Close()
	{
		writer.Close();
	}

	public override void WriteWhitespace(string ws)
	{
		writer.WriteWhitespace(ws);
		writer.Flush();
	}

	public override void WriteFullEndElement()
	{
		writer.WriteFullEndElement();
		writer.Flush();
	}

	public override void WriteRaw(string data)
	{
		writer.WriteRaw(data);
		writer.Flush();
	}

	public override void WriteRaw(char[] buffer, int index, int count)
	{
		writer.WriteRaw(buffer, index, count);
		writer.Flush();
	}

	public override void WriteEndDocument()
	{
		writer.WriteEndDocument();
		writer.Flush();
	}

	public override void WriteStartDocument(bool standalone)
	{
		writer.WriteStartDocument(standalone);
		writer.Flush();
	}

	public override void WriteStartDocument()
	{
		writer.WriteStartDocument();
		writer.Flush();
	}
}
