using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ThreadBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeMerchant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeMerchant()
	{
	}
}
