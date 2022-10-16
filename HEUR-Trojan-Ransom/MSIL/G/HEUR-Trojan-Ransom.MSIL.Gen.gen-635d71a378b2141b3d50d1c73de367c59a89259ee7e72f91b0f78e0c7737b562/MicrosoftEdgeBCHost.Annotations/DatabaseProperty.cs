using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DatabaseProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseProperty()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceSetter()
	{
	}
}
