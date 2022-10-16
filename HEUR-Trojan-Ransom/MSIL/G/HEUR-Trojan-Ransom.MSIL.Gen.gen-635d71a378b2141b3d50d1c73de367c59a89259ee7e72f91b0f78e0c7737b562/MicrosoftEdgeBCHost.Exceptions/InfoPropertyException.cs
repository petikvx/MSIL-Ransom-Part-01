using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InfoPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralPage()
	{
	}
}
