using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ModelValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralProxy()
	{
	}
}
