using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CodeBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeBridge()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveQueue()
	{
	}
}
