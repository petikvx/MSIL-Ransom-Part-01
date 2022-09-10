using System.Drawing;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace iiraiv39;

internal class ivlgLlId
{
	internal static void G4hrsDYW(WindowsFormsApplicationBase windowsFormsApplicationBase_0, ShutdownEventHandler shutdownEventHandler_0, int int_0)
	{
		switch (int_0 ^ 0xDF80)
		{
		}
		windowsFormsApplicationBase_0.add_Shutdown(shutdownEventHandler_0);
	}

	internal static bool ODfvzYW0(XmlReader xmlReader_0, int int_0)
	{
		return (int_0 ^ 0xAECC) switch
		{
			1 => xmlReader_0.Read(), 
			_ => xmlReader_0.IsEmptyElement, 
		};
	}

	internal static bool nAlaEH39(XmlReader xmlReader_0, string string_0, int int_0)
	{
		return (int_0 ^ 0x5549) switch
		{
			_ => xmlReader_0.MoveToAttribute(string_0), 
		};
	}

	internal static void kVKRhwPJ(XmlReader xmlReader_0, int int_0)
	{
		switch (int_0 ^ 0xC97A)
		{
		}
		xmlReader_0.ReadEndElement();
	}

	internal static string smethod_0(XmlReader xmlReader_0, int int_0)
	{
		return (int_0 ^ 0x367E) switch
		{
			_ => xmlReader_0.Value, 
		};
	}

	internal static Color AtDikAm1(string string_0, int int_0)
	{
		return (int_0 ^ 0xE04A) switch
		{
			_ => ColorTranslator.FromHtml(string_0), 
		};
	}

	internal static string smethod_1(Color color_0, int int_0)
	{
		return (int_0 ^ 0x9D1E) switch
		{
			_ => ColorTranslator.ToHtml(color_0), 
		};
	}

	internal static void smethod_2(XmlWriter xmlWriter_0, string string_0, string string_1, int int_0)
	{
		switch (int_0 ^ 0x8A28)
		{
		default:
			xmlWriter_0.WriteAttributeString(string_0, string_1);
			break;
		case 1:
			xmlWriter_0.WriteElementString(string_0, string_1);
			break;
		}
	}

	internal static void NvtwUSYD(XmlWriter xmlWriter_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0x7467)
		{
		}
		xmlWriter_0.WriteStartElement(string_0);
	}

	internal static void Ylza3LOJ(XmlWriter xmlWriter_0, int int_0)
	{
		switch (int_0 ^ 0x88B5)
		{
		}
		xmlWriter_0.WriteEndElement();
	}

	internal static string zIKBYyAm(string string_0, int int_0, int int_1, int int_2)
	{
		return (int_2 ^ 0xA105) switch
		{
			_ => Strings.Mid(string_0, int_0, int_1), 
		};
	}

	internal static int smethod_3(string string_0, string string_1, bool bool_0, int int_0)
	{
		return (int_0 ^ 0xC95) switch
		{
			_ => Operators.CompareString(string_0, string_1, bool_0), 
		};
	}

	internal static int PluO6Q6e(string string_0, int int_0)
	{
		return (int_0 ^ 0x9456) switch
		{
			_ => Conversions.ToInteger(string_0), 
		};
	}

	internal static string IUiM5OVg(int int_0, int int_1)
	{
		return (int_1 ^ 0x22AC) switch
		{
			_ => Conversion.Hex(int_0), 
		};
	}

	internal static string jnXal2jf(string string_0, string string_1, int int_0)
	{
		return (int_0 ^ 0x6FF1) switch
		{
			_ => string_0 + string_1, 
		};
	}

	internal static string V6rQQ40U(string string_0, int int_0, int int_1)
	{
		return (int_1 ^ 0xD9DF) switch
		{
			_ => Strings.Mid(string_0, int_0), 
		};
	}

	internal static int f5lHgZCI(string string_0, int int_0)
	{
		return (int_0 ^ 0xFC68) switch
		{
			_ => string_0.Length, 
		};
	}

	internal static void BvT3gNhf(XmlReader xmlReader_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0x7F3F)
		{
		}
		xmlReader_0.ReadStartElement(string_0);
	}

	internal static XmlNodeType smethod_4(XmlReader xmlReader_0, int int_0)
	{
		return (int_0 ^ 0x5A8C) switch
		{
			1 => xmlReader_0.NodeType, 
			_ => xmlReader_0.MoveToContent(), 
		};
	}

	internal static object smethod_5(XmlSerializer xmlSerializer_0, XmlReader xmlReader_0, int int_0)
	{
		return (int_0 ^ 0xD931) switch
		{
			_ => xmlSerializer_0.Deserialize(xmlReader_0), 
		};
	}
}
