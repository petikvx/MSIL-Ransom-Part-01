using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SingletonAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceValue()
	{
	}
}
