using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TaskProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceImporter()
	{
	}
}
