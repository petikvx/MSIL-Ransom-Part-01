using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MapOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapOrder()
	{
		WriterPropertyProducer.ResolveStub();
		InitReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitReg()
	{
	}
}
