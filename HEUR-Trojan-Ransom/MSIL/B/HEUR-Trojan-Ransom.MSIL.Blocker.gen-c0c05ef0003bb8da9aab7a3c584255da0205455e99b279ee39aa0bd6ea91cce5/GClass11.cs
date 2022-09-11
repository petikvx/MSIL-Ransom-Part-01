using System.Xml;

public class GClass11 : GClass10
{
	public enum GEnum2
	{
		const_0 = 3,
		const_1 = 2,
		const_2 = 1
	}

	public static GEnum2 GEnum2_0 => (GEnum2)Class28.smethod_0(4823103, null, null);

	public GClass11()
	{
		XmlDocument xmlDocument = new XmlDocument();
		if (Delegate69.smethod_0() || 1 == 0)
		{
			Delegate70.smethod_0(this);
			return;
		}
		xmlDocument.Load(Delegate28.smethod_0() + "systeminfo2.xml");
		XmlNode xmlNode = xmlDocument.SelectSingleNode("HPAsset-Lite/Win32_ComputerSystemProduct/Name");
		if (xmlNode != null || 1 == 0)
		{
			Delegate72.smethod_0(this, Delegate71.smethod_0(this, xmlNode.InnerText));
		}
		Delegate73.smethod_0(this, xmlDocument);
		XmlNode xmlNode2 = xmlDocument.SelectSingleNode("HPAsset-Lite/Win32_ComputerSystemProduct/IdentifyingNumber");
		if (xmlNode2 != null || 1 == 0)
		{
			Delegate74.smethod_0(this, xmlNode2.InnerText);
		}
		XmlNode xmlNode3 = xmlDocument.SelectSingleNode("HPAsset-Lite/Win32_ComputerSystemProduct/Name");
		if (xmlNode3 != null || 1 == 0)
		{
			Delegate75.smethod_0(this, xmlNode3.InnerText);
		}
		XmlNode xmlNode4 = xmlDocument.SelectSingleNode("HPAsset-Lite/Win32_ComputerSystemProduct/Vendor");
		if (xmlNode4 != null || 1 == 0)
		{
			Delegate76.smethod_0(this, xmlNode4.InnerText);
		}
		XmlNode xmlNode5 = xmlDocument.SelectSingleNode("HPAsset-Lite/SI_HPProductInfo/CPCServiceID");
		if (xmlNode5 != null || 1 == 0)
		{
			Delegate77.smethod_0(this, xmlNode5.InnerText);
		}
		XmlNode xmlNode6 = xmlDocument.SelectSingleNode("HPAsset-Lite/SI_HPProductInfo/CPCModelNumber");
		if (xmlNode6 != null || 1 == 0)
		{
			Delegate78.smethod_0(this, xmlNode6.InnerText);
		}
		XmlNode xmlNode7 = xmlDocument.SelectSingleNode("HPAsset-Lite/SI_HPProductInfo/SystemFirstBootDate");
		if (xmlNode7 != null || 1 == 0)
		{
			Delegate79.smethod_0(this, xmlNode7.InnerText);
		}
		XmlNode xmlNode8 = xmlDocument.SelectSingleNode("HPAsset-Lite/SI_HPProductInfo/CPCSoftwareBuild");
		if (xmlNode8 != null || 1 == 0)
		{
			Delegate80.smethod_0(this, xmlNode8.InnerText);
		}
		XmlNode xmlNode9 = xmlDocument.SelectSingleNode("HPAsset-Lite/SI_HPProductInfo/CPCPrimaryBrand");
		if (xmlNode9 != null || 1 == 0)
		{
			Delegate81.smethod_0(this, xmlNode9.InnerText);
		}
		XmlNode xmlNode10 = xmlDocument.SelectSingleNode("HPAsset-Lite/SI_HPProductInfo/ProductFamily");
		if (xmlNode10 != null || 1 == 0)
		{
			Delegate82.smethod_0(this, xmlNode10.InnerText);
		}
		if (Delegate83.smethod_0(this) == null || Delegate83.smethod_0(this) == "" || 1 == 0)
		{
			Delegate85.smethod_0(this, Delegate84.smethod_0(this));
		}
		Delegate87.smethod_0(this, Delegate86.smethod_0(this));
		Delegate90.smethod_0(this, Delegate89.smethod_0(this, Delegate88.smethod_0(this)));
		XmlNode xmlNode11 = xmlDocument.SelectSingleNode("HPAsset-Lite/Win32_BIOS/SMBIOSBIOSVersion");
		if (xmlNode11 != null || 1 == 0)
		{
			Delegate91.smethod_0(this, xmlNode11.InnerText);
		}
	}

	private bool method_0(string string_13)
	{
		return (bool)Class28.smethod_0(4829137, this, string_13);
	}

	private void method_1(string string_13)
	{
		Class28.smethod_0(4821274, this, string_13);
	}

	private string method_2(string string_13)
	{
		return (string)Class28.smethod_0(4821160, this, string_13);
	}

	private void method_3(XmlDocument xmlDocument_0)
	{
		Class28.smethod_0(4821036, this, xmlDocument_0);
	}

	private void method_4()
	{
		Class28.smethod_0(4821818, this, null);
	}

	private string method_5()
	{
		return (string)Class28.smethod_0(4822941, this, null);
	}

	public string method_6(string string_13)
	{
		return (string)Class28.smethod_0(4823008, this, string_13);
	}

	public string method_7(string string_13)
	{
		return (string)Class28.smethod_0(4822906, this, string_13);
	}

	public string method_8(string string_13)
	{
		return (string)Class28.smethod_0(4822772, this, string_13);
	}

	public static bool smethod_0()
	{
		return (bool)Class28.smethod_0(4823438, null, null);
	}

	private static bool smethod_1(object object_0)
	{
		return (bool)Class28.smethod_0(4823534, null, object_0);
	}

	public static bool smethod_2()
	{
		return (bool)Class28.smethod_0(4823317, null, null);
	}

	public static bool smethod_3()
	{
		return (bool)Class28.smethod_0(4823202, null, null);
	}
}
