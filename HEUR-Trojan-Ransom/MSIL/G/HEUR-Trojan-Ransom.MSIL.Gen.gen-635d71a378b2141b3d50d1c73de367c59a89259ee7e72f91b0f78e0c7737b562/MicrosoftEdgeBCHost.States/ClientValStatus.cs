using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ClientValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralTemplate()
	{
	}
}
