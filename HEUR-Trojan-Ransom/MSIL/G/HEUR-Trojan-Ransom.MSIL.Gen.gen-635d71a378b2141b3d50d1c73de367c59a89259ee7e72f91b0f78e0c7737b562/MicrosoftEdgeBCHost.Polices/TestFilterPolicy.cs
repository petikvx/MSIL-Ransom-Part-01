using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TestFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PrintRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintRef()
	{
	}
}
