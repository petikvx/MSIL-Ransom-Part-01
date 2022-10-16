using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PrinterValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterValException()
	{
		WriterPropertyProducer.ResolveStub();
		RevertAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertAttribute()
	{
	}
}
