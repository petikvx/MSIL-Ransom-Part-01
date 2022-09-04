using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class Class19
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[SpecialName]
	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("Output.Resources", typeof(Class19).Assembly));
		}
		return resourceManager_0;
	}

	[SpecialName]
	internal static Bitmap smethod_1()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("AgipLogo", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_2()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("aral", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_3()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("avira", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_4()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("banananeu", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_5()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("Bundespolizei2", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_6()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("esso", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_7()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("fsecure", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_8()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("kaspersky", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_9()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("kreditkarte", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_10()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("netto", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static byte[] smethod_11()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("NoSafeMode", cultureInfo_0));
		return (byte[])objectValue;
	}

	[SpecialName]
	internal static byte[] smethod_12()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("NoSafeModeDLL", cultureInfo_0));
		return (byte[])objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_13()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("omv", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_14()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("paysafecard", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_15()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("paysafecard1", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static byte[] smethod_16()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("Release", cultureInfo_0));
		return (byte[])objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_17()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("Rossmann", cultureInfo_0));
		return (Bitmap)objectValue;
	}
}
