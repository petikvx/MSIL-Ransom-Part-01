using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class GlobalOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CalcTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcTokenizer()
	{
	}
}
