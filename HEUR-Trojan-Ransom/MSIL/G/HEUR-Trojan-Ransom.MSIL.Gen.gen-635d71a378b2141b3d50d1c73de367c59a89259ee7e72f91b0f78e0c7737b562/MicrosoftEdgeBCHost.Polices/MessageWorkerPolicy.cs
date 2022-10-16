using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MessageWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceDefinition()
	{
	}
}
