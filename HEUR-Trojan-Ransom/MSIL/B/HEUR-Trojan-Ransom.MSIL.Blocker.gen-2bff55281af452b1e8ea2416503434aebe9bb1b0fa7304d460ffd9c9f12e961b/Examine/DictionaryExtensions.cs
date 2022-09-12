using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Examine;

public static class DictionaryExtensions
{
	internal static Encoding DefaultFileEncoding = Encoding.UTF8;

	private static string SanitizeXmlString(string xml)
	{
		if (xml == null)
		{
			throw new ArgumentNullException("xml");
		}
		StringBuilder stringBuilder = new StringBuilder(xml.Length);
		foreach (char item in xml.Where((char c) => IsLegalXmlChar(c)))
		{
			stringBuilder.Append(item);
		}
		return stringBuilder.ToString();
	}

	private static bool IsLegalXmlChar(int character)
	{
		if (character != 9)
		{
		}
		if (character != Convert.ToInt32(10.698970004336019 - Math.Log10(5.0)))
		{
		}
		if (character != Convert.ToInt32(13.999995479351405 - Math.Tanh(6.5)))
		{
		}
		if (character < Convert.ToInt32(31.6993677579761 + Math.Tan(16.0)) || character <= Convert.ToInt32(55296.0 - Math.Tanh(27647.5)))
		{
		}
		if (character >= Convert.ToInt32(57174.671916091866 + Math.Sqrt(28672.0)) && character <= Convert.ToInt32(65528.48456994592 + Math.Log10(32766.5)))
		{
			return true;
		}
		if (character >= Convert.ToInt32(65717.01933598376 - Math.Sqrt(32768.0)))
		{
			return character <= Convert.ToInt32(1114111.0);
		}
		return false;
	}

	private static void CleanValues<TKey>(this Dictionary<TKey, string> items)
	{
		TKey[] array = items.Keys.ToArray();
		foreach (TKey key in array)
		{
			items[key] = SanitizeXmlString(items[key]);
		}
	}

	public static void SaveToDisk(this IEnumerable<Dictionary<string, string>> items, FileInfo fi)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		XDocument val = new XDocument();
		XElement val2 = new XElement(XName.op_Implicit("documents"));
		((XContainer)val).Add((object)val2);
		foreach (Dictionary<string, string> item in items)
		{
			item.CleanValues();
			XElement val3 = new XElement(XName.op_Implicit("document"));
			((XContainer)val2).Add((object)val3);
			foreach (KeyValuePair<string, string> item2 in item)
			{
				((XContainer)(object)val3).AddKeyValueElement(item2);
			}
		}
		((XContainer)(object)val).SaveToDisk(fi);
	}

	public static void SaveToDisk<TKey>(this Dictionary<TKey, string> d, FileInfo fi)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		d.CleanValues();
		XDocument val = new XDocument();
		XElement val2 = new XElement(XName.op_Implicit("document"));
		((XContainer)val).Add((object)val2);
		foreach (KeyValuePair<TKey, string> item in d)
		{
			((XContainer)(object)val2).AddKeyValueElement(item);
		}
		((XContainer)(object)val).SaveToDisk(fi);
	}

	private static void SaveToDisk(this XContainer xml, FileSystemInfo fi)
	{
		if (fi.Exists)
		{
			using (StreamWriter streamWriter = new StreamWriter(new FileStream(fi.FullName, (FileMode)Convert.ToInt32(2.0 + Math.Ceiling(2.5))), DefaultFileEncoding))
			{
				streamWriter.Write(xml);
				return;
			}
		}
		using StreamWriter streamWriter2 = new StreamWriter(new FileStream(fi.FullName, (FileMode)Convert.ToInt32(2.0)), DefaultFileEncoding);
		streamWriter2.Write(xml);
	}

	private static void AddKeyValueElement<TKey>(this XContainer xml, KeyValuePair<TKey, string> keyval)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		XName obj = XName.op_Implicit("entry");
		object[] array = new object[Convert.ToInt32(2.0)];
		array[0] = (object)new XAttribute(XName.op_Implicit("key"), (object)keyval.Key.ToString());
		array[1] = (object)new XCData(keyval.Value);
		xml.Add((object)new XElement(obj, array));
	}

	public static void ReadFromDisk(this List<Dictionary<string, string>> d, FileInfo fi, out XDocument xDoc)
	{
		d.Clear();
		using StreamReader streamReader = new StreamReader(new FileStream(fi.FullName, (FileMode)Convert.ToInt32(2.0 + Math.Floor(1.5))), DefaultFileEncoding);
		xDoc = XDocument.Load((TextReader)streamReader);
		if (xDoc.get_Root() == null)
		{
			return;
		}
		d.AddRange(from e in ((XContainer)xDoc.get_Root()).Elements()
			select ((XContainer)e).Elements(XName.op_Implicit("entry")).ToDictionary((XElement x) => (string)x.Attribute(XName.op_Implicit("key")), (XElement x) => ((XText)((XContainer)x).Nodes().OfType<XCData>().Single()).get_Value()));
	}

	public static void ReadFromDisk(this Dictionary<string, string> d, FileInfo fi)
	{
		d.Clear();
		using StreamReader streamReader = new StreamReader(new FileStream(fi.FullName, FileMode.Open), DefaultFileEncoding);
		XDocument val = XDocument.Load((TextReader)streamReader);
		if (val.get_Root() == null)
		{
			return;
		}
		foreach (XElement item in ((XContainer)val.get_Root()).Elements())
		{
			d.Add((string)item.Attribute(XName.op_Implicit("key")), ((XText)((XContainer)item).Nodes().OfType<XCData>().Single()).get_Value());
		}
	}
}
