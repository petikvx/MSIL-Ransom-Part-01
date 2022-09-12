using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hex_Hub.Skin;
using Memory;
using Siticone.UI.WinForms;
using Y5Xx4QmcSB6oi5mC3f;

namespace Hex_Hub;

public class Form2 : Form
{
	public struct ProcessEntry32
	{
		public uint dwSize;

		public uint cntUsage;

		public uint th32ProcessID;

		public IntPtr th32DefaultHeapID;

		public uint th32ModuleID;

		public uint cntThreads;

		public uint th32ParentProcessID;

		public int pcPriClassBase;

		public uint dwFlags;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string szExeFile;
	}

	private string Esnc84undx;

	public string userName;

	public string GagaPath;

	private bool xFCcxgoRca;

	private string MSmcCJ5JHU;

	public long enumerable;

	private int wsbcVAm01S;

	public Mem MemLib;

	private static string KoQcTJrWvO;

	private IContainer VX3cEqJBe4;

	private IContainer T44c7f3yEF;

	private PictureBox VRGcuG7i5q;

	private MonoFlat_Button ANpcrMbeFf;

	private MonoFlat_Button UNucPmURXO;

	private MonoFlat_RadioButton SVPcZyghFe;

	private MonoFlat_RadioButton WFwcJbspBK;

	private MonoFlat_RadioButton OLlcmEPxwl;

	private MonoFlat_Button jWAcLMVB3W;

	private MonoFlat_ThemeContainer nRVcN9aZGQ;

	private MonoFlat_Toggle wdAcMYZ9Pc;

	private Label EgLc2hJsIq;

	private Label JcpcbklFMo;

	private MonoFlat_RadioButton zcZcaZ7t1w;

	private Label MgxcDW0TsH;

	private Label C8xc61ZICL;

	private MonoFlat_Button LYIcARIlOx;

	private SiticoneControlBox jD8cGMXYde;

	private SiticoneControlBox jxUc9OpQMN;

	private Label Il2cWOND75;

	private static Form2 aRyEQSRx8Jc3av2ault;

