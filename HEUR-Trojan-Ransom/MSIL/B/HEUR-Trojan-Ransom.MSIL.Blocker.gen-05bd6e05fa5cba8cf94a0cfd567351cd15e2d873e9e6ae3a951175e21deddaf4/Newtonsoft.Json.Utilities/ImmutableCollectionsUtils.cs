using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities;

internal static class ImmutableCollectionsUtils
{
	internal class Class84
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;

		public string ContractTypeName
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			set
			{
				string_0 = value;
			}
		}

		public string CreatedTypeName
		{
			[CompilerGenerated]
			get
			{
				return string_1;
			}
			[CompilerGenerated]
			set
			{
				string_1 = value;
			}
		}

		public string BuilderTypeName
		{
			[CompilerGenerated]
			get
			{
				return string_2;
			}
			[CompilerGenerated]
			set
			{
				string_2 = value;
			}
		}

		public Class84(string string_3, string string_4, string string_5)
		{
			ContractTypeName = string_3;
			CreatedTypeName = string_4;
			BuilderTypeName = string_5;
		}
	}

	[CompilerGenerated]
	internal sealed class Class85
	{
		public string string_0;

		internal bool method_0(Class84 class84_0)
		{
			return class84_0.ContractTypeName == string_0;
		}
	}

	[CompilerGenerated]
	internal sealed class Class86
	{
		public string string_0;

		internal bool method_0(Class84 class84_0)
		{
			return class84_0.ContractTypeName == string_0;
		}
	}

	private const string string_0 = "System.Collections.Immutable.IImmutableList`1";

	private const string string_1 = "System.Collections.Immutable.IImmutableQueue`1";

	private const string string_2 = "System.Collections.Immutable.IImmutableStack`1";

	private const string string_3 = "System.Collections.Immutable.IImmutableSet`1";

	private const string string_4 = "System.Collections.Immutable.ImmutableArray";

	private const string string_5 = "System.Collections.Immutable.ImmutableArray`1";

	private const string string_6 = "System.Collections.Immutable.ImmutableList";

	private const string string_7 = "System.Collections.Immutable.ImmutableList`1";

	private const string string_8 = "System.Collections.Immutable.ImmutableQueue";

	private const string string_9 = "System.Collections.Immutable.ImmutableQueue`1";

	private const string string_10 = "System.Collections.Immutable.ImmutableStack";

	private const string string_11 = "System.Collections.Immutable.ImmutableStack`1";

	private const string string_12 = "System.Collections.Immutable.ImmutableSortedSet";

	private const string string_13 = "System.Collections.Immutable.ImmutableSortedSet`1";

	private const string string_14 = "System.Collections.Immutable.ImmutableHashSet";

	private const string string_15 = "System.Collections.Immutable.ImmutableHashSet`1";

	internal static readonly IList<Class84> ilist_0 = new List<Class84>
	{
		new Class84("System.Collections.Immutable.IImmutableList`1", "System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList"),
		new Class84("System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList"),
		new Class84("System.Collections.Immutable.IImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue"),
		new Class84("System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue"),
		new Class84("System.Collections.Immutable.IImmutableStack`1", "System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack"),
		new Class84("System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack"),
		new Class84("System.Collections.Immutable.IImmutableSet`1", "System.Collections.Immutable.ImmutableHashSet`1", "System.Collections.Immutable.ImmutableHashSet"),
		new Class84("System.Collections.Immutable.ImmutableSortedSet`1", "System.Collections.Immutable.ImmutableSortedSet`1", "System.Collections.Immutable.ImmutableSortedSet"),
		new Class84("System.Collections.Immutable.ImmutableHashSet`1", "System.Collections.Immutable.ImmutableHashSet`1", "System.Collections.Immutable.ImmutableHashSet"),
		new Class84("System.Collections.Immutable.ImmutableArray`1", "System.Collections.Immutable.ImmutableArray`1", "System.Collections.Immutable.ImmutableArray")
	};

	private const string string_16 = "System.Collections.Immutable.IImmutableDictionary`2";

	private const string string_17 = "System.Collections.Immutable.ImmutableDictionary";

	private const string string_18 = "System.Collections.Immutable.ImmutableDictionary`2";

	private const string string_19 = "System.Collections.Immutable.ImmutableSortedDictionary";

	private const string string_20 = "System.Collections.Immutable.ImmutableSortedDictionary`2";

	internal static readonly IList<Class84> ilist_1 = new List<Class84>
	{
		new Class84("System.Collections.Immutable.IImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary"),
		new Class84("System.Collections.Immutable.ImmutableSortedDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary"),
		new Class84("System.Collections.Immutable.ImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary")
	};
}
