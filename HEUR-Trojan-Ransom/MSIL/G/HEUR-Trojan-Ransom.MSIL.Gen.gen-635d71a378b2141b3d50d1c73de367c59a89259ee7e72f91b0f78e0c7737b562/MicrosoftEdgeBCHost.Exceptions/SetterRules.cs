using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SetterRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterRules()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInitializer()
	{
	}
}
