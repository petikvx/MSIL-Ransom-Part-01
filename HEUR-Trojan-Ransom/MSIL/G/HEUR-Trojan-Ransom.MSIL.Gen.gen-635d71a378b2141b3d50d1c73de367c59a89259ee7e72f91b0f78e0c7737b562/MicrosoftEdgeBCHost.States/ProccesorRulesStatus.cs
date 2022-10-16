using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProccesorRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfacePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfacePrinter()
	{
	}
}
