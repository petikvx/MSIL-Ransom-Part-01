using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IssuerSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralAttribute()
	{
	}
}
