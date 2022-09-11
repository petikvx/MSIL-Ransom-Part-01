using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class SR
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[NonSerialized]
	internal static GetString _0003;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager(_0003(107380155), typeof(SR).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string DataTypes => ResourceManager.GetString(_0003(107354270), resourceCulture);

	internal static string Keywords => ResourceManager.GetString(_0003(107380094), resourceCulture);

	internal static string MetaDataCollections => ResourceManager.GetString(_0003(107357396), resourceCulture);

	internal SR()
	{
	}

	static SR()
	{
		Strings.CreateGetStringDelegate(typeof(SR));
	}
}
