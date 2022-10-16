using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProductFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceRules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceRules()
	{
	}
}
