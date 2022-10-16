using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MessageProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageProperty()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceDecorator()
	{
	}
}
