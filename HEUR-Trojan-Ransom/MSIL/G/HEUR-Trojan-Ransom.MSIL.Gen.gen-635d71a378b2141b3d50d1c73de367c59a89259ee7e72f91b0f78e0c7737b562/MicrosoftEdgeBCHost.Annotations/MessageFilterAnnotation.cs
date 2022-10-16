using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MessageFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceAttribute()
	{
	}
}
