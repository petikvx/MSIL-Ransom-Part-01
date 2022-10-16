using System;
using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PrinterWrapperStatus : System.Attribute, _003CModule_003E, PrinterWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateError()
	{
	}
}
