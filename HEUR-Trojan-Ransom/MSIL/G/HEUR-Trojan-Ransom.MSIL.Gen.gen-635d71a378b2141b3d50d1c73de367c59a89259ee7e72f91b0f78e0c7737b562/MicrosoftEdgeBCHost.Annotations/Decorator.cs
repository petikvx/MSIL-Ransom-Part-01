using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class Decorator
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Decorator()
	{
		WriterPropertyProducer.ResolveStub();
		CreateProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateProccesor()
	{
	}
}
