using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;
using ns20;

namespace ns2;

internal sealed class Class71
{
	internal sealed class Class72
	{
		private string string_0;

		private string string_1;

		private bool? nullable_0;

		private uint? nullable_1;

		private uint? nullable_2;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;

		[CompilerGenerated]
		private bool? nullable_3;

		[CompilerGenerated]
		private uint? nullable_4;

		[CompilerGenerated]
		private uint? nullable_5;

		internal string Field
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

		internal string Type
		{
			[CompilerGenerated]
			get
			{
				return string_3;
			}
			[CompilerGenerated]
			set
			{
				string_3 = value;
			}
		}

		internal bool? Required
		{
			[CompilerGenerated]
			get
			{
				return nullable_3;
			}
			[CompilerGenerated]
			set
			{
				nullable_3 = value;
			}
		}

		internal uint? Options
		{
			[CompilerGenerated]
			get
			{
				return nullable_4;
			}
			[CompilerGenerated]
			set
			{
				nullable_4 = value;
			}
		}

		internal uint? Srid
		{
			[CompilerGenerated]
			get
			{
				return nullable_5;
			}
			[CompilerGenerated]
			set
			{
				nullable_5 = value;
			}
		}
	}

	private string string_0;

	private bool bool_0;

	private string string_1;

	private List<Class72> list_0 = new List<Class72>();

	[NonSerialized]
	internal static GetString getString_0;

	public string IndexName => string_0;

	public string Type => string_1;

	public List<Class72> Fields => list_0;

	public Class71(string string_2, Class43 class43_0)
	{
		string_0 = string_2;
		if (class43_0.dictionary_0.ContainsKey(getString_0(107407803)))
		{
			string_1 = class43_0.dictionary_0[getString_0(107407803)].ToString();
		}
		object[] array = class43_0.dictionary_0[getString_0(107407812)] as object[];
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] is Dictionary<string, object> dictionary)
			{
				string field = ((dictionary[getString_0(107408274)] is Class45) ? ((Class45)dictionary[getString_0(107408274)]).string_0 : dictionary[getString_0(107408274)].ToString());
				Class72 @class = new Class72
				{
					Field = field
				};
				if (dictionary.ContainsKey(getString_0(107407803)))
				{
					@class.Type = dictionary[getString_0(107407803)].ToString();
				}
				if (dictionary.ContainsKey(getString_0(107408297)))
				{
					@class.Required = Convert.ToBoolean(dictionary[getString_0(107408297)]);
				}
				if (dictionary.ContainsKey(getString_0(107408284)))
				{
					@class.Options = Convert.ToUInt32(dictionary[getString_0(107408284)]);
				}
				if (dictionary.ContainsKey(getString_0(107408239)))
				{
					@class.Srid = Convert.ToUInt32(dictionary[getString_0(107408239)]);
				}
				list_0.Add(@class);
			}
		}
	}

	static Class71()
	{
		Strings.CreateGetStringDelegate(typeof(Class71));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397727), getString_0(107397722)).Replace(getString_0(107397685), getString_0(107397680)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397675)))
		{
			throw new SecurityException(getString_0(107397650));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_2, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
}
