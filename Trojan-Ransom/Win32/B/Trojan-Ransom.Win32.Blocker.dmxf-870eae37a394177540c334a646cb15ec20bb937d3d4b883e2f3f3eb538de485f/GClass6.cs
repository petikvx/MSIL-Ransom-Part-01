using System;
using System.Deployment.Internal;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.TCEAdapterGen;
using System.Runtime.Remoting.Contexts;
using System.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class GClass6
{
	public delegate object GDelegate12();

	public delegate char GDelegate13(int data);

	public delegate int GDelegate14(char data);

	public delegate string[] GDelegate15(string data, string delimiter, int arg1, CompareMethod arg2);

	internal static GDelegate13 SdX89sCaUxzgmGO = (GDelegate13)wjkh();

	internal static GDelegate14 Pq110KGRix = (GDelegate14)wjkh2();

	internal static GDelegate15 crYe120MpRCSWYQpSwh = (GDelegate15)splet();

	public static string smethod_0(string Xwli78faDTl, string fmRe79ISnBoaC)
	{
		string text = null;
		int num = 0;
		checked
		{
			int num2 = fmRe79ISnBoaC.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				num += Convert.ToInt32(fmRe79ISnBoaC[i]);
			}
			int num3 = unchecked((int)Xwli78faDTl[0]) - num;
			int j = 0;
			for (int length = Xwli78faDTl.Length; j < length; j++)
			{
				char c = Xwli78faDTl[j];
				int num4 = unchecked((int)c) - num3;
				text += Conversions.ToString(Strings.ChrW(num4));
			}
			text = text.Remove(0, 1);
			char[] array = Conversions.ToCharArrayRankOne(text.ToString());
			Array.Reverse((Array)array);
			return new string(array);
		}
	}

	public static object smethod_1()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(GClass2.Penny9());
		object obj = crYe120MpRCSWYQpSwh(Conversions.ToString(objectValue), "@", -1, (CompareMethod)0)[4];
		return Strings.Replace(Conversions.ToString(obj), GClass2.OkUf55uDsYTUSXIBI, "@", 1, -1, (CompareMethod)0);
	}

	public static object zSr96VjrsCaUxzg()
	{
		return GClass7.turt9();
	}

	public static object wjkh()
	{
		return (GDelegate13)Delegate.CreateDelegate(typeof(GDelegate13), Type.GetType("System.ConvertbX1ltjPYYXbyGNr".Substring(0, 14))!.GetMethod("ToCharzSr96VjrsCaUxzg".Substring(0, 6), new Type[1] { typeof(int) }));
	}

	public static object wjkh2()
	{
		return (GDelegate14)Delegate.CreateDelegate(typeof(GDelegate14), typeof(Convert).GetMethod("ToInt32", new Type[1] { typeof(char) }));
	}

	public static object splet()
	{
		return (GDelegate15)Delegate.CreateDelegate(typeof(GDelegate15), (MethodInfo)NewLateBinding.LateGet(spletType(), (Type)null, "GetMethod", new object[2]
		{
			"Split",
			new Type[4]
			{
				typeof(string),
				typeof(string),
				typeof(int),
				typeof(CompareMethod)
			}
		}, (string[])null, (Type[])null, (bool[])null));
	}

	private static object spletType()
	{
		return typeof(Strings);
	}

	static SecurityTransparentAttribute BGqxFVwvMCEvVxc()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static NotImplementedException QxmHxoCMuuiiJSe()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static Resolver KdJgyLywqJGcMXc()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static DllImportAttribute ParsOQZwdHXEKdl()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static IContributeClientContextSink GlhhglWPWBbNdgj()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static ParsingInfo QpSxhdRmcThraaN()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static InternalActivationContextHelper pRnzOvNyDcROIaX()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static FileAccess jGekgruKfgqzuYo()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static ApplicationState wRkeUzJJINxqxcp()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static TCEAdapterGenerator rIMOGfumXFHbEJW()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static Stream.SyncStream XsGsfHdbElDosSs()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}
}
