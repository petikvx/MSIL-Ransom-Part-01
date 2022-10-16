using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MapperFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralServer()
	{
	}
}
