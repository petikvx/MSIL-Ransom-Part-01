using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConnectionFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionFacade()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralStruct()
	{
	}
}
