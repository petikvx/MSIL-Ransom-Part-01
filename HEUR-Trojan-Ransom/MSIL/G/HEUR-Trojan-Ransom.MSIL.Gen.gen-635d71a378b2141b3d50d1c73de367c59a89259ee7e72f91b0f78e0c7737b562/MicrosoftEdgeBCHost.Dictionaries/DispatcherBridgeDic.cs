using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DispatcherBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		PushClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushClass()
	{
	}
}
