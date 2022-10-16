using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReaderFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceUtils()
	{
	}
}
