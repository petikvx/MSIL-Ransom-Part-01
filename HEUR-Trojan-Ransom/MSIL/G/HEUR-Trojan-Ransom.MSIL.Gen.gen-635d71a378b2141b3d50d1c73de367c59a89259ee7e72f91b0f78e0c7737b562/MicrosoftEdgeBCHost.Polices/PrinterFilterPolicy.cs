using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PrinterFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectAuthentication()
	{
	}
}
