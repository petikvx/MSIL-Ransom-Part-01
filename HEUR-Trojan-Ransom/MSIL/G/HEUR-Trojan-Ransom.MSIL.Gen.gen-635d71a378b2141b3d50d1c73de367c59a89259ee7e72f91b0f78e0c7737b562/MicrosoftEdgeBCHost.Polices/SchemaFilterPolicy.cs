using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SchemaFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PushModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushModel()
	{
	}
}
