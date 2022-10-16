using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FieldGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceComparator()
	{
	}
}
