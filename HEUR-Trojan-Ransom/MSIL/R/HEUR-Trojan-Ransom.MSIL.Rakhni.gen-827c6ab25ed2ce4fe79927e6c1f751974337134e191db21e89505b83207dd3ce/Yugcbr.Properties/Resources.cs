using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using g1YNiPtPvSRBvAhXIq;
using gw3DRdpG9gZIr60hEO;
using qHZoQ70I3GAyXG32d6;

namespace Yugcbr.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager N1npLI53O;

	private static CultureInfo KOsTlp138;

	internal static Resources T1SqyESSSiVWwXpNkK;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			int num = 3;
			ResourceManager n1npLI53O = default(ResourceManager);
			ResourceManager n1npLI53O2 = default(ResourceManager);
			while (true)
			{
				bool flag = N1npLI53O == null;
				num = 2;
				while (true)
				{
					if (!flag)
					{
						goto IL_000b;
					}
					n1npLI53O = new ResourceManager("Yugcbr.Properties.Resources", ctslrqfPXc44eW1JSC(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(33554442)).Assembly);
					int num2 = 0;
					if (LefZuTjTEXgm8rPxwQ() != null)
					{
						num2 = num;
					}
					goto IL_0029;
					IL_0029:
					switch (num2)
					{
					case 2:
						continue;
					case 3:
						goto end_IL_0073;
					case 1:
						goto IL_008f;
					}
					N1npLI53O = n1npLI53O;
					goto IL_000b;
					IL_008f:
					return n1npLI53O2;
					IL_000b:
					n1npLI53O2 = N1npLI53O;
					num2 = 1;
					if (LefZuTjTEXgm8rPxwQ() == null)
					{
						goto IL_0029;
					}
					goto IL_008f;
					continue;
					end_IL_0073:
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			CultureInfo kOsTlp;
			while (true)
			{
				kOsTlp = KOsTlp138;
				if (RB1yMf41L9MdwfjAOs())
				{
					switch (0)
					{
					case 1:
						continue;
					}
				}
				break;
			}
			return kOsTlp;
		}
		set
		{
			KOsTlp138 = value;
		}
	}

	internal Resources()
	{
		nOsYxAZOmQ87ZtAcuL();
		base._002Ector();
	}

	static Resources()
	{
		J5LlPjhj0b2Nc1D9HG.PKPIlAlcr();
	}

	internal static void nOsYxAZOmQ87ZtAcuL()
	{
		iVZG9R1oqUZrSiIOLE.ExbLcoxzRwxZj();
	}

	internal static bool RB1yMf41L9MdwfjAOs()
	{
		return T1SqyESSSiVWwXpNkK == null;
	}

	internal static Resources LefZuTjTEXgm8rPxwQ()
	{
		return T1SqyESSSiVWwXpNkK;
	}

	internal static Type ctslrqfPXc44eW1JSC(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
