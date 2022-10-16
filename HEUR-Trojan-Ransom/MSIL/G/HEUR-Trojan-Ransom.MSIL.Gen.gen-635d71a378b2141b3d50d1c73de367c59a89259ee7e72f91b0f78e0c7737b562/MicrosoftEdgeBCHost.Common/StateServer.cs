using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StateServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateServer()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralMock()
	{
	}
}
