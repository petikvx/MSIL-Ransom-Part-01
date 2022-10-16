using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AdapterBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopToken()
	{
	}
}
