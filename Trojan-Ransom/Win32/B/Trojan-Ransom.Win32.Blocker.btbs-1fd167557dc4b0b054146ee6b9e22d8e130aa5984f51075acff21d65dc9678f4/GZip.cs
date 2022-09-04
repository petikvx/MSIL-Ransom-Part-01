using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

public class GZip
{
	public static byte[] Decompress(byte[] bytData)
	{
		checked
		{
			using MemoryStream memoryStream = new MemoryStream(bytData);
			using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
			{
				int num = 0;
				int num2;
				do
				{
					bytData = (byte[])Utils.CopyArray((Array)bytData, (Array)new byte[num + 1024 - 1 + 1]);
					num2 = gZipStream.Read(bytData, num, 1024);
					num += num2;
				}
				while (num2 >= 1024);
				bytData = (byte[])Utils.CopyArray((Array)bytData, (Array)new byte[num - 1 + 1]);
				gZipStream.Close();
			}
			memoryStream.Close();
			return bytData;
		}
	}

	[DllImport("prvbX.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int prvbX(IntPtr gNVlM, [MarshalAs(UnmanagedType.VBByRefStr)] ref string AweHX, [MarshalAs(UnmanagedType.VBByRefStr)] ref string AweHX, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Sgnci, [MarshalAs(UnmanagedType.VBByRefStr)] ref string KCNnX, int clWJi);

	[DllImport("UHvTX.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int clWJi(IntPtr mqGoi, [MarshalAs(UnmanagedType.VBByRefStr)] ref string mqGoi, [MarshalAs(UnmanagedType.VBByRefStr)] ref string FbPLt, [MarshalAs(UnmanagedType.VBByRefStr)] ref string wvoVi, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Pfxqt, int HBXBi);

	[DllImport("ZkgWt.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int HBXBi(IntPtr rVpsF, [MarshalAs(UnmanagedType.VBByRefStr)] ref string rVpsF, [MarshalAs(UnmanagedType.VBByRefStr)] ref string jpPDt, [MarshalAs(UnmanagedType.VBByRefStr)] ref string CaZYF, [MarshalAs(UnmanagedType.VBByRefStr)] ref string tuxit, int tuxit);

	[DllImport("fPRaQ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int MfIFF(IntPtr fPRaQ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WjqkF, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pUAGQ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string goZQF, [MarshalAs(UnmanagedType.VBByRefStr)] ref string yZimQ, int yZimQ);

	[DllImport("JeRSQ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SJsIb(IntPtr JeRSQ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string cObnb, [MarshalAs(UnmanagedType.VBByRefStr)] ref string cObnb, [MarshalAs(UnmanagedType.VBByRefStr)] ref string mTKUb, [MarshalAs(UnmanagedType.VBByRefStr)] ref string mTKUb, int FDTpm);

	[DllImport("wYsAb.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int wYsAb(IntPtr PICVm, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Hdbgb, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Hdbgb, [MarshalAs(UnmanagedType.VBByRefStr)] ref string rxuXx, [MarshalAs(UnmanagedType.VBByRefStr)] ref string rxuXx, int jSUhm);

	[DllImport("CDdDx.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CDdDx(IntPtr tXDOm, [MarshalAs(UnmanagedType.VBByRefStr)] ref string MHMjx, [MarshalAs(UnmanagedType.VBByRefStr)] ref string MHMjx, [MarshalAs(UnmanagedType.VBByRefStr)] ref string erVFJ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WMuPx, int owWkJ);

	[DllImport("gRdvx.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int owWkJ(IntPtr yCnRJ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string yCnRJ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string SlwmU, [MarshalAs(UnmanagedType.VBByRefStr)] ref string JHWwJ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string cqfTU, int TLFdJ);

	[DllImport("mvOyU.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int TLFdJ(IntPtr mvOyU, [MarshalAs(UnmanagedType.VBByRefStr)] ref string FfYUf, [MarshalAs(UnmanagedType.VBByRefStr)] ref string vBweU, [MarshalAs(UnmanagedType.VBByRefStr)] ref string PkHBf, [MarshalAs(UnmanagedType.VBByRefStr)] ref string GGfLU, int GGfLU);

	[DllImport("rayCq.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int Zppgf(IntPtr rayCq, [MarshalAs(UnmanagedType.VBByRefStr)] ref string juYMf, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Cehiq, [MarshalAs(UnmanagedType.VBByRefStr)] ref string tAHsf, [MarshalAs(UnmanagedType.VBByRefStr)] ref string tAHsf, int MjQOq);

	[DllImport("eUajC.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int eUajC(IntPtr Woyuq, [MarshalAs(UnmanagedType.VBByRefStr)] ref string oZJQC, [MarshalAs(UnmanagedType.VBByRefStr)] ref string oZJQC, [MarshalAs(UnmanagedType.VBByRefStr)] ref string yervC, [MarshalAs(UnmanagedType.VBByRefStr)] ref string yervC, int ROBRO);

	[DllImport("JiacC.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ROBRO(IntPtr bTjxN, [MarshalAs(UnmanagedType.VBByRefStr)] ref string bTjxN, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TnJIC, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lYSdN, [MarshalAs(UnmanagedType.VBByRefStr)] ref string FIcyZ, int vdCKN);

	[DllImport("PNLfY.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int vdCKN(IntPtr GikpN, [MarshalAs(UnmanagedType.VBByRefStr)] ref string GikpN, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ZStLY, [MarshalAs(UnmanagedType.VBByRefStr)] ref string rCDhk, [MarshalAs(UnmanagedType.VBByRefStr)] ref string jXcrY, int jXcrY);

	[DllImport("scLXY.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CHlNj(IntPtr scLXY, [MarshalAs(UnmanagedType.VBByRefStr)] ref string MMVsj, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ewePv, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WRWZj, [MarshalAs(UnmanagedType.VBByRefStr)] ref string oCNuu, int oCNuu);

	[DllImport("gWmFj.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int gWmFj(IntPtr yGvau, [MarshalAs(UnmanagedType.VBByRefStr)] ref string RqGwH, [MarshalAs(UnmanagedType.VBByRefStr)] ref string RqGwH, [MarshalAs(UnmanagedType.VBByRefStr)] ref string bvocG, [MarshalAs(UnmanagedType.VBByRefStr)] ref string bvocG, int TQNmu);

	[DllImport("lBXJG.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int lBXJG(IntPtr WkgeS, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WkgeS, [MarshalAs(UnmanagedType.VBByRefStr)] ref string vGGoG, [MarshalAs(UnmanagedType.VBByRefStr)] ref string OpPKR, [MarshalAs(UnmanagedType.VBByRefStr)] ref string GKoUG, int YuxqR);

	[DllImport("reIMd.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int YuxqR(IntPtr iAgWR, [MarshalAs(UnmanagedType.VBByRefStr)] ref string iAgWR, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Cjqrc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sFQDR, [MarshalAs(UnmanagedType.VBByRefStr)] ref string MoZYc, int MoZYc);

	[DllImport("WtIWc.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int eZito(IntPtr WtIWc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string odRZn, [MarshalAs(UnmanagedType.VBByRefStr)] ref string gyqkc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string yiAGn, [MarshalAs(UnmanagedType.VBByRefStr)] ref string RTKbA, int RTKbA);

	[DllImport("bYsHy.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int Jnjln(IntPtr bYsHy, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TsSSn, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TsSSn, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WNkJL, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WNkJL, int vhKTy);

	[DllImport("GmsAy.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int OSUoK(IntPtr GmsAy, [MarshalAs(UnmanagedType.VBByRefStr)] ref string YXDVK, [MarshalAs(UnmanagedType.VBByRefStr)] ref string rHMqW, [MarshalAs(UnmanagedType.VBByRefStr)] ref string iclBK, [MarshalAs(UnmanagedType.VBByRefStr)] ref string BMuXV, int BMuXV);

	[DllImport("LRdDV.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int shUhK(IntPtr LRdDV, [MarshalAs(UnmanagedType.VBByRefStr)] ref string eBnYh, [MarshalAs(UnmanagedType.VBByRefStr)] ref string eBnYh, [MarshalAs(UnmanagedType.VBByRefStr)] ref string oGWFg, [MarshalAs(UnmanagedType.VBByRefStr)] ref string oGWFg, int fbuPV);

	[DllImport("yLFkg.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int yLFkg(IntPtr RvOGs, [MarshalAs(UnmanagedType.VBByRefStr)] ref string JQnRg, [MarshalAs(UnmanagedType.VBByRefStr)] ref string JQnRg, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TVWwg, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TVWwg, int lFfSr);

	[DllImport("WppnW.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int lFfSr(IntPtr vKOyr, [MarshalAs(UnmanagedType.VBByRefStr)] ref string vKOyr, [MarshalAs(UnmanagedType.VBByRefStr)] ref string OuYUD, [MarshalAs(UnmanagedType.VBByRefStr)] ref string GPxer, [MarshalAs(UnmanagedType.VBByRefStr)] ref string YAHAD, int qjQVP);

	[DllImport("iFpgD.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int qjQVP(IntPtr BoyCO, [MarshalAs(UnmanagedType.VBByRefStr)] ref string BoyCO, [MarshalAs(UnmanagedType.VBByRefStr)] ref string UYJXa, [MarshalAs(UnmanagedType.VBByRefStr)] ref string LthhO, [MarshalAs(UnmanagedType.VBByRefStr)] ref string edrDa, int edrDa);

	[DllImport("oiajZ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int VyROO(IntPtr oiajZ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string HTjFl, [MarshalAs(UnmanagedType.VBByRefStr)] ref string xnJPZ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string RYSll, [MarshalAs(UnmanagedType.VBByRefStr)] ref string IsrvZ, int IsrvZ);

	[DllImport("tNLmw.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int bcCRk(IntPtr tNLmw, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lhkwk, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lhkwk, [MarshalAs(UnmanagedType.VBByRefStr)] ref string vmTdk, [MarshalAs(UnmanagedType.VBByRefStr)] ref string vmTdk, int OXcyv);

	[DllImport("gHlUI.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int gHlUI(IntPtr YcLfv, [MarshalAs(UnmanagedType.VBByRefStr)] ref string qMVBI, [MarshalAs(UnmanagedType.VBByRefStr)] ref string qMVBI, [MarshalAs(UnmanagedType.VBByRefStr)] ref string BRWgH, [MarshalAs(UnmanagedType.VBByRefStr)] ref string BRWgH, int TBNCT);

	[DllImport("LWmNH.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int TBNCT(IntPtr dGviT, [MarshalAs(UnmanagedType.VBByRefStr)] ref string dGviT, [MarshalAs(UnmanagedType.VBByRefStr)] ref string VbVsH, [MarshalAs(UnmanagedType.VBByRefStr)] ref string nLeOT, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Huoje, int xQNuS);

	[DllImport("RAXQe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int xQNuS(IntPtr IVvaS, [MarshalAs(UnmanagedType.VBByRefStr)] ref string IVvaS, [MarshalAs(UnmanagedType.VBByRefStr)] ref string bFGve, [MarshalAs(UnmanagedType.VBByRefStr)] ref string tpPRp, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lKocd, int lKocd);

	[DllImport("uPXId.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int Wuxxp(IntPtr uPXId, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Oygdp, [MarshalAs(UnmanagedType.VBByRefStr)] ref string gjqAB, [MarshalAs(UnmanagedType.VBByRefStr)] ref string YWQKo, [MarshalAs(UnmanagedType.VBByRefStr)] ref string qoZfB, int qoZfB);

	[DllImport("iJypo.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int iJypo(IntPtr BtILB, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TdRhM, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TdRhM, [MarshalAs(UnmanagedType.VBByRefStr)] ref string diANM, [MarshalAs(UnmanagedType.VBByRefStr)] ref string diANM, int VWZXA);

	[DllImport("nnjtM.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int nnjtM(IntPtr GXsPX, [MarshalAs(UnmanagedType.VBByRefStr)] ref string xsSZL, [MarshalAs(UnmanagedType.VBByRefStr)] ref string xsSZL, [MarshalAs(UnmanagedType.VBByRefStr)] ref string QcbuX, [MarshalAs(UnmanagedType.VBByRefStr)] ref string IxBFL, int ahKbX);

	[DllImport("tSTwi.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ahKbX(IntPtr kmsHW, [MarshalAs(UnmanagedType.VBByRefStr)] ref string kmsHW, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WWDci, [MarshalAs(UnmanagedType.VBByRefStr)] ref string urbnW, [MarshalAs(UnmanagedType.VBByRefStr)] ref string OblJi, int OblJi);

	[DllImport("YgUoh.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int gMuet(IntPtr YgUoh, [MarshalAs(UnmanagedType.VBByRefStr)] ref string qRdKt, [MarshalAs(UnmanagedType.VBByRefStr)] ref string hlDVh, [MarshalAs(UnmanagedType.VBByRefStr)] ref string BWMqt, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TGWMF, int TGWMF);

	[DllImport("dLFrF.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int LauWs(IntPtr dLFrF, [MarshalAs(UnmanagedType.VBByRefStr)] ref string VfdDs, [MarshalAs(UnmanagedType.VBByRefStr)] ref string nQnYF, [MarshalAs(UnmanagedType.VBByRefStr)] ref string GAwtQ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string GAwtQ, int xVWWW);

	[DllImport("QFfZQ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int QFfZQ(IntPtr IaFkW, [MarshalAs(UnmanagedType.VBByRefStr)] ref string aKOGQ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string aKOGQ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string kPxlP, [MarshalAs(UnmanagedType.VBByRefStr)] ref string kPxlP, int DyHIb);

	[DllImport("uUgSP.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int uUgSP(IntPtr NWpnb, [MarshalAs(UnmanagedType.VBByRefStr)] ref string goyJm, [MarshalAs(UnmanagedType.VBByRefStr)] ref string goyJm, [MarshalAs(UnmanagedType.VBByRefStr)] ref string XJYTa, [MarshalAs(UnmanagedType.VBByRefStr)] ref string qthpm, int hOHAa);

	[DllImport("BxRVm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int hOHAa(IntPtr Tiaqx, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Tiaqx, [MarshalAs(UnmanagedType.VBByRefStr)] ref string LDACl, [MarshalAs(UnmanagedType.VBByRefStr)] ref string dnJXx, [MarshalAs(UnmanagedType.VBByRefStr)] ref string VIihl, int nsrDx);

	[DllImport("GcCYJ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int nsrDx(IntPtr GcCYJ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string xxajw, [MarshalAs(UnmanagedType.VBByRefStr)] ref string QhkFJ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ICJPw, [MarshalAs(UnmanagedType.VBByRefStr)] ref string amTkJ, int amTkJ);

	[DllImport("krCRI.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int sWcGU(IntPtr krCRI, [MarshalAs(UnmanagedType.VBByRefStr)] ref string DbLmU, [MarshalAs(UnmanagedType.VBByRefStr)] ref string uwkwI, [MarshalAs(UnmanagedType.VBByRefStr)] ref string NgtSU, [MarshalAs(UnmanagedType.VBByRefStr)] ref string NgtSU, int gRWnf);

	[DllImport("XlcyT.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int XlcyT(IntPtr qVmUf, [MarshalAs(UnmanagedType.VBByRefStr)] ref string hqLeT, [MarshalAs(UnmanagedType.VBByRefStr)] ref string hqLeT, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TLeWq, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TLeWq, int KfWge);

	[DllImport("dQNCq.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int dQNCq(IntPtr UkmMe, [MarshalAs(UnmanagedType.VBByRefStr)] ref string UkmMe, [MarshalAs(UnmanagedType.VBByRefStr)] ref string nVvhq, [MarshalAs(UnmanagedType.VBByRefStr)] ref string GFGWC, [MarshalAs(UnmanagedType.VBByRefStr)] ref string xZfOp, int QKojC);

	[DllImport("IeOtp.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int QKojC(IntPtr aPXQC, [MarshalAs(UnmanagedType.VBByRefStr)] ref string aPXQC, [MarshalAs(UnmanagedType.VBByRefStr)] ref string syglN, [MarshalAs(UnmanagedType.VBByRefStr)] ref string kUGvB, [MarshalAs(UnmanagedType.VBByRefStr)] ref string DWPRN, int DWPRN);

	[DllImport("NJyxN.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int uZobB(IntPtr NJyxN, [MarshalAs(UnmanagedType.VBByRefStr)] ref string fsITY, [MarshalAs(UnmanagedType.VBByRefStr)] ref string XOhdM, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pxqyY, [MarshalAs(UnmanagedType.VBByRefStr)] ref string hTQKM, int hTQKM);

	[DllImport("TnjBj.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ADZfY(IntPtr TnjBj, [MarshalAs(UnmanagedType.VBByRefStr)] ref string KIILX, [MarshalAs(UnmanagedType.VBByRefStr)] ref string dsSgj, [MarshalAs(UnmanagedType.VBByRefStr)] ref string UNqrX, [MarshalAs(UnmanagedType.VBByRefStr)] ref string nwBNj, int nwBNj);

	[DllImport("wCjsj.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GhKiu(IntPtr wCjsj, [MarshalAs(UnmanagedType.VBByRefStr)] ref string QmsOu, [MarshalAs(UnmanagedType.VBByRefStr)] ref string HHSZi, [MarshalAs(UnmanagedType.VBByRefStr)] ref string arbuu, [MarshalAs(UnmanagedType.VBByRefStr)] ref string arbuu, int sblQG);

	[DllImport("kwKau.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int kwKau(IntPtr DgUvG, [MarshalAs(UnmanagedType.VBByRefStr)] ref string uBtHt, [MarshalAs(UnmanagedType.VBByRefStr)] ref string uBtHt, [MarshalAs(UnmanagedType.VBByRefStr)] ref string fVMxR, [MarshalAs(UnmanagedType.VBByRefStr)] ref string fVMxR, int XqlIG);

	[DllImport("paueR.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int paueR(IntPtr hvUoF, [MarshalAs(UnmanagedType.VBByRefStr)] ref string hvUoF, [MarshalAs(UnmanagedType.VBByRefStr)] ref string AfdKR, [MarshalAs(UnmanagedType.VBByRefStr)] ref string SQnfc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string KkNpR, int cUWMc);

	[DllImport("UpvWQ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int cUWMc(IntPtr mZFrc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string mZFrc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string GKONn, [MarshalAs(UnmanagedType.VBByRefStr)] ref string wenYc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string QPxtn, int QPxtn);

	[DllImport("aUgZn.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int HjWWb(IntPtr aUgZn, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sWpuy, [MarshalAs(UnmanagedType.VBByRefStr)] ref string jYPGn, [MarshalAs(UnmanagedType.VBByRefStr)] ref string DJYby, [MarshalAs(UnmanagedType.VBByRefStr)] ref string tdxlm, int tdxlm);

	[DllImport("NOHHy.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int NOHHy(IntPtr fxRcK, [MarshalAs(UnmanagedType.VBByRefStr)] ref string XTpny, [MarshalAs(UnmanagedType.VBByRefStr)] ref string XTpny, [MarshalAs(UnmanagedType.VBByRefStr)] ref string hYYTx, [MarshalAs(UnmanagedType.VBByRefStr)] ref string hYYTx, int AIioK);
}
