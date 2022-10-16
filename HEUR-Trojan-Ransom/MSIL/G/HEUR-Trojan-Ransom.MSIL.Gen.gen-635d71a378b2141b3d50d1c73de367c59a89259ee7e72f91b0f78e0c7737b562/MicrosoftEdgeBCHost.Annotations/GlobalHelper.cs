using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class GlobalHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalHelper()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralInvocation()
	{
	}
}
