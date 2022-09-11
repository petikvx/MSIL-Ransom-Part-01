using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace qBf2H0JjeUSPj67d.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class Resources
{
	private static ResourceManager l;

	private static CultureInfo w;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager b
	{
		get
		{
			//IL_0002: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			string text = (string)0;
			int num2 = default(int);
			while (true)
			{
				if ((nint)text == 3)
				{
					goto IL_002c;
				}
				goto IL_0060;
				IL_0060:
				int num;
				if ((nint)text == 4)
				{
					num = 3;
					goto IL_004e;
				}
				goto IL_0051;
				IL_004d:
				num = 5;
				goto IL_004e;
				IL_0051:
				if ((nint)text == 2)
				{
					goto IL_0004;
				}
				goto IL_0024;
				IL_0024:
				if ((nint)text == 5)
				{
					goto IL_0004;
				}
				if ((nint)text == 1)
				{
					num2 = 4;
					text = (string)2;
				}
				if (text == null)
				{
					text = (string)1;
				}
				if ((nint)text != 6)
				{
					continue;
				}
				goto IL_004d;
				IL_0004:
				switch (num2)
				{
				case 0:
				case 4:
					goto IL_002c;
				case 2:
				case 3:
					l = new ResourceManager(Assembly.GetEntryAssembly()!.GetName().Name + ".Properties.Resources", typeof(Resources).Assembly);
					num2 = 5;
					goto case 1;
				case 1:
				case 5:
					return l;
				}
				text = (string)3;
				goto IL_0024;
				IL_002c:
				if (l != null)
				{
					goto IL_004d;
				}
				text = (string)4;
				goto IL_0060;
				IL_004e:
				num2 = num;
				text = (string)5;
				goto IL_0051;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo T
	{
		get
		{
			//IL_0002: Expected O, but got I4
			//IL_000e: Expected O, but got I4
			string text = (string)0;
			do
			{
				if (text == null)
				{
					text = (string)1;
				}
			}
			while ((nint)text != 1);
			return w;
		}
		set
		{
			//IL_0002: Expected O, but got I4
			//IL_000c: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			string text = (string)0;
			do
			{
				if ((nint)text == 1)
				{
					w = value;
					text = (string)2;
				}
				if (text == null)
				{
					text = (string)1;
				}
			}
			while ((nint)text != 2);
		}
	}

	internal static string C
	{
		get
		{
			//IL_0002: Expected O, but got I4
			//IL_000e: Expected O, but got I4
			string text = (string)0;
			do
			{
				if (text == null)
				{
					text = (string)1;
				}
			}
			while ((nint)text != 1);
			return b.GetString("x", w);
		}
	}

	internal Resources()
	{
	}
}
