using System.Collections.Generic;
using System.Linq;

namespace NChanges;

public static class TypeInfoCollectionExtensions
{
	public static TypeInfo Get(this ICollection<TypeInfo> source, string name)
	{
		return source.Single((TypeInfo t) => t.Name == name);
	}

	public static bool Contains(this ICollection<TypeInfo> source, string name)
	{
		return source.Any((TypeInfo t) => t.Name == name);
	}
}
