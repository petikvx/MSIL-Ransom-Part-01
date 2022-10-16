using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DatabaseFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceParameter()
	{
	}
}
