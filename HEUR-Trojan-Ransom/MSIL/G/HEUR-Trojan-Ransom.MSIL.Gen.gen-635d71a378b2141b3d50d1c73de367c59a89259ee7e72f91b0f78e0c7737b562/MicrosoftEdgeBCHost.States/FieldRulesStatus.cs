using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FieldRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceParser()
	{
	}
}
