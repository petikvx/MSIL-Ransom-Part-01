using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class GlobalFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectValue()
	{
	}
}
