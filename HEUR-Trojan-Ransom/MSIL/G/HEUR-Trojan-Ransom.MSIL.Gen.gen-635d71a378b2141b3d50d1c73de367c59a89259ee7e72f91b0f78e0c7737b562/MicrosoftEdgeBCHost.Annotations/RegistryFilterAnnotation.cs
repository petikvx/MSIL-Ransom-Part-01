using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RegistryFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfacePrototype()
	{
	}
}
