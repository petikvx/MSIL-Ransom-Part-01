using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PrinterReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterReponse()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralError()
	{
	}
}
