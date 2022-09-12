using System.Collections.Generic;
using System.Linq;

namespace NChanges;

public class Reporter
{
	private readonly List<AssemblyInfo> _assemblies = new List<AssemblyInfo>();

	public ICollection<AssemblyInfo> Assemblies => _assemblies;

	public AssemblyInfo GenerateReport()
	{
		AssemblyInfo assemblyInfo = new AssemblyInfo();
		AssemblyInfo previousAssembly = null;
		foreach (AssemblyInfo item in Assemblies.OrderBy((AssemblyInfo a) => a.Version.PadNumbers()))
		{
			assemblyInfo.Name = item.Name;
			assemblyInfo.Version = item.Version;
			FindAddedTypes(assemblyInfo, item, previousAssembly);
			FindRemovedTypes(assemblyInfo, item, previousAssembly);
			UpdateExistingTypes(assemblyInfo, item, previousAssembly);
			UpdateExistingTypeMembers(assemblyInfo, item, previousAssembly);
			previousAssembly = item;
		}
		return assemblyInfo;
	}

	private static void FindAddedTypes(AssemblyInfo report, AssemblyInfo thisAssembly, AssemblyInfo previousAssembly)
	{
		foreach (TypeInfo type in thisAssembly.Types)
		{
			if (!report.Types.Contains(type.Name))
			{
				TypeInfo typeInfo = type.Clone();
				if (previousAssembly != null)
				{
					typeInfo.Changes.Add(new TypeChangeInfo
					{
						Kind = TypeChangeKind.AddedType,
						Version = thisAssembly.Version
					});
				}
				report.Types.Add(typeInfo);
			}
		}
	}

	private static void FindRemovedTypes(AssemblyInfo report, AssemblyInfo thisAssembly, AssemblyInfo previousAssembly)
	{
		if (previousAssembly == null)
		{
			return;
		}
		foreach (TypeInfo type in previousAssembly.Types)
		{
			if (!thisAssembly.Types.Contains(type.Name))
			{
				report.Types.Get(type.Name).Changes.Add(new TypeChangeInfo
				{
					Kind = TypeChangeKind.RemovedType,
					Version = thisAssembly.Version
				});
			}
		}
	}

	private static void UpdateExistingTypes(AssemblyInfo report, AssemblyInfo thisAssembly, AssemblyInfo previousAssembly)
	{
		if (previousAssembly == null)
		{
			return;
		}
		foreach (TypeInfo type in previousAssembly.Types)
		{
			if (previousAssembly.Types.Contains(type.Name) && thisAssembly.Types.Contains(type.Name))
			{
				TypeInfo typeInfo = previousAssembly.Types.Get(type.Name);
				TypeInfo typeInfo2 = thisAssembly.Types.Get(type.Name);
				if (!typeInfo.Obsolete && typeInfo2.Obsolete)
				{
					report.Types.Get(type.Name).Changes.Add(new TypeChangeInfo
					{
						Kind = TypeChangeKind.ObsoletedType,
						Version = thisAssembly.Version
					});
				}
			}
		}
	}

	private static void UpdateExistingTypeMembers(AssemblyInfo report, AssemblyInfo thisAssembly, AssemblyInfo previousAssembly)
	{
		if (previousAssembly == null)
		{
			return;
		}
		foreach (TypeInfo type in report.Types)
		{
			if (!previousAssembly.Types.Contains(type.Name) || !thisAssembly.Types.Contains(type.Name))
			{
				continue;
			}
			TypeInfo typeInfo = previousAssembly.Types.Get(type.Name);
			TypeInfo typeInfo2 = thisAssembly.Types.Get(type.Name);
			foreach (MemberInfo member in typeInfo2.Members)
			{
				if (typeInfo.Members.Contains(member.Name) && typeInfo.Members.TryGet(member) != null)
				{
					MemberInfo memberInfo = typeInfo.Members.Get(member);
					if (!memberInfo.Obsolete && member.Obsolete)
					{
						type.Members.Get(member.Name).Changes.Add(new MemberChangeInfo
						{
							Kind = MemberChangeKind.ObsoletedMember,
							Version = thisAssembly.Version
						});
					}
					if (type.Members.IsOverloaded(member.Name))
					{
						continue;
					}
					if (memberInfo.Parameters.Count < member.Parameters.Count)
					{
						for (int i = memberInfo.Parameters.Count; i < member.Parameters.Count; i++)
						{
							MemberInfo memberInfo2 = type.Members.Get(member.Name);
							memberInfo2.Changes.Add(new MemberChangeInfo
							{
								Kind = MemberChangeKind.AddedParameter,
								Version = thisAssembly.Version,
								New = member.Parameters[i].Name
							});
							memberInfo2.UpdateParameters(member);
						}
					}
					else if (memberInfo.Parameters.Count > member.Parameters.Count)
					{
						for (int j = member.Parameters.Count; j < memberInfo.Parameters.Count; j++)
						{
							MemberInfo memberInfo3 = type.Members.Get(member.Name);
							memberInfo3.Changes.Add(new MemberChangeInfo
							{
								Kind = MemberChangeKind.RemovedParameter,
								Version = thisAssembly.Version,
								Old = memberInfo.Parameters[j].Name
							});
							memberInfo3.UpdateParameters(member);
						}
					}
				}
				else
				{
					MemberInfo memberInfo4 = member.Clone();
					memberInfo4.Changes.Add(new MemberChangeInfo
					{
						Kind = MemberChangeKind.AddedMember,
						Version = thisAssembly.Version
					});
					type.Members.Add(memberInfo4);
				}
			}
			foreach (MemberInfo member2 in typeInfo.Members)
			{
				if (!typeInfo2.Members.Contains(member2.Name))
				{
					type.Members.Get(member2).Changes.Add(new MemberChangeInfo
					{
						Kind = MemberChangeKind.RemovedMember,
						Version = thisAssembly.Version
					});
				}
			}
		}
	}
}
