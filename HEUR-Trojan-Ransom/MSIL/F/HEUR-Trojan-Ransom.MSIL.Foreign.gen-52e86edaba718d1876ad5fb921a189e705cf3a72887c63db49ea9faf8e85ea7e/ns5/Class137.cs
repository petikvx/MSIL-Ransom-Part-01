using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns21;
using ns4;
using ns6;

namespace ns5;

internal sealed class Class137
{
	private static Dictionary<string, string> dictionary_0;

	private static Dictionary<string, int> dictionary_1;

	private static Dictionary<string, Class138> dictionary_2;

	private static readonly object object_0;

	[NonSerialized]
	internal static GetString getString_0;

	static Class137()
	{
		Strings.CreateGetStringDelegate(typeof(Class137));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398243), getString_0(107398238)).Replace(getString_0(107398201), getString_0(107398196)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398191)))
		{
			throw new SecurityException(getString_0(107398166));
		}
		object_0 = new object();
		smethod_2();
	}

	public static Class138 smethod_0(Struct23 struct23_0, string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(getString_0(107356441));
		}
		Class138 @class = null;
		if (dictionary_2.ContainsKey(string_0))
		{
			@class = dictionary_2[string_0];
		}
		if (@class == null)
		{
			throw new NotSupportedException(getString_0(107356412) + string_0 + getString_0(107356423));
		}
		return @class;
	}

	public static Encoding smethod_1(Struct23 struct23_0, string string_0)
	{
		try
		{
			return Encoding.GetEncoding(smethod_0(struct23_0, string_0).string_0);
		}
		catch (ArgumentException)
		{
			return Encoding.GetEncoding(getString_0(107365709));
		}
		catch (NotSupportedException)
		{
			return Encoding.GetEncoding(getString_0(107365709));
		}
	}

	private static void smethod_2()
	{
		smethod_3();
	}

	private static void smethod_3()
	{
		dictionary_2 = new Dictionary<string, Class138>();
		dictionary_2.Add(getString_0(107356338), new Class138(getString_0(107356361), 1));
		dictionary_2.Add(getString_0(107355800), new Class138(getString_0(107355800), 2));
		dictionary_2.Add(getString_0(107355791), dictionary_2[getString_0(107356338)]);
		dictionary_2.Add(getString_0(107355814), new Class138(getString_0(107355773), 1));
		dictionary_2.Add(getString_0(107355764), dictionary_2[getString_0(107356338)]);
		dictionary_2.Add(getString_0(107355759), new Class138(getString_0(107355782), 1));
		dictionary_2.Add(getString_0(107355741), new Class138(getString_0(107355741), 1));
		dictionary_2.Add(getString_0(107355732), dictionary_2[getString_0(107356338)]);
		dictionary_2.Add(getString_0(107355755), new Class138(getString_0(107355746), 3));
		dictionary_2.Add(getString_0(107355705), dictionary_2[getString_0(107355755)]);
		dictionary_2.Add(getString_0(107355724), new Class138(getString_0(107355724), 2));
		dictionary_2.Add(getString_0(107355715), dictionary_2[getString_0(107355724)]);
		dictionary_2.Add(getString_0(107355674), new Class138(getString_0(107355674), 1));
		dictionary_2.Add(getString_0(107355665), new Class138(getString_0(107355688), 1));
		dictionary_2.Add(getString_0(107355639), new Class138(getString_0(107355630), 2));
		dictionary_2.Add(getString_0(107355653), dictionary_2[getString_0(107355639)]);
		dictionary_2.Add(getString_0(107355612), new Class138(getString_0(107355782), 1));
		dictionary_2.Add(getString_0(107355603), dictionary_2[getString_0(107355612)]);
		dictionary_2.Add(getString_0(107355622), new Class138(getString_0(107355622), 2));
		dictionary_2.Add(getString_0(107355581), dictionary_2[getString_0(107355622)]);
		dictionary_2.Add(getString_0(107355576), new Class138(getString_0(107355576), 1));
		dictionary_2.Add(getString_0(107355567), new Class138(getString_0(107355590), 1));
		dictionary_2.Add(getString_0(107356053), dictionary_2[getString_0(107355567)]);
		dictionary_2.Add(getString_0(107356072), new Class138(getString_0(107356072), 1));
		dictionary_2.Add(getString_0(107356063), dictionary_2[getString_0(107356338)]);
		dictionary_2.Add(getString_0(107356018), new Class138(getString_0(107365709), 3));
		dictionary_2.Add(getString_0(107356041), new Class138(getString_0(107356032), 2));
		dictionary_2.Add(getString_0(107355987), new Class138(getString_0(107355987), 1));
		dictionary_2.Add(getString_0(107356010), dictionary_2[getString_0(107356338)]);
		dictionary_2.Add(getString_0(107355965), new Class138(getString_0(107355956), 1));
		dictionary_2.Add(getString_0(107355975), new Class138(getString_0(107355930), 1));
		dictionary_2.Add(getString_0(107355941), new Class138(getString_0(107355900), 2));
		dictionary_2.Add(getString_0(107355891), new Class138(getString_0(107355914), 1));
		dictionary_2.Add(getString_0(107355865), new Class138(getString_0(107355856), 1));
		dictionary_2.Add(getString_0(107355871), dictionary_2[getString_0(107355865)]);
		dictionary_2.Add(getString_0(107355822), dictionary_2[getString_0(107355865)]);
		dictionary_2.Add(getString_0(107355293), dictionary_2[getString_0(107355865)]);
		dictionary_2.Add(getString_0(107355308), dictionary_2[getString_0(107355865)]);
		dictionary_2.Add(getString_0(107355295), new Class138(getString_0(107355295), 1));
		dictionary_2.Add(getString_0(107355254), new Class138(getString_0(107355277), 1));
		dictionary_2.Add(getString_0(107355228), new Class138(getString_0(107355219), 1));
		dictionary_2.Add(getString_0(107355238), dictionary_2[getString_0(107355228)]);
		dictionary_2.Add(getString_0(107407214), dictionary_2[getString_0(107355228)]);
		dictionary_2.Add(getString_0(107355197), new Class138(getString_0(107355197), 1));
		dictionary_2.Add(getString_0(107355188), new Class138(getString_0(107355188), 1));
		dictionary_2.Add(getString_0(107355211), new Class138(getString_0(107355198), 1));
		dictionary_2.Add(getString_0(107355181), new Class138(getString_0(107355198), 1));
		dictionary_2.Add(getString_0(107355168), new Class138(getString_0(107355198), 1));
		dictionary_2.Add(getString_0(107355127), new Class138(getString_0(107355118), 1));
		dictionary_2.Add(getString_0(107355101), new Class138(getString_0(107355118), 1));
		dictionary_2.Add(getString_0(107355088), new Class138(getString_0(107355118), 1));
		dictionary_2.Add(getString_0(107355111), new Class138(getString_0(107355066), 1));
		dictionary_2.Add(getString_0(107355081), new Class138(getString_0(107355066), 1));
		dictionary_2.Add(getString_0(107355548), new Class138(getString_0(107355066), 1));
		dictionary_2.Add(getString_0(107355535), new Class138(getString_0(107355562), 1));
		dictionary_2.Add(getString_0(107407473), new Class138(getString_0(107365709), 4));
		dictionary_2.Add(getString_0(107355553), new Class138(getString_0(107355512), 2));
		dictionary_2.Add(getString_0(107355531), new Class138(getString_0(107355518), 2));
		dictionary_2.Add(getString_0(107355477), new Class138(getString_0(107355500), 4));
		dictionary_2.Add(getString_0(107355487), new Class138(getString_0(107355487), 4));
	}

	internal static void smethod_4(Class139 class139_0)
	{
		dictionary_0 = new Dictionary<string, string>();
		dictionary_1 = new Dictionary<string, int>();
		using Class142 @class = new MySqlCommand(getString_0(107355442), class139_0).method_6();
		while (@class.Read())
		{
			dictionary_0.Add(@class.GetString(0), @class.GetString(2));
			dictionary_1.Add(@class.GetString(0), Convert.ToInt32(@class.GetValue(3)));
		}
	}

	internal static string smethod_5(string string_0, Class139 class139_0)
	{
		lock (object_0)
		{
			if (dictionary_0 == null)
			{
				smethod_4(class139_0);
			}
		}
		if (dictionary_0.ContainsKey(string_0))
		{
			return dictionary_0[string_0];
		}
		return null;
	}

	internal static int smethod_6(string string_0, Class139 class139_0)
	{
		lock (object_0)
		{
			if (dictionary_1 == null)
			{
				smethod_4(class139_0);
			}
		}
		if (dictionary_1.ContainsKey(string_0))
		{
			return dictionary_1[string_0];
		}
		return 1;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
