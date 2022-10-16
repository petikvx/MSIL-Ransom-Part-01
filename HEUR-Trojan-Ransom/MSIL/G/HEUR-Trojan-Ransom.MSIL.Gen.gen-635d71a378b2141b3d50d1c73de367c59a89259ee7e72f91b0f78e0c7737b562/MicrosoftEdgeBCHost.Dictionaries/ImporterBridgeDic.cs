using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ImporterBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceManager()
	{
	}
}
