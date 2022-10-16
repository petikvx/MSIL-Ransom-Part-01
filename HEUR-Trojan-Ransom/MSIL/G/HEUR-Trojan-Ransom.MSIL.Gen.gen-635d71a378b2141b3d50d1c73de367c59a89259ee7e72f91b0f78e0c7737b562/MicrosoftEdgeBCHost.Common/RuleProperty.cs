using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RuleProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleProperty()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceState()
	{
	}
}
