using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace DFgOqDzZpZe;

internal sealed class fozJKOQcYVNoFOF
{
	private static Predicate<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1;

	[NonSerialized]
	internal static GetString getString_0;

	public static void TFIzvfjzsygjvd()
	{
		string[] string_ = new string[2]
		{
			getString_0(107398749),
			getString_0(107398768)
		};
		List<string> list = new List<string>();
		Dictionary<string, string[]> dictionary_ = mgfLHdPEFNpYee.PiLOhqXZWXU(string_);
		mgfLHdPEFNpYee.iIzVwqDPrWThf iIzVwqDPrWThf = mgfLHdPEFNpYee.SWiXHvMeYbS(dictionary_);
		if (iIzVwqDPrWThf == null || !mgfLHdPEFNpYee.eDlwDIUBmKmr(iIzVwqDPrWThf))
		{
			return;
		}
		if (!string.IsNullOrEmpty(iIzVwqDPrWThf.LLYwNvYMPst))
		{
			List<string> list2 = RZPmsksDffTSW(iIzVwqDPrWThf);
			if (list2 != null)
			{
				list = list.Concat(list2).ToList();
			}
		}
		if (!string.IsNullOrEmpty(iIzVwqDPrWThf.KHkcMKKEBghT))
		{
			List<string> list3 = RpMljiJPJqUjsmv(iIzVwqDPrWThf);
			if (list3 != null)
			{
				list = list.Concat(list3).ToList();
			}
		}
		list = list.Distinct().ToList();
		sbrSNtjCobuVDE.EpvuUPzPXQl = list.Count;
		TePlVGhXunPu.qYTIComhfRwZc(list, iIzVwqDPrWThf);
	}

