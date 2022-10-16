using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class UtilsRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsRules()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeConfiguration()
	{
	}
}
