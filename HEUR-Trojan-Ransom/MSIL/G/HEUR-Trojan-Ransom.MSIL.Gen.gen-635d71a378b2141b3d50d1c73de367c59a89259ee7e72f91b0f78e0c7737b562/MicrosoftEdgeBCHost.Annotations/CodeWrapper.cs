using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CodeWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeState()
	{
	}
}
