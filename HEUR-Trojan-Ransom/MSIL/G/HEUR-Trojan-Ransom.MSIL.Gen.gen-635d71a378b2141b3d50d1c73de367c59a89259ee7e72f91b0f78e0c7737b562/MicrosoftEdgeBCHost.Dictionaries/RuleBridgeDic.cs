using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RuleBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceServer()
	{
	}
}