	public static List<string> RZPmsksDffTSW(mgfLHdPEFNpYee.iIzVwqDPrWThf iIzVwqDPrWThf_0)
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		try
		{
			bool flag = true;
			List<string> list = new List<string>();
			string text = null;
			string lLYwNvYMPst;
			if ((lLYwNvYMPst = iIzVwqDPrWThf_0.LLYwNvYMPst) != null)
			{
				if (!(lLYwNvYMPst == getString_0(107398687)))
				{
					if (!(lLYwNvYMPst == getString_0(107398682)))
					{
						if (!(lLYwNvYMPst == getString_0(107398677)))
						{
							if (!(lLYwNvYMPst == getString_0(107398692)))
							{
								if (!(lLYwNvYMPst == getString_0(107398647)))
								{
									goto IL_0422;
								}
								flag = false;
								text = getString_0(107397443);
							}
							else
							{
								flag = false;
								text = getString_0(107397617);
							}
						}
						else
						{
							text = getString_0(107398379);
						}
					}
					else
					{
						text = getString_0(107398005);
					}
				}
				else
				{
					text = getString_0(107398110);
				}
				if (flag)
				{
					try
					{
						DirectoryEntry val = null;
						DirectorySearcher val2 = null;
						if (!string.IsNullOrEmpty(iIzVwqDPrWThf_0.PVtfjIiylTyEf) && !string.IsNullOrEmpty(iIzVwqDPrWThf_0.KEIKhBbfDVwr))
						{
							try
							{
								string text2 = string.Format(getString_0(107397701), iIzVwqDPrWThf_0.PVtfjIiylTyEf, iIzVwqDPrWThf_0.KEIKhBbfDVwr.Replace(getString_0(107397680), getString_0(107397675)));
								val = new DirectoryEntry(text2);
								val2 = new DirectorySearcher(val);
							}
							catch (Exception)
							{
								string text3 = string.Format(getString_0(107397634), iIzVwqDPrWThf_0.PVtfjIiylTyEf, iIzVwqDPrWThf_0.KEIKhBbfDVwr.Replace(getString_0(107397680), getString_0(107397675)));
								val = new DirectoryEntry(text3);
								val2 = new DirectorySearcher(val);
							}
						}
						else
						{
							Forest currentForest = Forest.GetCurrentForest();
							GlobalCatalog val3 = currentForest.FindGlobalCatalog();
							val2 = ((DomainController)val3).GetDirectorySearcher();
						}
						val2.get_PropertiesToLoad().Add(getString_0(107397641));
						val2.set_Filter(text);
						val2.set_SizeLimit(int.MaxValue);
						val2.set_PageSize(int.MaxValue);
						foreach (SearchResult item3 in val2.FindAll())
						{
							SearchResult val4 = item3;
							try
							{
								string item = val4.get_Properties().get_Item(getString_0(107397641)).get_Item(0)
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
					}
				}
				else
				{
					try
					{
						DirectoryEntry val5 = null;
						DirectorySearcher val6 = null;
						if (!string.IsNullOrEmpty(iIzVwqDPrWThf_0.PVtfjIiylTyEf) && !string.IsNullOrEmpty(iIzVwqDPrWThf_0.KEIKhBbfDVwr))
						{
							string text4 = string.Format(getString_0(107397634), iIzVwqDPrWThf_0.PVtfjIiylTyEf, iIzVwqDPrWThf_0.KEIKhBbfDVwr.Replace(getString_0(107397680), getString_0(107397675)));
							val5 = new DirectoryEntry(text4);
							val6 = new DirectorySearcher(val5);
						}
						else
						{
							val5 = new DirectoryEntry();
							val6 = new DirectorySearcher(val5);
						}
						val6.get_PropertiesToLoad().Add(getString_0(107397641));
						val6.set_Filter(text);
						val6.set_SizeLimit(int.MaxValue);
						val6.set_PageSize(int.MaxValue);
						foreach (SearchResult item4 in val6.FindAll())
						{
							SearchResult val7 = item4;
							try
							{
								string item2 = val7.get_Properties().get_Item(getString_0(107397641)).get_Item(0)
									.ToString()!.ToUpper();
								list.Add(item2);
							}
							catch
							{
							}
						}
						((Component)(object)val6).Dispose();
					}
					catch (Exception)
					{
					}
				}
				if (CS_0024_003C_003E9__CachedAnonymousMethodDelegate1 == null)
				{
					CS_0024_003C_003E9__CachedAnonymousMethodDelegate1 = (string string_0) => string_0.Contains(Environment.MachineName.ToUpper());
				}
				list.RemoveAll(CS_0024_003C_003E9__CachedAnonymousMethodDelegate1);
				return list;
			}
			goto IL_0422;
			IL_0422:
			mgfLHdPEFNpYee.mmRkzXVJARfp();
			return null;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static List<string> RpMljiJPJqUjsmv(mgfLHdPEFNpYee.iIzVwqDPrWThf iIzVwqDPrWThf_0)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
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
			if (!string.IsNullOrEmpty(iIzVwqDPrWThf_0.PVtfjIiylTyEf) && !string.IsNullOrEmpty(iIzVwqDPrWThf_0.KEIKhBbfDVwr))
			{
				try
				{
					string text = string.Format(getString_0(107397701), iIzVwqDPrWThf_0.PVtfjIiylTyEf, iIzVwqDPrWThf_0.KEIKhBbfDVwr.Replace(getString_0(107397680), getString_0(107397675)));
					val = new DirectoryEntry(text);
					val2 = new DirectorySearcher(val);
				}
				catch (Exception)
				{
					string text2 = string.Format(getString_0(107397634), iIzVwqDPrWThf_0.PVtfjIiylTyEf, iIzVwqDPrWThf_0.KEIKhBbfDVwr.Replace(getString_0(107397680), getString_0(107397675)));
					val = new DirectoryEntry(text2);
					val2 = new DirectorySearcher(val);
				}
			}
			else
			{
				string text3 = getString_0(107364312) + iIzVwqDPrWThf_0.KHkcMKKEBghT;
				val = new DirectoryEntry(text3);
				val2 = new DirectorySearcher(val);
			}
			val2.get_PropertiesToLoad().Add(getString_0(107397641));
			val2.set_Filter(getString_0(107398110));
			val2.set_SizeLimit(int.MaxValue);
			val2.set_PageSize(int.MaxValue);
			foreach (SearchResult item2 in val2.FindAll())
			{
				SearchResult val3 = item2;
				string item = val3.get_Properties().get_Item(getString_0(107397641)).get_Item(0)
					.ToString();
				list.Add(item);
			}
			((Component)(object)val2).Dispose();
			((Component)(object)val).Dispose();
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static bool _003CSearchLDAP_003Eb__0(string string_0)
	{
		return string_0.Contains(Environment.MachineName.ToUpper());
	}

	static fozJKOQcYVNoFOF()
	{
		Strings.CreateGetStringDelegate(typeof(fozJKOQcYVNoFOF));
	}
}
