using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CodeOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralGetter()
	{
	}
}
