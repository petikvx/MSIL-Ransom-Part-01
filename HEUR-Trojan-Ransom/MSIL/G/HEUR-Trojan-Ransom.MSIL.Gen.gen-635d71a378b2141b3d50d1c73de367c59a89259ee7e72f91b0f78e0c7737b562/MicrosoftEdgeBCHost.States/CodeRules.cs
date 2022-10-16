using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CodeRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeRules()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInitializer()
	{
	}
}
