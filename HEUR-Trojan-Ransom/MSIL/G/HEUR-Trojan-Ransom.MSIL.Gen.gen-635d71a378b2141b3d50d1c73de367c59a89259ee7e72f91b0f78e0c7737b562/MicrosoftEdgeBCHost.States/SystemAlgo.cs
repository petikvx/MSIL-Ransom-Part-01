using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SystemAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralConfiguration()
	{
	}
}
