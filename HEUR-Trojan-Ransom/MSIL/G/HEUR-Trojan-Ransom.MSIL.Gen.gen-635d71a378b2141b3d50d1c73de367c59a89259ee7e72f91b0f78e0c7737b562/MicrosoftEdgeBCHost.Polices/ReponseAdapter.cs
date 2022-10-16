using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ReponseAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceManager()
	{
	}
}
