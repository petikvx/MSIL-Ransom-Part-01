using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CollectionAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceUtils()
	{
	}
}
