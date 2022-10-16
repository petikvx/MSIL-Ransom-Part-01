using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InterpreterBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterBridge()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeIndexer()
	{
	}
}
