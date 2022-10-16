using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParamValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareCreator()
	{
	}
}
