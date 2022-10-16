using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConnectionRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionRules()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectTag()
	{
	}
}
