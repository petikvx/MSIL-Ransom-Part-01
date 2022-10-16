using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TagWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagWorker()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyHelper()
	{
	}
}
