using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SpecificationOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceRef()
	{
	}
}
