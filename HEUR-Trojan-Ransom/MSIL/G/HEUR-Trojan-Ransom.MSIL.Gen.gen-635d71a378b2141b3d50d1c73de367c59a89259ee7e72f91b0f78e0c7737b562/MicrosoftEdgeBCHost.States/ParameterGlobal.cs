using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParameterGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceIterator()
	{
	}
}
