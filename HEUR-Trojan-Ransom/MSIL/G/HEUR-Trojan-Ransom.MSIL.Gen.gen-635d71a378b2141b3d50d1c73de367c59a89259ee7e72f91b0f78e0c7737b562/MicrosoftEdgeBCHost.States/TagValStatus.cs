using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TagValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralProxy()
	{
	}
}
