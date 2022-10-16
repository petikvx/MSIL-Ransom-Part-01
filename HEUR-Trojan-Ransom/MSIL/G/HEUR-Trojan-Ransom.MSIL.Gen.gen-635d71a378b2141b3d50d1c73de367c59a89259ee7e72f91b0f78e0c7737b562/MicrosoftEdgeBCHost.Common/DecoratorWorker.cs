using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DecoratorWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CheckThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckThread()
	{
	}
}
