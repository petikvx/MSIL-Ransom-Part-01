using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ManagerGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceIterator()
	{
	}
}
