using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;

namespace XW;

public class mf
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string hiI;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string Wi1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private HttpContext Mi5;

	internal static mf vqE;

	public mf(string string_0, HttpContext httpContext_0)
	{
		G3.nJ(G3.By);
		base._002Ector();
		Ew.nJ(this, P3y.nJ(string_0, P3y.acH), Ew.fcn);
		zco.nJ(this, httpContext_0, zco.Kce);
	}

	[SpecialName]
	[CompilerGenerated]
	public string miq()
	{
		return hiI;
	}

	[SpecialName]
	[CompilerGenerated]
	public void uiF(string string_0)
	{
		hiI = string_0;
	}

	[SpecialName]
	public string LiS()
	{
		return FXs.nJ(Xi.nJ(this, Xi.HcE), FXs.iXV) ? null : Dca.nJ(Ec6.nJ(qcs.nJ(this, qcs.scV), Ec6.TcF), Xi.nJ(this, Xi.HcE), Dca.NcN);
	}

	[SpecialName]
	public string YiD()
	{
		return Lyn.nJ(Xi.nJ(this, Xi.AcW), Xi.nJ(this, Xi.CcU), Lyn.cyo);
	}

	[SpecialName]
	[CompilerGenerated]
	public void Kis(string string_0)
	{
		Wi1 = string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string Dij()
	{
		return Wi1;
	}

	[SpecialName]
	[CompilerGenerated]
	public HttpContext diH()
	{
		return Mi5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void piv(HttpContext httpContext_0)
	{
		Mi5 = httpContext_0;
	}

	[SpecialName]
	public string QiU()
	{
		return Lyn.nJ(ncj.nJ(ncj.Jc8), Xi.nJ(this, Xi.HcE), Lyn.cyo);
	}

	public static string fia()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (RcT.nJ(RcT.fc5) == null)
		{
			throw new HttpException(400, "This method cannot be used outside of an HttpContext.");
		}
		return Ku3.nJ((IJa.nJ(ecL.nJ(Lcl.nJ(RcT.nJ(RcT.fc5), Lcl.qcC), ecL.Tc2), IJa.tcS) != 80) ? "{0}://{1}:{2}" : "{0}://{1}", lcz.nJ(ecL.nJ(Lcl.nJ(RcT.nJ(RcT.fc5), Lcl.qcC), ecL.Tc2), lcz.HuO), lcz.nJ(ecL.nJ(Lcl.nJ(RcT.nJ(RcT.fc5), Lcl.qcC), ecL.Tc2), lcz.BuJ), IJa.nJ(ecL.nJ(Lcl.nJ(RcT.nJ(RcT.fc5), Lcl.qcC), ecL.Tc2), IJa.tcS), Ku3.Fuy);
	}

	internal static bool AqT()
	{
		return vqE == null;
	}

	internal static mf zql()
	{
		return vqE;
	}
}
