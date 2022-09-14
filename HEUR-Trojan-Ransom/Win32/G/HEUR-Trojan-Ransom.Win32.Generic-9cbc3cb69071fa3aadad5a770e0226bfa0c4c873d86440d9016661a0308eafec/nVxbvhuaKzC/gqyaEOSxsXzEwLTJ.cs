using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nVxbvhuaKzC;

internal sealed class gqyaEOSxsXzEwLTJ
{
	private static Predicate<string> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1;

	[NonSerialized]
	internal static GetString getString_0;

	public static void TvqDlBRUBF()
	{
		string[] string_ = new string[2]
		{
			getString_0(107406942),
			getString_0(107406961)
		};
		List<string> list = new List<string>();
		Dictionary<string, string[]> dictionary_ = CloxxHDYIiDnH.xWTsAfEUXLxkdRv(string_);
		CloxxHDYIiDnH.mtofTxzGXYEyJ mtofTxzGXYEyJ = CloxxHDYIiDnH.vNwYthxwtf(dictionary_);
		if (mtofTxzGXYEyJ == null || !CloxxHDYIiDnH.vOkIsCuVxIbg(mtofTxzGXYEyJ))
		{
			return;
		}
		if (!string.IsNullOrEmpty(mtofTxzGXYEyJ.majXkJbUDNvi))
		{
			List<string> list2 = ePJjMcGgLmU(mtofTxzGXYEyJ);
			if (list2 != null)
			{
				list = list.Concat(list2).ToList();
			}
		}
		if (!string.IsNullOrEmpty(mtofTxzGXYEyJ.KeNodwUlUHvzAR))
		{
			List<string> list3 = tgsRzRIbzY(mtofTxzGXYEyJ);
			if (list3 != null)
			{
				list = list.Concat(list3).ToList();
			}
		}
		list = list.Distinct().ToList();
		jdtBGFKHrhDpc.cSaFtJTxEXIvV = list.Count;
		xuqMCiNvrBdOfN.DUkpYirkJJlLqA(list, mtofTxzGXYEyJ);
	}

