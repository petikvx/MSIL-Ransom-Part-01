using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ThreadUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadUtils()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceGlobal()
	{
	}
}
