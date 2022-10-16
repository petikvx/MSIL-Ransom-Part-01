using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SingletonVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonVal()
	{
		WriterPropertyProducer.ResolveStub();
		CompareRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareRequest()
	{
	}
}
