using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DicFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectAlgo()
	{
	}
}
