using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class EventPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralPage()
	{
	}
}
