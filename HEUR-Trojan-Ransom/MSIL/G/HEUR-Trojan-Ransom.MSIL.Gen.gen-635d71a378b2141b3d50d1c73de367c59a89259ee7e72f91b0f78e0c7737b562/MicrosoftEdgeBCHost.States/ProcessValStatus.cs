using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProcessValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralTemplate()
	{
	}
}
