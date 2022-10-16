using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClassValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeAnnotation()
	{
	}
}
