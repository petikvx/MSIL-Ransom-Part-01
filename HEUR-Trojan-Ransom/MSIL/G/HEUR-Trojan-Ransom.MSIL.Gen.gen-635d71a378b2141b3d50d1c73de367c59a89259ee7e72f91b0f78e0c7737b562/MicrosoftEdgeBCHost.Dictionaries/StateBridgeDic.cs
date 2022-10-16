using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StateBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		InitToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitToken()
	{
	}
}
