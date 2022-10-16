using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RulesGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceOrder()
	{
	}
}
