using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PrinterRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceStub()
	{
	}
}
