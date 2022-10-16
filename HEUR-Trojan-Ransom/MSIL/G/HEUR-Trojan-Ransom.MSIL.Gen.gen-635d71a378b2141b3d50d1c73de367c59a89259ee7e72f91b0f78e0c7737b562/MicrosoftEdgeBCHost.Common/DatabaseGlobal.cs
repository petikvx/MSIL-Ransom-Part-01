using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DatabaseGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceIterator()
	{
	}
}
