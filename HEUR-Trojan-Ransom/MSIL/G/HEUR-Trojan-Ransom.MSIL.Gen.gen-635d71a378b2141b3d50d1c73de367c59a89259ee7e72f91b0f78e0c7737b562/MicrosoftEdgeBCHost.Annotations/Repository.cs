using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class Repository
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Repository()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectCode()
	{
	}
}
