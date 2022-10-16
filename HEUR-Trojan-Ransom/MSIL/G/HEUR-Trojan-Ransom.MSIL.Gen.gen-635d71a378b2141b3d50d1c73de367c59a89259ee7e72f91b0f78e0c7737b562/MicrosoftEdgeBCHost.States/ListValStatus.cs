using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ListValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralProxy()
	{
	}
}
