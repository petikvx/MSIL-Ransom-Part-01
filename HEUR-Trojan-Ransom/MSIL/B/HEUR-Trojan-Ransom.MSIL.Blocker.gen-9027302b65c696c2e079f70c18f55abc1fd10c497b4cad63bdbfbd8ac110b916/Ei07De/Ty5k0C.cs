using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Ei07De;

[HideModuleName]
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal sealed class Ty5k0C
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Dk01Rc
	{
		internal string[] string_0;

		internal byte[] byte_0;

		internal string string_1;

		internal int int_0;

		internal string string_2;
	}

	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				object obj = new ResourceManager("Fast_Food_Management.Resources", typeof(Ty5k0C).Assembly);
				resourceMan = obj as ResourceManager;
			}
			object obj2 = resourceMan;
			return obj2 as ResourceManager;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			IFormatProvider formatProvider = resourceCulture;
			return formatProvider as CultureInfo;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static byte[] jJ
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("jJ", resourceCulture));
			Array array = (byte[])objectValue;
			return array as byte[];
		}
	}
}
