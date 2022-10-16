using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PoolPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceHelper()
	{
	}
}
