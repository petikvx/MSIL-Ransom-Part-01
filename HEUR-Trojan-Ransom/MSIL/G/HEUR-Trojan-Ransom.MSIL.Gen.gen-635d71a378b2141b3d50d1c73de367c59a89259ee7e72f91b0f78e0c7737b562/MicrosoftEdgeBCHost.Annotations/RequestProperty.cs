using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RequestProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestProperty()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceDescriptor()
	{
	}
}
