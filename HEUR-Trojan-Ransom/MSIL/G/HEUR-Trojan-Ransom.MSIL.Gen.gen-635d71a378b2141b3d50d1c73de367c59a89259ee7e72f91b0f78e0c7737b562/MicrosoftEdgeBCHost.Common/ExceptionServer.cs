using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExceptionServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionServer()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralIterator()
	{
	}
}
