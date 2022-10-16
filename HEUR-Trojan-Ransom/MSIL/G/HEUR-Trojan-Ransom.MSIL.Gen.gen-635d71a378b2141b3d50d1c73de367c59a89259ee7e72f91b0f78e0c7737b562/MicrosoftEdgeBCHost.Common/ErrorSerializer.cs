using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ErrorSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralEvent()
	{
	}
}