	[DllImport("kernel32.dll")]
	public static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);

	[DllImport("kernel32.dll")]
	public static extern int Process32First(IntPtr handle, ref ProcessEntry32 pe);

	[DllImport("kernel32.dll")]
	public static extern int Process32Next(IntPtr handle, ref ProcessEntry32 pe);

	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CPutTaskDelay_003Ed__8))]
	private Task bSBcY6oi5m(int int_0)
	{
		return null;
	}

	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003Cmethod_0_003Ed__9))]
	private Task<IntPtr> v3fcKvWiTM()
	{
		return null;
	}

	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CXtremeService_003Ed__11))]
	public void XtremeService()
	{
	}

	[AsyncStateMachine(typeof(_003CBypass_003Ed__13))]
	[DebuggerStepThrough]
	public void Bypass()
	{
	}

	public void patch()
	{
	}

	[AsyncStateMachine(typeof(_003CmonoFlat_Button2_Click_003Ed__20))]
	[DebuggerStepThrough]
	private void gS3cnPiUyk(object sender, EventArgs e)
	{
	}

	private void WYocpG6OlS(object sender, EventArgs e)
	{
	}

	private void dGcce6tGNY(object sender, EventArgs e)
	{
	}

	private void PUJcIgsZ0x()
	{
	}

	private void h1CcU6eq4R(object sender, EventArgs e)
	{
	}

	private void Q38c4qBUcu(object sender, EventArgs e)
	{
	}

	private void rnvcfdELOG(object sender, EventArgs e)
	{
	}

	private void pETcwuyHka(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void NqRctbqJdL()
	{
	}

	static Form2()
	{
		wpamenJan8gnAqcZW4.VALhGg5nfr();
		VXcYefve2auf3wfUUvs();
	}

	internal static void o03sH1Ra252yRfbUPQH()
	{
	}

	internal static object HKxx81RP7AZdI2nteW1(int int_0)
	{
		return null;
	}

	internal static object F1tFFARqZoBkoK56SSD()
	{
		return null;
	}

	internal static bool EAuEvHRnQw3g6DcKGMs()
	{
		return true;
	}

	internal static Form2 jHeQOTRfJ6VKkd0rcRc()
	{
		return null;
	}

	internal static AsyncTaskMethodBuilder cJjRpyRbWr3YxIGYUQX()
	{
		return (AsyncTaskMethodBuilder)(object)null;
	}

	internal static AsyncVoidMethodBuilder u8VufrRmj65PjNWK3vI()
	{
		return (AsyncVoidMethodBuilder)(object)null;
	}

	internal static void p596OZRN08086fUJqMM(object object_0, object object_1)
	{
	}

	internal static void tHtgTQRkPj3VPKx6a11(object object_0, bool bool_0)
	{
	}

	internal static void FOAnvsRAscRa26tp9Xi(object object_0, bool bool_0)
	{
	}

	internal static bool x6VR8mRhSxXYdRDTs3j(object object_0)
	{
		return true;
	}

	internal static void uhXxmjRUnnPn7anfO8u(object object_0, object object_1)
	{
	}

	internal static object WJlCVxRItVs7qs9Dypb(object object_0)
	{
		return null;
	}

	internal static object coCMfKRrdtPiDwqx2TT(object object_0, object object_1)
	{
		return null;
	}

	internal static void xfAyhTRwiQoYKKdec00(object object_0)
	{
	}

	internal static void ha5U2wRZnh4csE2w2B2(object object_0)
	{
	}

	internal static void A9PIJDRo36pQV967JeF(object object_0)
	{
	}

	internal static void Fgex7mR0gfgxBrStwGK(object object_0, object object_1, object object_2)
	{
	}

	internal static object KJr6gnRdGNR2dNN2yMh(object object_0)
	{
		return null;
	}

	internal static void CwFYHxRLNk7MQLs8Ul9(object object_0, bool bool_0)
	{
	}

	internal static object tNN0XRREeqUqOToZ0lf(object object_0)
	{
		return null;
	}

	internal static void f7A0PaRW1VU7QZZIfeF(object object_0)
	{
	}

	internal static void VD6iK3R6jtncaCuHZSW(object object_0, ProcessWindowStyle processWindowStyle_0)
	{
	}

	internal static void Il5KMuRjVS7y6wHR6Qc(object object_0, object object_1)
	{
	}

	internal static void xgpdWlR4W88DprJyvLl(object object_0, object object_1)
	{
	}

	internal static DialogResult T3DBNhR23BgvMe9Ilxf(object object_0, object object_1, MessageBoxButtons messageBoxButtons_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	internal static object JuGJcHRgnKP1jH8aVdH(object object_0, object object_1)
	{
		return null;
	}

	internal static object l9xlEwR3PKvBqZqupwQ(object object_0, object object_1)
	{
		return null;
	}

	internal static object pRGnlNRMxJZxTQH2rPN(object object_0)
	{
		return null;
	}

	internal static DialogResult mtManaRpCKt2Muu44X4(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	internal static object rjyYj9RO1AU5DxvZSuY(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static object NQBWU1R8F8XHJ7Fq2M8(object object_0)
	{
		return null;
	}

	internal static object vsfUf7RQytub2CfXi4e(object object_0, object object_1)
	{
		return null;
	}

	internal static bool BEjSksRGDOcgEY12HTG(object object_0)
	{
		return true;
	}

	internal static Color iEVBjYRyJ4m7iBDDxvH()
	{
		return (Color)(object)null;
	}

	internal static void b4joriRcopJq94sKLWw(object object_0, Color color_0)
	{
	}

	internal static void NNKOknRY2eiw3FnSigD(object object_0, object object_1)
	{
	}

	internal static object wFK6clRe7ZOt9xNkVyi(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static Color ykCMfaRuVxpPcrAQcBm()
	{
		return (Color)(object)null;
	}

	internal static object almblNRHkGsROa7CKjc(object object_0)
	{
		return null;
	}

	internal static bool r14vQTR5Voaa8YL54bM(object object_0)
	{
		return true;
	}

	internal static void HyfZEKRJoMhAE3BlrMs(object object_0)
	{
	}

	internal static void JrWVq1RtogYuK7JF05r(object object_0, object object_1)
	{
	}

	internal static void bePSGIRsdUZJ9r33mNk(int int_0)
	{
	}

	internal static void y9I3ulRCcAkCoUxUUMm(object object_0)
	{
	}

	internal static void G0ADihR1CLKEYPl4uPi(object object_0)
	{
	}

	internal static void BGHhq8RiVLaQvqKiAMB(object object_0, bool bool_0)
	{
	}

	internal static RuntimeTypeHandle Wkmi5NRKo81hWnm49Pc(int token)
	{
		return (RuntimeTypeHandle)(object)null;
	}

	internal static Type URlTmvRDnq89POTctjC(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return null;
	}

	internal static void vIwpdyR7E80nECoUNKF(object object_0)
	{
	}

	internal static void BwEPeDRXQOaZciv4bPc(object object_0, object object_1)
	{
	}

	internal static void Yg2etcRzvlcSpXHfrpe(object object_0, Point point_0)
	{
	}

	internal static void PlByjSvS1Gah9aMR1t4(object object_0, Padding padding_0)
	{
	}

	internal static void XA5MByvVrdZNd0xANMa(object object_0, object object_1)
	{
	}

	internal static void yPePkovBn23o5gupcaP(object object_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
	}

	internal static void NJFVw7v96QitKA1nfBG(object object_0, int int_0)
	{
	}

	internal static Color iIqoowvRMtZnlMXlRWc()
	{
		return (Color)(object)null;
	}

	internal static void VTZrruvvSloqIF2mMuG(object object_0, Color color_0)
	{
	}

	internal static void fcAlGQvluQy55NLSxxW(object object_0, object object_1)
	{
	}

	internal static void hsK7TGvTY4Ajk1ZdAUG(object object_0, ContentAlignment value)
	{
	}

	internal static void Dj0vtXvFTCJi8rGpNcY(object object_0, Size size_0)
	{
	}

	internal static void RIsrKkvxVb9TOBIvKXf(object object_0, int int_0)
	{
	}

	internal static void Aa4Z7gvn1jNBcJBZrSh(object object_0, StringAlignment value)
	{
	}

	internal static void Pt9f4pvfVoOIQwyX5hM(object object_0, object object_1)
	{
	}

	internal static void LXRuwRva3hcsa6QTaYD(object object_0, bool value)
	{
	}

	internal static Color Bwstc1vPnAAxZWngyeC(int int_0, int int_1, int int_2)
	{
		return (Color)(object)null;
	}

	internal static void v2XFhJvqAu70cjxSp90(object object_0, object object_1)
	{
	}

	internal static object V1pNRFvb9bDtnPyy6Ee(object object_0)
	{
		return null;
	}

	internal static void hxUhGTvmaqKOCHk0cf2(object object_0, DockStyle dockStyle_0)
	{
	}

	internal static void KmAy2YvN03XJVc9Wa2k(object object_0, Padding padding_0)
	{
	}

	internal static void qXhqmJvkaFBpwDGgKh5(object object_0, bool value)
	{
	}

	internal static void pRc6RyvA0XFAepCXCZ9(object object_0, bool value)
	{
	}

	internal static void JX0pobvhEUgF974lT54(object object_0, bool value)
	{
	}

	internal static void TKj83DvUiFv4NXVdiUg(object object_0, FormStartPosition value)
	{
	}

	internal static void hVwSHRvIw5Kf2h2o9iE(object object_0, object object_1)
	{
	}

	internal static void VmbvlovrsBP1ql0Hucv(object object_0, bool bool_0)
	{
	}

	internal static Color s5lncovwdPj1qKqb5sp()
	{
		return (Color)(object)null;
	}

	internal static void fEBkjSvZlyU2VP3m9Pp(object object_0, AnchorStyles anchorStyles_0)
	{
	}

	internal static void kegm5PvoqNwYfrNiUCk(object object_0, Color color_0)
	{
	}

	internal static object o1OxoSv0ciKGXnSPvex(object object_0)
	{
		return null;
	}

	internal static void sB63ZLvd3L8WHAMQglc(object object_0, object object_1)
	{
	}

	internal static Color Bx899ZvLjYTEsSaxKny()
	{
		return (Color)(object)null;
	}

	internal static void ordhmvvE0vXyfk3baCI(object object_0, Color color_0)
	{
	}

	internal static object lVyc0fvWD9y7NpRpv9S(object object_0)
	{
		return null;
	}

	internal static void x5JWKpv6a9cyRWSOkEl(object object_0, bool value)
	{
	}

	internal static void zIHsfIvj5DAawkGm1PB(object object_0, MonoFlat_Toggle._Type value)
	{
	}

	internal static void g2OOZNv45WTSPVC86V0(object object_0, object object_1)
	{
	}

	internal static void XJoQElv28FHVCq77mK5(object object_0, SizeF sizeF_0)
	{
	}

	internal static void byJK2vvgxcPBPchZbcP(object object_0, AutoScaleMode autoScaleMode_0)
	{
	}

	internal static void o0RLpCv3U3R4uHR6sfO(object object_0, Size size_0)
	{
	}

	internal static object fbfXuyvMi50vuMhCm1G(object object_0)
	{
		return null;
	}

	internal static void mPoH4ivpB0YuK5YJDfh(object object_0, FormBorderStyle formBorderStyle_0)
	{
	}

	internal static object VdCmvivOR1Ft1J4ajj8(object object_0, object object_1)
	{
		return null;
	}

	internal static void vT2iEnv8TCV0g5CBWXv(object object_0, object object_1)
	{
	}

	internal static void GMQrmHvQMnNpal28yrc(object object_0, Padding padding_0)
	{
	}

	internal static void Sy3O9FvGQrw20phJD8V(object object_0, object object_1)
	{
	}

	internal static Color WKSrSovypjk9HDN8IGH()
	{
		return (Color)(object)null;
	}

	internal static void xpAWsHvcZei9UBhGZCA(object object_0, bool bool_0)
	{
	}

	internal static void Dp83PavYkseWbrehZen(object object_0)
	{
	}

	internal static void VXcYefve2auf3wfUUvs()
	{
	}
}
