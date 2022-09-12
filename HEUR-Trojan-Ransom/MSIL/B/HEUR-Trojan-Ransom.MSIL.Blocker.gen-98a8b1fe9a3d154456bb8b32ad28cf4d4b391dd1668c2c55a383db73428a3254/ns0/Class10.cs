using System;
using System.Collections;
using System.Reflection;
using System.Runtime.Remoting;

namespace ns0;

internal sealed class Class10
{
	internal sealed class Class11
	{
		internal ArrayList arrayList_0 = new ArrayList();

		internal ArrayList arrayList_1 = new ArrayList();

		internal string string_0;

		internal string string_1;

		internal Hashtable hashtable_0;

		internal bool bool_0;

		internal Class11(string string_2, string string_3, Hashtable hashtable_1)
		{
			string_0 = string_2;
			string_1 = string_3;
			hashtable_0 = hashtable_1;
		}
	}

	internal sealed class Class12
	{
		internal string string_0;

		internal string string_1;

		internal string string_2;

		internal Class12(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_1 = string_4;
			string_2 = string_5;
		}
	}

	internal sealed class Class13
	{
		internal string string_0;

		internal string string_1;

		internal Hashtable hashtable_0;

		internal Class13(string string_2, string string_3, Hashtable hashtable_1)
		{
			string_0 = string_2;
			string_1 = string_3;
			hashtable_0 = hashtable_1;
		}
	}

	internal sealed class Class14
	{
		internal string string_0;

		internal string string_1;

		internal string string_2;

		internal string string_3;

		internal Class14(string string_4, string string_5, string string_6, string string_7)
		{
			string_0 = string_4;
			string_1 = string_5;
			string_2 = string_6;
			string_3 = string_7;
		}
	}

	internal sealed class Class15
	{
		internal CustomErrorsModes customErrorsModes_0;

		internal Class15(CustomErrorsModes customErrorsModes_1)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			customErrorsModes_0 = customErrorsModes_1;
		}
	}

	internal sealed class Class16
	{
		internal string string_0;

		internal string string_1;

		internal string string_2;

		internal string string_3;

		internal Class16(string string_4, string string_5, string string_6, string string_7)
		{
			string_0 = string_4;
			string_1 = string_5;
			string_2 = string_6;
			string_3 = string_7;
		}
	}

	internal sealed class Class17
	{
		internal bool bool_0;

		internal bool bool_1;

		internal bool bool_2;

		internal bool bool_3;

		private TimeSpan timeSpan_0;

		private TimeSpan timeSpan_1;

		private TimeSpan timeSpan_2;

		internal TimeSpan timeSpan_3;

		internal TimeSpan TimeSpan_0
		{
			get
			{
				return timeSpan_0;
			}
			set
			{
				timeSpan_0 = value;
				bool_0 = true;
			}
		}

		internal TimeSpan TimeSpan_1
		{
			get
			{
				return timeSpan_3;
			}
			set
			{
				TimeSpan timeSpan = (timeSpan_3 = value);
				bool_1 = true;
			}
		}

		internal TimeSpan TimeSpan_2
		{
			get
			{
				return timeSpan_1;
			}
			set
			{
				timeSpan_1 = value;
				bool_2 = true;
			}
		}

		internal TimeSpan TimeSpan_3
		{
			get
			{
				return timeSpan_2;
			}
			set
			{
				timeSpan_2 = value;
				bool_3 = true;
			}
		}
	}

	internal sealed class Class18
	{
		internal string string_0;

		internal string string_1;

		public Class18(string string_2, string string_3)
		{
			string_0 = string_2;
			string_1 = string_3;
		}
	}

	internal sealed class Class19
	{
		internal ArrayList arrayList_0 = new ArrayList();

		internal ArrayList arrayList_1 = new ArrayList();

		internal string string_0;

		internal Class19(string string_1)
		{
			string_0 = string_1;
		}

		internal void method_0(string string_1, string string_2, string string_3)
		{
			arrayList_0.Add(new Class12(string_1, string_2, string_3));
		}

		internal void method_1(string string_1, string string_2, ArrayList arrayList_2)
		{
			arrayList_1.Add(new Class21(string_1, string_2, arrayList_2));
		}
	}

	internal sealed class Class22 : Class21
	{
		internal string string_2;

		internal WellKnownObjectMode wellKnownObjectMode_0;

		internal Class22(string string_3, string string_4, ArrayList arrayList_1, string string_5, WellKnownObjectMode wellKnownObjectMode_1)
			: base(string_3, string_4, arrayList_1)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			string_2 = string_5;
			wellKnownObjectMode_0 = wellKnownObjectMode_1;
		}
	}

	internal sealed class Class20
	{
		internal ArrayList arrayList_0 = new ArrayList();

		internal string string_0;

		internal string string_1;

		internal Hashtable hashtable_0;

		internal bool bool_0;

		internal Class20(string string_2, string string_3, Hashtable hashtable_1, bool bool_1)
		{
			string_0 = string_2;
			string_1 = string_3;
			hashtable_0 = hashtable_1;
			bool_0 = bool_1;
		}
	}

	internal class Class21
	{
		internal string string_0;

		internal string string_1;

		internal ArrayList arrayList_0;

		internal Class21(string string_2, string string_3, ArrayList arrayList_1)
		{
			string_0 = string_2;
			string_1 = string_3;
			arrayList_0 = arrayList_1;
		}
	}

	internal bool bool_0;

	internal ArrayList arrayList_0 = new ArrayList();

	internal ArrayList arrayList_1 = new ArrayList();

	internal ArrayList arrayList_2 = new ArrayList();

	internal ArrayList arrayList_3 = new ArrayList();

	internal ArrayList arrayList_4 = new ArrayList();

	internal ArrayList arrayList_5 = new ArrayList();

	internal ArrayList arrayList_6 = new ArrayList();

	internal static volatile bool bool_1;

	internal string string_0;

	internal Class17 class17_0;

	internal Class15 class15_0;

	internal static string smethod_0()
	{
		return Class8.smethod_1() + "ma";
	}

	internal void method_0(string string_1, string string_2, string string_3, string string_4)
	{
		arrayList_1.Add(new Class14(string_1, string_2, string_3, string_4));
	}

	internal void method_1(string string_1, string string_2, string string_3, string string_4)
	{
		arrayList_2.Add(new Class16(string_1, string_2, string_3, string_4));
	}

	internal void method_2(string string_1, string string_2)
	{
		arrayList_3.Add(new Class18(string_1, string_2));
	}

	internal Class19 method_3(string string_1)
	{
		Class19 @class = new Class19(string_1);
		arrayList_4.Add(@class);
		return @class;
	}

	internal void method_4(string string_1, string string_2, ArrayList arrayList_7)
	{
		arrayList_5.Add(new Class21(string_1, string_2, arrayList_7));
	}

	internal static bool smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0, out Assembly assembly_0)
	{
		AppDomain appDomain_ = (AppDomain)object_0;
		if (Class8.smethod_0(resolveEventArgs_0, out assembly_0, appDomain_))
		{
			return true;
		}
		assembly_0 = null;
		return false;
	}

	internal Class22 method_5(string string_1, string string_2, ArrayList arrayList_7, string string_3, WellKnownObjectMode wellKnownObjectMode_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		Class22 @class = new Class22(string_1, string_2, arrayList_7, string_3, wellKnownObjectMode_0);
		arrayList_6.Add(@class);
		return @class;
	}
}
