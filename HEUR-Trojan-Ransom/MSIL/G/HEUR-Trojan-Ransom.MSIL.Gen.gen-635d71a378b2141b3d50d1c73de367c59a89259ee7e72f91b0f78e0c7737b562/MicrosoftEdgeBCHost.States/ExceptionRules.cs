using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExceptionRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionRules()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterDispatcher()
	{
	}
}