	public static List<string> ePJjMcGgLmU(CloxxHDYIiDnH.mtofTxzGXYEyJ mtofTxzGXYEyJ_0)
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
			string majXkJbUDNvi = mtofTxzGXYEyJ_0.majXkJbUDNvi;
			if (majXkJbUDNvi != null)
			{
				if (!(majXkJbUDNvi == getString_0(107406368)))
				{
					if (!(majXkJbUDNvi == getString_0(107406395)))
					{
						if (!(majXkJbUDNvi == getString_0(107406390)))
						{
							if (!(majXkJbUDNvi == getString_0(107406341)))
							{
								if (!(majXkJbUDNvi == getString_0(107406360)))
								{
									goto IL_0499;
								}
								flag = false;
								getString_0(107405900);
								text = getString_0(107405299);
							}
							else
							{
								flag = false;
								getString_0(107406071);
								text = getString_0(107406042);
							}
						}
						else
						{
							getString_0(107406418);
							text = getString_0(107405809);
						}
					}
					else
					{
						getString_0(107406625);
						text = getString_0(107406556);
					}
				}
				else
				{
					getString_0(107406303);
					text = getString_0(107406218);
				}
				if (flag)
				{
					try
					{
						DirectoryEntry val = null;
						DirectorySearcher val2 = null;
						if (!string.IsNullOrEmpty(mtofTxzGXYEyJ_0.jmVpgEmwoA) && !string.IsNullOrEmpty(mtofTxzGXYEyJ_0.HJjxRwvauSz))
						{
							try
							{
								string text2 = string.Format(getString_0(107405525), mtofTxzGXYEyJ_0.jmVpgEmwoA, mtofTxzGXYEyJ_0.HJjxRwvauSz.Replace(getString_0(107410913), getString_0(107405472)));
								val = new DirectoryEntry(text2);
								val2 = new DirectorySearcher(val);
							}
							catch (Exception)
							{
								string text2 = string.Format(getString_0(107405495), mtofTxzGXYEyJ_0.jmVpgEmwoA, mtofTxzGXYEyJ_0.HJjxRwvauSz.Replace(getString_0(107410913), getString_0(107405472)));
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
						val2.get_PropertiesToLoad().Add(getString_0(107405438));
						val2.set_Filter(text);
						val2.set_SizeLimit(int.MaxValue);
						val2.set_PageSize(int.MaxValue);
						foreach (SearchResult item2 in val2.FindAll())
						{
							SearchResult val4 = item2;
							try
							{
								string item = val4.get_Properties().get_Item(getString_0(107405438)).get_Item(0)
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
						if (mtofTxzGXYEyJ_0.gGcZJcaAZjhD)
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
						if (!string.IsNullOrEmpty(mtofTxzGXYEyJ_0.jmVpgEmwoA) && !string.IsNullOrEmpty(mtofTxzGXYEyJ_0.HJjxRwvauSz))
						{
							string text2 = string.Format(getString_0(107405495), mtofTxzGXYEyJ_0.jmVpgEmwoA, mtofTxzGXYEyJ_0.HJjxRwvauSz.Replace(getString_0(107410913), getString_0(107405472)));
							val = new DirectoryEntry(text2);
							val5 = new DirectorySearcher(val);
						}
						else
						{
							val = new DirectoryEntry();
							val5 = new DirectorySearcher(val);
						}
						val5.get_PropertiesToLoad().Add(getString_0(107405438));
						val5.set_Filter(text);
						val5.set_SizeLimit(int.MaxValue);
						val5.set_PageSize(int.MaxValue);
						foreach (SearchResult item3 in val5.FindAll())
						{
							SearchResult val4 = item3;
							try
							{
								string item = val4.get_Properties().get_Item(getString_0(107405438)).get_Item(0)
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
						if (mtofTxzGXYEyJ_0.gGcZJcaAZjhD)
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
			CloxxHDYIiDnH.IkZitJGjLQDpG();
			return null;
		}
		catch (Exception)
		{
			if (!mtofTxzGXYEyJ_0.gGcZJcaAZjhD)
			{
			}
			return null;
		}
	}

	public static List<string> tgsRzRIbzY(CloxxHDYIiDnH.mtofTxzGXYEyJ mtofTxzGXYEyJ_0)
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
			if (!string.IsNullOrEmpty(mtofTxzGXYEyJ_0.jmVpgEmwoA) && !string.IsNullOrEmpty(mtofTxzGXYEyJ_0.HJjxRwvauSz))
			{
				try
				{
					string text = string.Format(getString_0(107405525), mtofTxzGXYEyJ_0.jmVpgEmwoA, mtofTxzGXYEyJ_0.HJjxRwvauSz.Replace(getString_0(107410913), getString_0(107405472)));
					val = new DirectoryEntry(text);
					val2 = new DirectorySearcher(val);
				}
				catch (Exception)
				{
					string text = string.Format(getString_0(107405495), mtofTxzGXYEyJ_0.jmVpgEmwoA, mtofTxzGXYEyJ_0.HJjxRwvauSz.Replace(getString_0(107410913), getString_0(107405472)));
					val = new DirectoryEntry(text);
					val2 = new DirectorySearcher(val);
				}
			}
			else
			{
				string text2 = getString_0(107405453) + mtofTxzGXYEyJ_0.KeNodwUlUHvzAR;
				val = new DirectoryEntry(text2);
				val2 = new DirectorySearcher(val);
			}
			val2.get_PropertiesToLoad().Add(getString_0(107405438));
			val2.set_Filter(getString_0(107406218));
			val2.set_SizeLimit(int.MaxValue);
			val2.set_PageSize(int.MaxValue);
			foreach (SearchResult item2 in val2.FindAll())
			{
				SearchResult val3 = item2;
				string item = val3.get_Properties().get_Item(getString_0(107405438)).get_Item(0)
					.ToString();
				list.Add(item);
			}
			((Component)(object)val2).Dispose();
			((Component)(object)val).Dispose();
			return list;
		}
		catch (Exception)
		{
			if (!mtofTxzGXYEyJ_0.gGcZJcaAZjhD)
			{
			}
			return null;
		}
	}

	private static bool _003CSearchLDAP_003Eb__0(string string_0)
	{
		return string_0.Contains(Environment.MachineName.ToUpper());
	}

	static gqyaEOSxsXzEwLTJ()
	{
		Strings.CreateGetStringDelegate(typeof(gqyaEOSxsXzEwLTJ));
	}
}
