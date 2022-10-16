using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InstanceServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceServer()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralClient()
	{
	}
}
