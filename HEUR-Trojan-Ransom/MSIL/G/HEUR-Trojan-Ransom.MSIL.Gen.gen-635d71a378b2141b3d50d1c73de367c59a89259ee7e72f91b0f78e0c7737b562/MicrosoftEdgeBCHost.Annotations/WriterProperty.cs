using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WriterProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterProperty()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceDescriptor()
	{
	}
}
