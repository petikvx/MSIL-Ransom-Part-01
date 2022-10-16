using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ServerValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralDecorator()
	{
	}
}
