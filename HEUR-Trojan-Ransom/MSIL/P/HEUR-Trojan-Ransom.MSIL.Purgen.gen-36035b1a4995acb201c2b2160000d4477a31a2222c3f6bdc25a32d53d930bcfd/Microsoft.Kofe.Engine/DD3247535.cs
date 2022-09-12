using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class DD3247535
{
	private IJdwpClass FED1BBD05;

	private IJdwpMethod C9CD4E9C8;

	[CompilerGenerated]
	private IJdwpCodeLocation C25552205;

	[CompilerGenerated]
	private IJDbg E06420DAA;

	[CompilerGenerated]
	private IJdwpThread EC1044442;

	[CompilerGenerated]
	private IJdwpStackFrame AAB02C153;

	public IJdwpClass EE8318026
	{
		get
		{
			if (FED1BBD05 == null)
			{
				FED1BBD05 = D0308D65F.GetClass(FDB714162.get_ClassID());
			}
			return FED1BBD05;
		}
	}

	public IJdwpMethod A9709830E
	{
		get
		{
			if (EE8318026 != null && C9CD4E9C8 == null)
			{
				C9CD4E9C8 = EE8318026.GetMethod(FDB714162.get_MethodID());
			}
			return C9CD4E9C8;
		}
	}

	public IJdwpCodeLocation FDB714162
	{
		[CompilerGenerated]
		get
		{
			return C25552205;
		}
		[CompilerGenerated]
		private set
		{
			C25552205 = value;
		}
	}

	public IJDbg D0308D65F
	{
		[CompilerGenerated]
		get
		{
			return E06420DAA;
		}
		[CompilerGenerated]
		private set
		{
			E06420DAA = value;
		}
	}

	public IJdwpThread D9B337BB0
	{
		[CompilerGenerated]
		get
		{
			return EC1044442;
		}
		[CompilerGenerated]
		private set
		{
			EC1044442 = value;
		}
	}

	public IJdwpStackFrame D1F321559
	{
		[CompilerGenerated]
		get
		{
			return AAB02C153;
		}
		[CompilerGenerated]
		private set
		{
			AAB02C153 = value;
		}
	}

	public DD3247535(IJDbg jdbg, IJdwpThread thread, IJdwpStackFrame frame, IJdwpClass c = null, IJdwpMethod m = null)
	{
		D0308D65F = jdbg;
		D9B337BB0 = thread;
		D1F321559 = frame;
		FDB714162 = D1F321559.get_Location();
		FED1BBD05 = c;
		C9CD4E9C8 = m;
	}

	public DD3247535(IJDbg jdbg, IJdwpCodeLocation location)
	{
		D0308D65F = jdbg;
		D9B337BB0 = null;
		D1F321559 = null;
		FDB714162 = location;
	}
}
