using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InvocationBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationBridge()
	{
		WriterPropertyProducer.ResolveStub();
		EnableVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableVal()
	{
	}
}
