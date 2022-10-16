using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SpecificationAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfacePolicy()
	{
	}
}
