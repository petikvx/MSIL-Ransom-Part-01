using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SerializerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceValue()
	{
	}
}
