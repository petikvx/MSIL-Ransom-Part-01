using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RequestGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceComposer()
	{
	}
}
