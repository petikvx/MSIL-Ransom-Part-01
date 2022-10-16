using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ComparatorAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceSpecification()
	{
	}
}
