using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SystemValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralStatus()
	{
	}
}
