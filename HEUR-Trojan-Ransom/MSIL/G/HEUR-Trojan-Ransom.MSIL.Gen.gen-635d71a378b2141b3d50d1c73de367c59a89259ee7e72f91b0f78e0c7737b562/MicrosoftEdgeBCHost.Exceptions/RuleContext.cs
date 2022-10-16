using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RuleContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleContext()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceProducer()
	{
	}
}
