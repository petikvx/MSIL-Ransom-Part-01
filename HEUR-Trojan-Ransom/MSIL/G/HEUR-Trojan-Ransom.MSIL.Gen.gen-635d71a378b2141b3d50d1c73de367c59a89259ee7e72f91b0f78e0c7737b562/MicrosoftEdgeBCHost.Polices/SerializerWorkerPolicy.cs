using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SerializerWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceAdapter()
	{
	}
}
