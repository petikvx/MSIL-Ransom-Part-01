using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InvocationOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationOrder()
	{
		WriterPropertyProducer.ResolveStub();
		InitRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitRegistry()
	{
	}
}
