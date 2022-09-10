using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[HideModuleName]
[StandardModule]
internal sealed class __________________________________________________________________________
{
	private static ResourceManager m__;

	private static CultureInfo m___;

	public static object ___;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager _
	{
		get
		{
			if (object.ReferenceEquals(__________________________________________________________________________.m__, null))
			{
				ResourceManager resourceManager = (__________________________________________________________________________.m__ = _003CModule_003E.________(_003CModule_003E.___<string>(3011951369u), typeof(__________________________________________________________________________).Assembly));
			}
			return __________________________________________________________________________.m__;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo __
	{
		get
		{
			return __________________________________________________________________________.m___;
		}
		set
		{
			__________________________________________________________________________.m___ = value;
		}
	}

	internal static string ___ => _.GetString(_003CModule_003E.______<string>(3729592180u), __________________________________________________________________________.m___);

	internal static byte[] ____
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(_.GetObject(_003CModule_003E._______<string>(2004946176u), __________________________________________________________________________.m___));
			return (byte[])objectValue;
		}
	}

	internal static string _____ => _.GetString(_003CModule_003E._____<string>(2093462827u), __________________________________________________________________________.m___);

	internal static byte[] ______
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(_.GetObject(_003CModule_003E.____<string>(251397721u), __________________________________________________________________________.m___));
			return (byte[])objectValue;
		}
	}

	internal static string _______ => _.GetString(_003CModule_003E.___<string>(2628783426u), __________________________________________________________________________.m___);
}
