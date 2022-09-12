using System;
using System.Resources;
using FxResources.System.Xml.XDocument;

namespace ns4;

internal static class Class3
{
	private static ResourceManager resourceManager_0;

	private const string string_0 = null;

	private static ResourceManager ResourceManager
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager(ResourceType);
			}
			return resourceManager_0;
		}
	}

	internal static string Argument_AddAttribute => smethod_1("维德Ц尔Ц维维娜", null);

	internal static string Argument_AddNode => smethod_1("诶比诶比Л勒艾比勒艾诶尺勒比比尺Л勒", null);

	internal static string Argument_AddNonWhitespace => smethod_1("勒维艾娜维伊勒娜勒勒勒提伊艾勒娜勒", null);

	internal static string Argument_ConvertToString => smethod_1("诶德吉维吉开维吉开开德诶吉德У诶诶维诶吉开开开维", null);

	internal static string Argument_InvalidExpandedName => smethod_1("提吉提伊吉提迪迪伊提迪提迪迪吉迪提迪艾提提迪伊艾", null);

	internal static string Argument_InvalidPIName => smethod_1("吾尔尺哦开开尺", null);

	internal static string Argument_InvalidPrefix => smethod_1("Р提儿Р提开Р勒Р开维维Р开开提勒Р勒", null);

	internal static string Argument_MustBeDerivedFrom => smethod_1("吾П开ЧРРРР艾开艾Р艾Р开ЧПРР", null);

	internal static string Argument_NamespaceDeclarationPrefixed => smethod_1("西艾维吉吉吉比吉艾西艾吉比吉西西吉吉西吉艾", null);

	internal static string Argument_NamespaceDeclarationXml => smethod_1("比ГГ比Г斯尔比艾艾斯比Г比Г尔尺尔斯", null);

	internal static string Argument_NamespaceDeclarationXmlns => smethod_1("尺丝西ЩЩ尺丝尺丝尺Щ尺西Щ艾Щ尺尺丝丝西西尺Щ艾Щ西", null);

	internal static string Argument_XObjectValue => smethod_1("德杰艾杰勒德德杰杰勒杰勒勒迪迪杰勒勒德勒杰艾德德艾艾", null);

	internal static string InvalidOperation_DeserializeInstance => smethod_1("Щ艾艾贝伊艾Ц伊娜Щ", null);

	internal static string InvalidOperation_DocumentStructure => smethod_1("贝贝Ч克艾艾贝艾Ч克ЧЧ吾Ч克艾Ч", null);

	internal static string InvalidOperation_DuplicateAttribute => smethod_1("尺屁艾屁屁尺艾艾艾屁尺艾屁屁尺艾艾", null);

	internal static string InvalidOperation_ExpectedEndOfFile => smethod_1("娜娜比比尺В比娜艾艾比尺尺娜娜В比比娜比", null);

	internal static string InvalidOperation_ExpectedInteractive => smethod_1("艾艾哦艾斯斯哦Ю艾艾艾艾哦艾艾艾", null);

	internal static string InvalidOperation_ExpectedNodeType => smethod_1("伊伊开艾娜伊马马伊伊伊娜马马娜马马马开马马马马艾马开", null);

	internal static string InvalidOperation_ExternalCode => smethod_1("伊伊马艾马马伊伊马Х", null);

	internal static string InvalidOperation_MissingAncestor => smethod_1("娜娜吉娜迪艾娜吉吉娜吉娜迪吉吉迪", null);

	internal static string InvalidOperation_MissingParent => smethod_1("娜弗弗娜丝弗弗弗弗", null);

	internal static string InvalidOperation_MissingRoot => smethod_1("德艾艾贼尔尔Д德П德尔德П尔", null);

	internal static string InvalidOperation_UnexpectedNodeType => smethod_1("提弗В伊提弗В贼В弗", null);

	internal static string InvalidOperation_UnresolvedEntityReference => smethod_1("诶艾ВВ吉В艾诶杰艾艾艾艾艾艾杰艾", null);

	internal static string InvalidOperation_WriteAttribute => smethod_1("吉艾吉贼贼艾艾艾艾迪贼贼贼迪马贼马吉马艾艾艾马艾吉马", null);

	internal static string NotSupported_WriteBase64 => smethod_1("艾豆儿迪豆豆吾迪豆艾艾儿Ю吾儿Ю艾吾Ю儿迪艾艾儿儿豆Ю", null);

	internal static string NotSupported_WriteEntityRef => smethod_1("开斯斯К维斯开贝КК开斯开维斯贝斯К维维КК开К贝", null);

	internal static Type ResourceType => typeof(SR);

	private static bool smethod_0()
	{
		return false;
	}

	internal static string smethod_1(string string_1, string string_2)
	{
		string text = null;
		try
		{
			text = ResourceManager.GetString(string_1);
		}
		catch (MissingManifestResourceException)
		{
		}
		if (string_2 != null && string_1.Equals(text, StringComparison.Ordinal))
		{
			return string_2;
		}
		return text;
	}

	internal static string smethod_2(string string_1, object[] object_0)
	{
		if (object_0 != null)
		{
			if (smethod_0())
			{
				return string_1 + string.Join("德迪ЛЛЛ勒伊迪迪尔德伊伊伊勒尔尔Л德迪德德勒伊尔伊迪", object_0);
			}
			return string.Format(string_1, object_0);
		}
		return string_1;
	}

	internal static string smethod_3(string string_1, object object_0)
	{
		if (smethod_0())
		{
			return string.Join("杰杰杰弗开吾弗开弗弗杰Л弗Л吾杰弗", string_1, object_0);
		}
		return string.Format(string_1, object_0);
	}

	internal static string smethod_4(string string_1, object object_0, object object_1)
	{
		if (smethod_0())
		{
			return string.Join("К娜艾哦勒哦娜娜吾艾К艾哦К艾勒К艾勒", string_1, object_0, object_1);
		}
		return string.Format(string_1, object_0, object_1);
	}

	internal static string smethod_5(string string_1, object object_0, object object_1, object object_2)
	{
		if (smethod_0())
		{
			return string.Join("维维哦儿弗伊Щ维弗伊儿儿ЩЩЩ弗维Щ弗", string_1, object_0, object_1, object_2);
		}
		return string.Format(string_1, object_0, object_1, object_2);
	}
}
