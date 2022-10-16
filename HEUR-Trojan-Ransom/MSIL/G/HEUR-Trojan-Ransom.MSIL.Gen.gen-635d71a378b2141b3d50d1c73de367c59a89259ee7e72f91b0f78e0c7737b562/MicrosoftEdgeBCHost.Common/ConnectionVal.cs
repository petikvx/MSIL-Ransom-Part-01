using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConnectionVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionVal()
	{
		WriterPropertyProducer.ResolveStub();
		CallPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallPredicate()
	{
	}
}
