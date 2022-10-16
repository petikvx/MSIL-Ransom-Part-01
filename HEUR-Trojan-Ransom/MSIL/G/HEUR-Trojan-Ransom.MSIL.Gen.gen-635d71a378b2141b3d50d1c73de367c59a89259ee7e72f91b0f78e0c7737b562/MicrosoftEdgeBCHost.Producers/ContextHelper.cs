using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ContextHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextHelper()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralInvocation()
	{
	}
}
