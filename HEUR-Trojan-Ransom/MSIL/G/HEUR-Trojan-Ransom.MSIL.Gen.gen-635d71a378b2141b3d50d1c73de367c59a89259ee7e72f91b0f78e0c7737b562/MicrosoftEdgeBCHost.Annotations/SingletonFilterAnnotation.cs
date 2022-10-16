using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SingletonFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceConfiguration()
	{
	}
}
