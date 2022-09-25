using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal class Class10
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager(Class11.smethod_0("\uf1bb\uf19c\uf181\uf187\uf19a\uf1a7\uf194\uf19b\uf186\uf19a\uf198\uf182\uf194\uf187\uf190\uf1db\uf1a5\uf187\uf19a\uf185\uf190\uf187\uf181\uf19c\uf190\uf186\uf1db\uf1a7\uf190\uf186\uf19a\uf180\uf187\uf196\uf190\uf186", 61877), typeof(Class10).Assembly));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
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

	internal static Bitmap Bitmap_0
	{
		get
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			object @object = ResourceManager_0.GetObject(Class11.smethod_0("\ue8d5\ue8ce", 59522), cultureInfo_0);
			return (Bitmap)@object;
		}
	}

	internal Class10()
	{
	}
}
