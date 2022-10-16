using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BaseAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceError()
	{
	}
}
