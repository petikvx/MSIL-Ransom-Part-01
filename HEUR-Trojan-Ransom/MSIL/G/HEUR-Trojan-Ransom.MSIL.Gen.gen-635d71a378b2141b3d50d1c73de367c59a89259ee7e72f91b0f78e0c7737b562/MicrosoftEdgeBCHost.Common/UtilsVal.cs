using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class UtilsVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsVal()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotPublisher()
	{
	}
}
