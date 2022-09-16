using System.Reflection;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;

namespace xClient.Core.NetSerializer;

public sealed class TypeData
{
	public readonly ushort TypeID;

	public readonly IDynamicTypeSerializer TypeSerializer;

	public MethodInfo WriterMethodInfo;

	public MethodInfo ReaderMethodInfo;

	internal static TypeData EvnqJf29DGF0PmEKGjJ;

	public bool IsGenerated => true;

	public bool NeedsInstanceParameter
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public TypeData(ushort typeID, IDynamicTypeSerializer serializer)
	{
	}

	public TypeData(ushort typeID, MethodInfo writer, MethodInfo reader)
	{
	}

	static TypeData()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		IxGmBQt4C4PoCkcRl53();
	}

	internal static void ztnnUd2z1F3LGwnnSI3()
	{
	}

	internal static bool Q8w5FD2DBfG6hyGpLbR()
	{
		return true;
	}

	internal static TypeData ScYLg12dLvjGRptSQUv()
	{
		return null;
	}

	internal static void tbJIg2tbFPgC1NTZ9Q1()
	{
	}

	internal static void IxGmBQt4C4PoCkcRl53()
	{
	}
}
