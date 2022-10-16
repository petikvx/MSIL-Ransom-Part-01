using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ThreadHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadHelper()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralThread()
	{
	}
}
