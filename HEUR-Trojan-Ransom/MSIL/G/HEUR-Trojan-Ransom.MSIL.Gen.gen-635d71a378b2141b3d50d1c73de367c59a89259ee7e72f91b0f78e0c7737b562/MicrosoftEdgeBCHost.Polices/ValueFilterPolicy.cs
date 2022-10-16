using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ValueFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DefineGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineGlobal()
	{
	}
}
