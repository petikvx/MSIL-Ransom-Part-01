using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RuleAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceValue()
	{
	}
}
