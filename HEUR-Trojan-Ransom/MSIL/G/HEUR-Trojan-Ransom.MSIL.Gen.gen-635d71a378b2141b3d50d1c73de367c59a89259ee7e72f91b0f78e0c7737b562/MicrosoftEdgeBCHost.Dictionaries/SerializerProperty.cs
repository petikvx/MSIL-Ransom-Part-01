using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SerializerProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerProperty()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceCustomer()
	{
	}
}
