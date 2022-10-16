using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ReaderWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderWorker()
	{
		WriterPropertyProducer.ResolveStub();
		PopCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopCallback()
	{
	}
}
