using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ItemValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemValException()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterCollection()
	{
	}
}
