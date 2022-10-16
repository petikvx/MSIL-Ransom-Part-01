using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ClientClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientClass()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceItem()
	{
	}
}
