using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ListenerRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerRules()
	{
		WriterPropertyProducer.ResolveStub();
		CreateProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateProxy()
	{
	}
}
