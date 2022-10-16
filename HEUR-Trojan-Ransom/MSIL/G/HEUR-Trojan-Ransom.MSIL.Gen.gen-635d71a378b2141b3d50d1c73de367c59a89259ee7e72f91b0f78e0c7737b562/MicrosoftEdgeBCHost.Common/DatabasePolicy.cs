using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DatabasePolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabasePolicy()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceCreator()
	{
	}
}
