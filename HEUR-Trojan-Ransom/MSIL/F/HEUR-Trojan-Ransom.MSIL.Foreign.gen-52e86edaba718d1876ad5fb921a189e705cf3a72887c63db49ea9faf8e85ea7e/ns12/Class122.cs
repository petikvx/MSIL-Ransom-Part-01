using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns12;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class Class122
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[NonSerialized]
	internal static GetString getString_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager(getString_0(107360872), typeof(Class122).GetTypeInfo().Assembly);
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	public static string AppdataNotDefined => ResourceManager.GetString(getString_0(107360867), cultureInfo_0);

	public static string AuthenticationFailed => ResourceManager.GetString(getString_0(107364764), cultureInfo_0);

	public static string FunctionalityNotSupported => ResourceManager.GetString(getString_0(107360842), cultureInfo_0);

	public static string InvalidCollationId => ResourceManager.GetString(getString_0(107360805), cultureInfo_0);

	public static string InvalidConnectionData => ResourceManager.GetString(getString_0(107360812), cultureInfo_0);

	public static string InvalidConnectionString => ResourceManager.GetString(getString_0(107360783), cultureInfo_0);

	public static string InvalidConnectionStringAttribute => ResourceManager.GetString(getString_0(107360750), cultureInfo_0);

	public static string InvalidDecimalFormat => ResourceManager.GetString(getString_0(107360161), cultureInfo_0);

	public static string InvalidFieldType => ResourceManager.GetString(getString_0(107360132), cultureInfo_0);

	public static string InvalidIndexType => ResourceManager.GetString(getString_0(107360139), cultureInfo_0);

	public static string InvalidNameIndex => ResourceManager.GetString(getString_0(107360114), cultureInfo_0);

	public static string InvalidRowIndex => ResourceManager.GetString(getString_0(107360089), cultureInfo_0);

	public static string InvalidUriData => ResourceManager.GetString(getString_0(107360036), cultureInfo_0);

	public static string InvalidUriQuery => ResourceManager.GetString(getString_0(107360047), cultureInfo_0);

	public static string JsonUriOrHost => ResourceManager.GetString(getString_0(107360026), cultureInfo_0);

	public static string KeywordNotFound => ResourceManager.GetString(getString_0(107359973), cultureInfo_0);

	public static string KeywordNotSupported => ResourceManager.GetString(getString_0(107363889), cultureInfo_0);

	public static string MandatoryFieldNotFound => ResourceManager.GetString(getString_0(107359984), cultureInfo_0);

	public static string MoreThanOneDocumentId => ResourceManager.GetString(getString_0(107360463), cultureInfo_0);

	public static string NoDataAtIndex => ResourceManager.GetString(getString_0(107360434), cultureInfo_0);

	public static string NoHost => ResourceManager.GetString(getString_0(107360381), cultureInfo_0);

	public static string NoMoreData => ResourceManager.GetString(getString_0(107360404), cultureInfo_0);

	public static string NoObjectFound => ResourceManager.GetString(getString_0(107360355), cultureInfo_0);

	public static string NoPlaceholders => ResourceManager.GetString(getString_0(107360366), cultureInfo_0);

	public static string NumberNotGreaterThanZero => ResourceManager.GetString(getString_0(107360345), cultureInfo_0);

	public static string PathNotFound => ResourceManager.GetString(getString_0(107360312), cultureInfo_0);

	public static string PortNotSupported => ResourceManager.GetString(getString_0(107360263), cultureInfo_0);

	public static string PriorityForAllOrNoHosts => ResourceManager.GetString(getString_0(107360270), cultureInfo_0);

	public static string PriorityOutOfLimits => ResourceManager.GetString(getString_0(107360237), cultureInfo_0);

	public static string ProgramDataNotDefined => ResourceManager.GetString(getString_0(107359696), cultureInfo_0);

	public static string RemovingRequiresId => ResourceManager.GetString(getString_0(107359667), cultureInfo_0);

	public static string ThrowingAwayResults => ResourceManager.GetString(getString_0(107359642), cultureInfo_0);

	public static string UnableToConnect => ResourceManager.GetString(getString_0(107359581), cultureInfo_0);

	public static string UnableToDecodeDataValue => ResourceManager.GetString(getString_0(107359560), cultureInfo_0);

	public static string UnexpectedEndOfPacketFound => ResourceManager.GetString(getString_0(107359527), cultureInfo_0);

	public static string UnexpectedField => ResourceManager.GetString(getString_0(107359490), cultureInfo_0);

	public static string UnknownPlaceholder => ResourceManager.GetString(getString_0(107359501), cultureInfo_0);

	public static string ValueNotCorrectType => ResourceManager.GetString(getString_0(107360513), cultureInfo_0);

	internal Class122()
	{
	}

	static Class122()
	{
		Strings.CreateGetStringDelegate(typeof(Class122));
	}
}
