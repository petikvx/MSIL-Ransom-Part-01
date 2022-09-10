using System.Runtime.CompilerServices;
using System.Threading;
using CCfpfC7h;
using di1mqJMz;

namespace ns1;

internal class aSfcEigp : Class6
{
	public delegate void WMTyN6gT();

	[CompilerGenerated]
	[AccessedThroughProperty("Var")]
	private vilSnlZy kbzvRbEQ;

	[CompilerGenerated]
	private WMTyN6gT wmtyN6gT_0;

	public virtual vilSnlZy VilSnlZy_0
	{
		[CompilerGenerated]
		get
		{
			return kbzvRbEQ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			kbzvRbEQ = value;
		}
	}

	public event WMTyN6gT NlgJj2al
	{
		[CompilerGenerated]
		add
		{
			WMTyN6gT wMTyN6gT = wmtyN6gT_0;
			WMTyN6gT wMTyN6gT2;
			do
			{
				wMTyN6gT2 = wMTyN6gT;
				WMTyN6gT value2 = (WMTyN6gT)FFXb5i9i.PcI4tKMj(wMTyN6gT2, value, 32722);
				wMTyN6gT = Interlocked.CompareExchange(ref wmtyN6gT_0, value2, wMTyN6gT2);
			}
			while ((object)wMTyN6gT != wMTyN6gT2);
		}
		[CompilerGenerated]
		remove
		{
			WMTyN6gT wMTyN6gT = wmtyN6gT_0;
			WMTyN6gT wMTyN6gT2;
			do
			{
				wMTyN6gT2 = wMTyN6gT;
				WMTyN6gT value2 = (WMTyN6gT)FFXb5i9i.PcI4tKMj(wMTyN6gT2, value, 32723);
				wMTyN6gT = Interlocked.CompareExchange(ref wmtyN6gT_0, value2, wMTyN6gT2);
			}
			while ((object)wMTyN6gT != wMTyN6gT2);
		}
	}
}
