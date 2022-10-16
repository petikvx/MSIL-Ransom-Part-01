using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InterpreterWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterWorker()
	{
		WriterPropertyProducer.ResolveStub();
		AssetThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetThread()
	{
	}
}
