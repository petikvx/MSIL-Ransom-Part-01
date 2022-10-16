using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CustomerValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralPage()
	{
	}
}
