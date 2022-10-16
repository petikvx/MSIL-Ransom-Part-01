using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class VisitorOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralParam()
	{
	}
}
