using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ClientPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceCreator()
	{
	}
}
