using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PrototypePolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypePolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceCallback()
	{
	}
}
