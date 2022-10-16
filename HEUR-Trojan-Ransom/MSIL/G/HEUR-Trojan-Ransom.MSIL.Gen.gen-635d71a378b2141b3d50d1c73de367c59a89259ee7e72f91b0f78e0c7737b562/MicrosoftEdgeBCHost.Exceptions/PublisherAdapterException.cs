using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PublisherAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceSpecification()
	{
	}
}
