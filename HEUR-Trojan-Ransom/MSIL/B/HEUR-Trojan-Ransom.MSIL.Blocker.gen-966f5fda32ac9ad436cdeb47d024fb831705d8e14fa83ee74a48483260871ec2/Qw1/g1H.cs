using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Qw1;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class g1H
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4976)]
	private struct n4C
	{
	}

	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	private static readonly Array K;

	private static readonly object D;

	private static readonly object M;

	internal static byte S/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("ManagerMarket.Resources", typeof(g1H).Assembly));
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

	static g1H()
	{
		D = new char[2488];
		char[] array = new char[8];
		array[5] = '\u0d81';
		array[4] = '㼯';
		array[7] = 'ड़';
		array[0] = '\u1df7';
		array[1] = 'ʲ';
		array[3] = '㟀';
		array[6] = '⮣';
		array[2] = 'デ';
		M = new string[174];
		K = array;
	}
}
