using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RecordProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordProperty()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceDecorator()
	{
	}
}
