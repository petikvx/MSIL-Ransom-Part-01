using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FilterValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InitSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitSingleton()
	{
	}
}
