using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace XW;

public static class qW2
{
	private static qW2 Yqr;

	public static List<MWS> naa<MWS>(this Table<MWS> table_0, HttpContext httpContext_0) where MWS : class
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		string text = lcz.nJ(nP9.nJ(aPQ.nJ(table_0.get_Context(), aPQ.NPq), aG.nJ(typeof(MWS).TypeHandle, aG.ta), nP9.MPZ), lcz.uPB);
		List<MWS> list = o3E.nJ(aPx.nJ(httpContext_0, aPx.yPR), text, o3E.lPi) as List<MWS>;
		if (list == null)
		{
			SqlConnection val = new SqlConnection(lcz.nJ(mP0.nJ(table_0.get_Context(), mP0.mPm), lcz.SP1));
			try
			{
				Pyq.nJ(val, Pyq.XPY);
				SqlCommand val2 = new SqlCommand(lcz.nJ(WPr.nJ(table_0.get_Context(), (IQueryable)table_0, WPr.RPK), lcz.JPg), val);
				HPD.nJ(val2, null, HPD.LPb);
				JJO.nJ(val2, bool_0: true, JJO.DP4);
				ayW.nJ(lcz.nJ(mP0.nJ(table_0.get_Context(), mP0.mPm), lcz.SP1), ayW.dPG);
				if (!SPa.nJ(lcz.nJ(mP0.nJ(table_0.get_Context(), mP0.mPm), lcz.SP1), SPa.pPA).Contains(text))
				{
					FPv.nJ(lcz.nJ(mP0.nJ(table_0.get_Context(), mP0.mPm), lcz.SP1), text, FPv.MPH);
				}
				SqlCacheDependency cacheDependency_ = new SqlCacheDependency(val2);
				IJa.nJ(val2, IJa.NPn);
				list = ((IEnumerable<MWS>)table_0).ToList();
				zPo.nJ(aPx.nJ(httpContext_0, aPx.yPR), text, list, (CacheDependency)(object)cacheDependency_, zPo.HPe);
			}
			finally
			{
				if (val != null)
				{
					Su.nJ(val, Su.D4);
				}
			}
		}
		return list;
	}

	public static void raq(this Cache cache_0)
	{
		List<string> list = new List<string>();
		IDictionaryEnumerator object_ = Nq.nJ(cache_0, Nq.EPE);
		while (WM.nJ(object_, WM.gb))
		{
			list.Add(Xi.nJ(nZ.nJ(object_, nZ.iPs), Xi.l0));
		}
		foreach (string item in list)
		{
			o3E.nJ(cache_0, item, o3E.YPV);
		}
	}

	internal static bool dqv()
	{
		return Yqr == null;
	}

	internal static qW2 Tqk()
	{
		return Yqr;
	}
}
