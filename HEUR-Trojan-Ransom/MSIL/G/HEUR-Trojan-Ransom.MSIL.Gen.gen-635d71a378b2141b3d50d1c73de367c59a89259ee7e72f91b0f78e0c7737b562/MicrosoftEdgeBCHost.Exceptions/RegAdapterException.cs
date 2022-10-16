using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RegAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfacePolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfacePolicy()
	{
	}
}
