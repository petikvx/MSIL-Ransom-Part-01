using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SystemHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemHelper()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralThread()
	{
	}
}
