using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PageValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageValException()
	{
		WriterPropertyProducer.ResolveStub();
		CollectService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectService()
	{
	}
}
