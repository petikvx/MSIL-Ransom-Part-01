using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ContextServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextServer()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralMock()
	{
	}
}
