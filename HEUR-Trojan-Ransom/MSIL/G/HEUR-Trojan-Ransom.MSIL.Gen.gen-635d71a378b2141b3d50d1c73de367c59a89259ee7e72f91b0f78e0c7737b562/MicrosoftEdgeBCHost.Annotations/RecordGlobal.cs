using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RecordGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfacePage()
	{
	}
}
