using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RecordOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceError()
	{
	}
}
