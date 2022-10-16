using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RoleValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleValException()
	{
		WriterPropertyProducer.ResolveStub();
		CheckBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckBroadcaster()
	{
	}
}
