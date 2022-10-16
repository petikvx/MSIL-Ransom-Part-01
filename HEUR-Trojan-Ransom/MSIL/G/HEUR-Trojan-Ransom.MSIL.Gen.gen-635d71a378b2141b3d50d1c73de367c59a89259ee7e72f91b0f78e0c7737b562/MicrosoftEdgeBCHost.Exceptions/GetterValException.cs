using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class GetterValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterValException()
	{
		WriterPropertyProducer.ResolveStub();
		PatchCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchCollection()
	{
	}
}
