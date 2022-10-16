using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PrinterValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceIdentifier()
	{
	}
}
