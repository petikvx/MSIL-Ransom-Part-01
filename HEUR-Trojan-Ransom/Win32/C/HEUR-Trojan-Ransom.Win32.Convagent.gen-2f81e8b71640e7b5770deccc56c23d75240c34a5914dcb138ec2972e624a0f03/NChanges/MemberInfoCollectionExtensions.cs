using System.Collections.Generic;
using System.Linq;

namespace NChanges;

public static class MemberInfoCollectionExtensions
{
	public static MemberInfo Get(this ICollection<MemberInfo> source, string name)
	{
		return source.Single((MemberInfo m) => m.Name == name);
	}

	public static MemberInfo Get(this ICollection<MemberInfo> source, MemberInfo memberInfo)
	{
		if (source.IsOverloaded(memberInfo.Name))
		{
			return source.Single((MemberInfo m) => m.Name == memberInfo.Name && MatchParameter(m, memberInfo));
		}
		return source.Get(memberInfo.Name);
	}

	public static MemberInfo TryGet(this ICollection<MemberInfo> source, MemberInfo memberInfo)
	{
		if (source.IsOverloaded(memberInfo.Name))
		{
			return source.SingleOrDefault((MemberInfo m) => m.Name == memberInfo.Name && MatchParameter(m, memberInfo));
		}
		return source.Get(memberInfo.Name);
	}

	private static bool MatchParameter(MemberInfo current, MemberInfo previous)
	{
		if (current.Parameters.Count() != previous.Parameters.Count())
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < current.Parameters.Count())
			{
				if (current.Parameters[num].Type != previous.Parameters[num].Type)
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static bool Contains(this ICollection<MemberInfo> source, string name)
	{
		return source.Any((MemberInfo m) => m.Name == name);
	}

	public static bool IsOverloaded(this ICollection<MemberInfo> source, string name)
	{
		return source.Count((MemberInfo m) => m.Name == name) > 1;
	}
}
