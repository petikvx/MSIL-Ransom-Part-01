using System;
using System.Collections;
using ATI.ACE.ACE.Graphics.DisplaysManager.Shared;
using ATI.ACE.CLI.Caste.Graphics.Shared;
using ATI.ACE.CLI.Foundation;
using ATI.ACE.LOG.Foundation;

internal sealed class DMHotkeysHandling
{
	internal static bool Rotate_Current(ANGLES angles, IGraphicsCaste iGraphicsCaste, SGraphicsAdapter sGraphicsAdapter, IComponent iComponent)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		try
		{
			if (((SAdapter)sGraphicsAdapter).get_active() && sGraphicsAdapter.get_displaysManagerRotationSupported() && !sGraphicsAdapter.displaysManagerInfo.get_onDeviceNotConnected() && ((SPropertySetting_MODEINFO)sGraphicsAdapter.displaysManagerInfo.mode.Control).get_T().orientation != angles)
			{
				DM_INFO val = new DM_INFO(((SAdapter)sGraphicsAdapter).index, ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.active.Control).get_T(), ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.primary.Control).get_T(), ((SPropertySetting_MODEINFO)sGraphicsAdapter.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_T(), false);
				val.modeinfo.orientation = angles;
				IAdapter iAdapter = ((SAdapter)sGraphicsAdapter).iAdapter;
				if (((IGraphicsAdapter)((iAdapter is IGraphicsAdapter) ? iAdapter : null)).ValidateModeInList(val.modeinfo))
				{
					ArrayList arrayList = new ArrayList();
					arrayList.Add(val);
					flag = true;
					iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList);
				}
			}
			if (flag)
			{
				iComponent.Apply(true);
				return flag;
			}
			return flag;
		}
		catch (Exception ex)
		{
			Services.Exception(ex);
			return flag;
		}
	}

	internal static bool ToggleRotation0_180(IGraphicsCaste iGraphicsCaste, SGraphicsAdapter sGraphicsAdapter, IComponent iComponent)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Invalid comparison between Unknown and I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Invalid comparison between Unknown and I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		try
		{
			if (((SAdapter)sGraphicsAdapter).get_active() && sGraphicsAdapter.get_displaysManagerRotationSupported() && !sGraphicsAdapter.displaysManagerInfo.get_onDeviceNotConnected())
			{
				DM_INFO val = new DM_INFO(((SAdapter)sGraphicsAdapter).index, ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.active.Control).get_T(), ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.primary.Control).get_T(), ((SPropertySetting_MODEINFO)sGraphicsAdapter.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_T(), false);
				ANGLES orientation = val.modeinfo.orientation;
				if ((int)orientation <= 90)
				{
					if ((int)orientation != 0)
					{
						if ((int)orientation == 90)
						{
							val.modeinfo.orientation = (ANGLES)0;
						}
					}
					else
					{
						val.modeinfo.orientation = (ANGLES)180;
					}
				}
				else if ((int)orientation != 180)
				{
					if ((int)orientation == 270)
					{
						val.modeinfo.orientation = (ANGLES)0;
					}
				}
				else
				{
					val.modeinfo.orientation = (ANGLES)0;
				}
				IAdapter iAdapter = ((SAdapter)sGraphicsAdapter).iAdapter;
				if (((IGraphicsAdapter)((iAdapter is IGraphicsAdapter) ? iAdapter : null)).ValidateModeInList(val.modeinfo))
				{
					ArrayList arrayList = new ArrayList();
					arrayList.Add(val);
					flag = true;
					iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList);
				}
			}
			if (flag)
			{
				iComponent.Apply(true);
				return flag;
			}
			return flag;
		}
		catch (Exception ex)
		{
			Services.Exception(ex);
			return flag;
		}
	}

	internal static bool SwapDisplayMapping(IGraphicsCaste iGraphicsCaste, SGraphicsAdapter sGraphicsAdapter, IComponent iComponent)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		bool flag = false;
		try
		{
			if (sGraphicsAdapter.get_ATISpecific() && ((SAdapter)sGraphicsAdapter).get_active() && sGraphicsAdapter.displaysManagerInfo.get_swapDeviceSupported())
			{
				SGraphicsAdapter val = sGraphicsAdapter;
				MANNERISM manner = ((SPropertySetting_MAPPINGINFO)val.displaysManagerInfo.mapping.Control).get_T().linkInfo.manner;
				if ((int)manner == 1 || (int)manner == 7)
				{
					SAdapter sAdapter = ((ICaste)iGraphicsCaste).GetSAdapter(val.displaysManagerInfo.get_firstControllerDEMAdapterIndex());
					val = (SGraphicsAdapter)(object)((sAdapter is SGraphicsAdapter) ? sAdapter : null);
				}
				DM_INFO val2 = new DM_INFO(((SAdapter)val).index, ((SPropertySetting_bool)val.displaysManagerInfo.active.Control).get_T(), ((SPropertySetting_bool)val.displaysManagerInfo.primary.Control).get_T(), ((SPropertySetting_MODEINFO)val.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val.displaysManagerInfo.mapping.Control).get_T(), false);
				int num = 0;
				val2.mappinginfo.firstController.Clear();
				for (num = 0; num < ((SPropertySetting_MAPPINGINFO)val.displaysManagerInfo.mapping.Control).get_C().secondController.Count; num++)
				{
					val2.mappinginfo.firstController.Add((int)((SPropertySetting_MAPPINGINFO)val.displaysManagerInfo.mapping.Control).get_C().secondController[num]);
				}
				val2.mappinginfo.secondController.Clear();
				for (num = 0; num < ((SPropertySetting_MAPPINGINFO)val.displaysManagerInfo.mapping.Control).get_C().firstController.Count; num++)
				{
					val2.mappinginfo.secondController.Add((int)((SPropertySetting_MAPPINGINFO)val.displaysManagerInfo.mapping.Control).get_C().firstController[num]);
				}
				ArrayList arrayList = new ArrayList();
				arrayList.Add(val2);
				flag = true;
				iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList);
			}
			if (flag)
			{
				iComponent.Apply(true);
				return flag;
			}
			return flag;
		}
		catch (Exception ex)
		{
			Services.Exception(ex);
			return flag;
		}
	}

	internal static bool SwitchAmongstDisplay(IGraphicsCaste iGraphicsCaste, SGraphicsAdapter sGraphicsAdapter, IComponent iComponent)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected I4, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected O, but got Unknown
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected O, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		try
		{
			if (sGraphicsAdapter.get_ATISpecific())
			{
				if (((SAdapter)sGraphicsAdapter).get_active())
				{
					MANNERISM manner = ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().linkInfo.manner;
					switch ((int)manner)
					{
					case 0:
					{
						DM_INFO val7 = new DM_INFO(((SAdapter)sGraphicsAdapter).index, ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.active.Control).get_T(), ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.primary.Control).get_T(), ((SPropertySetting_MODEINFO)sGraphicsAdapter.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C(), false);
						if (1 <= val7.mappinginfo.firstController.Count)
						{
							int num3 = (int)val7.mappinginfo.firstController[0];
							int num4 = -1;
							for (int i = 0; i < sGraphicsAdapter.displaysManagerInfo.get_allMappedAndOffConnectedDisplays().Length; i++)
							{
								if (num3 == sGraphicsAdapter.displaysManagerInfo.get_allMappedAndOffConnectedDisplays()[i])
								{
									num4 = i;
									break;
								}
							}
							num4 = ((-1 != num4 && num4 + 1 < sGraphicsAdapter.displaysManagerInfo.get_allMappedAndOffConnectedDisplays().Length) ? (num4 + 1) : 0);
							val7.mappinginfo.firstController.Clear();
							val7.mappinginfo.firstController.Add(sGraphicsAdapter.displaysManagerInfo.get_allMappedAndOffConnectedDisplays()[num4]);
							val7.mappinginfo.secondController.Clear();
						}
						else if (1 <= val7.mappinginfo.secondController.Count)
						{
							int num5 = (int)val7.mappinginfo.secondController[0];
							int num6 = -1;
							for (int j = 0; j < sGraphicsAdapter.displaysManagerInfo.get_allMappedAndOffConnectedDisplays().Length; j++)
							{
								if (num5 == sGraphicsAdapter.displaysManagerInfo.get_allMappedAndOffConnectedDisplays()[j])
								{
									num6 = j;
									break;
								}
							}
							num6 = ((-1 != num6 && num6 + 1 < sGraphicsAdapter.displaysManagerInfo.get_allMappedAndOffConnectedDisplays().Length) ? (num6 + 1) : 0);
							val7.mappinginfo.secondController.Clear();
							val7.mappinginfo.secondController.Add(sGraphicsAdapter.displaysManagerInfo.get_allMappedAndOffConnectedDisplays()[num6]);
							val7.mappinginfo.firstController.Clear();
						}
						ArrayList arrayList5 = new ArrayList();
						arrayList5.Add(val7);
						flag = true;
						iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList5);
						break;
					}
					case 1:
					{
						int index = ((SAdapter)sGraphicsAdapter).index;
						index = ((((SAdapter)sGraphicsAdapter).index != sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex()) ? sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex() : sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex());
						SAdapter sAdapter = ((ICaste)iGraphicsCaste).GetSAdapter(index);
						SGraphicsAdapter val2 = (SGraphicsAdapter)(object)((sAdapter is SGraphicsAdapter) ? sAdapter : null);
						if (((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C())
						{
							iGraphicsCaste.RequestSetPrimaryLater(((SAdapter)sGraphicsAdapter).index);
						}
						iGraphicsCaste.RequestDeactivateLater(index);
						flag = true;
						break;
					}
					case 3:
					{
						DM_INFO val3 = new DM_INFO(((SAdapter)sGraphicsAdapter).index, ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.active.Control).get_T(), ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.primary.Control).get_T(), ((SPropertySetting_MODEINFO)sGraphicsAdapter.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C(), false);
						if (1 <= val3.mappinginfo.firstController.Count)
						{
							val3.mappinginfo.firstController.RemoveRange(1, val3.mappinginfo.firstController.Count - 1);
						}
						else if (1 <= val3.mappinginfo.secondController.Count)
						{
							val3.mappinginfo.secondController.RemoveRange(1, val3.mappinginfo.secondController.Count - 1);
						}
						val3.mappinginfo.secondController.Clear();
						val3.mappinginfo.linkInfo.manner = (MANNERISM)0;
						ArrayList arrayList2 = new ArrayList();
						arrayList2.Add(val3);
						flag = true;
						iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList2);
						break;
					}
					case 2:
					case 4:
					case 5:
					{
						DM_INFO val6 = new DM_INFO(((SAdapter)sGraphicsAdapter).index, ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.active.Control).get_T(), ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.primary.Control).get_T(), ((SPropertySetting_MODEINFO)sGraphicsAdapter.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C(), false);
						val6.mappinginfo.secondController.Clear();
						val6.mappinginfo.linkInfo.manner = (MANNERISM)0;
						ArrayList arrayList4 = new ArrayList();
						arrayList4.Add(val6);
						flag = true;
						iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList4);
						break;
					}
					case 7:
					{
						int num = 0;
						int num2 = 0;
						if (((SAdapter)sGraphicsAdapter).index == sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex())
						{
							num = sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex();
							num2 = 1;
						}
						else
						{
							num = sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex();
						}
						SAdapter sAdapter2 = ((ICaste)iGraphicsCaste).GetSAdapter(num);
						SGraphicsAdapter val4 = (SGraphicsAdapter)(object)((sAdapter2 is SGraphicsAdapter) ? sAdapter2 : null);
						DM_INFO val5 = new DM_INFO(((SAdapter)sGraphicsAdapter).index, ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.active.Control).get_T(), ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.primary.Control).get_T(), ((SPropertySetting_MODEINFO)sGraphicsAdapter.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C(), false);
						DM_INFO value = new DM_INFO(((SAdapter)val4).index, false, false, ((SPropertySetting_MODEINFO)val4.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)val4.displaysManagerInfo.mapping.Control).get_T(), false);
						if (((SPropertySetting_bool)val4.displaysManagerInfo.primary.Control).get_C())
						{
							val5.isPrimary = true;
						}
						if (num2 == 0)
						{
							val5.mappinginfo.firstController.Clear();
							if (1 < val5.mappinginfo.secondController.Count)
							{
								val5.mappinginfo.secondController.RemoveRange(1, val5.mappinginfo.secondController.Count - 1);
							}
						}
						else
						{
							val5.mappinginfo.secondController.Clear();
							if (1 < val5.mappinginfo.firstController.Count)
							{
								val5.mappinginfo.firstController.RemoveRange(1, val5.mappinginfo.firstController.Count - 1);
							}
						}
						val5.mappinginfo.linkInfo.controllerIndexFirst = ((SAdapter)sGraphicsAdapter).index;
						val5.mappinginfo.linkInfo.controllerIndexSecond = ((SAdapter)sGraphicsAdapter).index;
						val5.mappinginfo.linkInfo.manner = (MANNERISM)0;
						ArrayList arrayList3 = new ArrayList();
						arrayList3.Add(val5);
						arrayList3.Add(value);
						flag = true;
						iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList3);
						break;
					}
					case 6:
					case 8:
					case 9:
					{
						DM_INFO val = new DM_INFO(((SAdapter)sGraphicsAdapter).index, ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.active.Control).get_T(), ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.primary.Control).get_T(), ((SPropertySetting_MODEINFO)sGraphicsAdapter.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C(), false);
						if (1 < val.mappinginfo.firstController.Count)
						{
							val.mappinginfo.firstController.RemoveRange(1, val.mappinginfo.firstController.Count - 1);
						}
						val.mappinginfo.secondController.Clear();
						val.mappinginfo.linkInfo.manner = (MANNERISM)0;
						ArrayList arrayList = new ArrayList();
						arrayList.Add(val);
						flag = true;
						iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList);
						break;
					}
					}
					if (flag)
					{
						iComponent.Apply(true);
						return flag;
					}
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception ex)
		{
			Services.Exception(ex);
			return flag;
		}
	}

	internal static bool EnableCloneMode(IGraphicsCaste iGraphicsCaste, SGraphicsAdapter sGraphicsAdapter, IComponent iComponent)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected I4, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected O, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected O, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected O, but got Unknown
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		try
		{
			if (sGraphicsAdapter.get_ATISpecific() && ((SAdapter)sGraphicsAdapter).get_active())
			{
				MANNERISM manner = ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().linkInfo.manner;
				switch ((int)manner)
				{
				case 0:
				{
					DM_INFO val7 = new DM_INFO(((SAdapter)sGraphicsAdapter).index, ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.active.Control).get_T(), ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.primary.Control).get_T(), ((SPropertySetting_MODEINFO)sGraphicsAdapter.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C(), false);
					if (1 <= val7.mappinginfo.firstController.Count)
					{
						bool flag2 = false;
						int num3 = 0;
						for (num3 = 0; num3 < sGraphicsAdapter.displaysManagerInfo.get_secondControllerList().Length; num3++)
						{
							ArrayList arrayList5 = sGraphicsAdapter.displaysManagerInfo.get_secondControllerList()[num3];
							if (1 == arrayList5.Count)
							{
								val7.mappinginfo.secondController.Clear();
								val7.mappinginfo.secondController.Add((int)arrayList5[0]);
								val7.mappinginfo.linkInfo.manner = (MANNERISM)2;
								ArrayList arrayList6 = new ArrayList();
								arrayList6.Add(val7);
								flag = true;
								iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList6);
								flag2 = true;
								break;
							}
						}
						if (flag2)
						{
							break;
						}
						for (num3 = 0; num3 < sGraphicsAdapter.displaysManagerInfo.get_firstControllerList().Length; num3++)
						{
							ArrayList arrayList7 = sGraphicsAdapter.displaysManagerInfo.get_firstControllerList()[num3];
							if (2 != arrayList7.Count)
							{
								arrayList7 = null;
								continue;
							}
							val7.mappinginfo.firstController.Clear();
							val7.mappinginfo.firstController.Add((int)arrayList7[0]);
							val7.mappinginfo.firstController.Add((int)arrayList7[1]);
							val7.mappinginfo.linkInfo.manner = (MANNERISM)3;
							ArrayList arrayList8 = new ArrayList();
							arrayList8.Add(val7);
							flag = true;
							iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList8);
							flag2 = true;
							break;
						}
					}
					else
					{
						if (1 > val7.mappinginfo.secondController.Count)
						{
							break;
						}
						bool flag3 = false;
						int num4 = 0;
						for (num4 = 0; num4 < sGraphicsAdapter.displaysManagerInfo.get_firstControllerList().Length; num4++)
						{
							ArrayList arrayList9 = sGraphicsAdapter.displaysManagerInfo.get_firstControllerList()[num4];
							if (1 == arrayList9.Count)
							{
								val7.mappinginfo.firstController.Clear();
								val7.mappinginfo.firstController.Add((int)arrayList9[0]);
								val7.mappinginfo.linkInfo.manner = (MANNERISM)2;
								ArrayList arrayList10 = new ArrayList();
								arrayList10.Add(val7);
								flag = true;
								iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList10);
								flag3 = true;
								break;
							}
						}
						if (flag3)
						{
							break;
						}
						for (num4 = 0; num4 < sGraphicsAdapter.displaysManagerInfo.get_secondControllerList().Length; num4++)
						{
							ArrayList arrayList11 = sGraphicsAdapter.displaysManagerInfo.get_secondControllerList()[num4];
							if (2 == arrayList11.Count)
							{
								val7.mappinginfo.secondController.Clear();
								val7.mappinginfo.secondController.Add((int)arrayList11[0]);
								val7.mappinginfo.secondController.Add((int)arrayList11[1]);
								val7.mappinginfo.linkInfo.manner = (MANNERISM)3;
								ArrayList arrayList12 = new ArrayList();
								arrayList12.Add(val7);
								flag = true;
								iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList12);
								flag3 = true;
								break;
							}
						}
					}
					break;
				}
				case 1:
				{
					int num2 = 0;
					num2 = ((((SAdapter)sGraphicsAdapter).index != sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex()) ? sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex() : sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex());
					SAdapter sAdapter2 = ((ICaste)iGraphicsCaste).GetSAdapter(num2);
					SGraphicsAdapter val4 = (SGraphicsAdapter)(object)((sAdapter2 is SGraphicsAdapter) ? sAdapter2 : null);
					DM_INFO val5 = new DM_INFO(((SAdapter)sGraphicsAdapter).index, ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.active.Control).get_T(), ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.primary.Control).get_T(), ((SPropertySetting_MODEINFO)sGraphicsAdapter.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C(), false);
					DM_INFO value2 = new DM_INFO(((SAdapter)val4).index, false, false, ((SPropertySetting_MODEINFO)val4.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)val4.displaysManagerInfo.mapping.Control).get_T(), false);
					if (((SPropertySetting_bool)val4.displaysManagerInfo.primary.Control).get_C())
					{
						val5.isPrimary = true;
					}
					val5.mappinginfo.linkInfo.controllerIndexFirst = ((SAdapter)sGraphicsAdapter).index;
					val5.mappinginfo.linkInfo.controllerIndexSecond = ((SAdapter)sGraphicsAdapter).index;
					val5.mappinginfo.linkInfo.manner = (MANNERISM)2;
					ArrayList arrayList3 = new ArrayList();
					arrayList3.Add(val5);
					arrayList3.Add(value2);
					flag = true;
					iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList3);
					break;
				}
				case 4:
				case 5:
				{
					DM_INFO val6 = new DM_INFO(((SAdapter)sGraphicsAdapter).index, ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.active.Control).get_T(), ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.primary.Control).get_T(), ((SPropertySetting_MODEINFO)sGraphicsAdapter.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C(), false);
					val6.mappinginfo.linkInfo.manner = (MANNERISM)2;
					ArrayList arrayList4 = new ArrayList();
					arrayList4.Add(val6);
					flag = true;
					iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList4);
					break;
				}
				case 7:
				{
					int num = 0;
					num = ((((SAdapter)sGraphicsAdapter).index != sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex()) ? sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex() : sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex());
					SAdapter sAdapter = ((ICaste)iGraphicsCaste).GetSAdapter(num);
					SGraphicsAdapter val2 = (SGraphicsAdapter)(object)((sAdapter is SGraphicsAdapter) ? sAdapter : null);
					DM_INFO val3 = new DM_INFO(((SAdapter)sGraphicsAdapter).index, ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.active.Control).get_T(), ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.primary.Control).get_T(), ((SPropertySetting_MODEINFO)sGraphicsAdapter.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C(), false);
					DM_INFO value = new DM_INFO(((SAdapter)val2).index, false, false, ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
					if (((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C())
					{
						val3.isPrimary = true;
					}
					val3.mappinginfo.linkInfo.controllerIndexFirst = ((SAdapter)sGraphicsAdapter).index;
					val3.mappinginfo.linkInfo.controllerIndexSecond = ((SAdapter)sGraphicsAdapter).index;
					val3.mappinginfo.linkInfo.manner = (MANNERISM)6;
					ArrayList arrayList2 = new ArrayList();
					arrayList2.Add(val3);
					arrayList2.Add(value);
					flag = true;
					iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList2);
					break;
				}
				case 8:
				case 9:
				{
					DM_INFO val = new DM_INFO(((SAdapter)sGraphicsAdapter).index, ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.active.Control).get_T(), ((SPropertySetting_bool)sGraphicsAdapter.displaysManagerInfo.primary.Control).get_T(), ((SPropertySetting_MODEINFO)sGraphicsAdapter.displaysManagerInfo.mode.Control).get_T(), ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C(), false);
					val.mappinginfo.linkInfo.manner = (MANNERISM)6;
					ArrayList arrayList = new ArrayList();
					arrayList.Add(val);
					flag = true;
					iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList);
					break;
				}
				}
			}
			if (flag)
			{
				iComponent.Apply(true);
				return flag;
			}
			return flag;
		}
		catch (Exception ex)
		{
			Services.Exception(ex);
			return flag;
		}
	}

	internal static bool TogglePossibleModes(IGraphicsCaste iGraphicsCaste, SGraphicsAdapter sGraphicsAdapter, IComponent iComponent)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I4, but got Unknown
		bool flag = false;
		try
		{
			ArrayList arrayList = null;
			int num = -1;
			if (sGraphicsAdapter.get_ATISpecific())
			{
				if (((SAdapter)sGraphicsAdapter).get_active())
				{
					MANNERISM manner = ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().linkInfo.manner;
					switch ((int)manner)
					{
					case 0:
					{
						if (((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().firstController.Count == 0)
						{
							flag = TogglePossibleModes_MakeSingle(iGraphicsCaste, sGraphicsAdapter);
							break;
						}
						arrayList = new ArrayList();
						ArrayList[] secondControllerList = sGraphicsAdapter.displaysManagerInfo.get_secondControllerList();
						foreach (ArrayList arrayList6 in secondControllerList)
						{
							if (1 == arrayList6.Count)
							{
								arrayList.Add(arrayList6[0]);
							}
						}
						arrayList.Sort(0, arrayList.Count, null);
						num = -1;
						if (0 < ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().secondController.Count)
						{
							foreach (object item in arrayList)
							{
								int num6 = (int)item;
								if (num6 > (int)((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().secondController[0])
								{
									num = num6;
									break;
								}
							}
						}
						else if (0 < arrayList.Count)
						{
							num = (int)arrayList[0];
						}
						flag = ((-1 != num) ? ((!sGraphicsAdapter.get_displaysManagerCloneSupported()) ? ((!sGraphicsAdapter.get_displaysManagerStretchSupported()) ? ((!sGraphicsAdapter.get_displaysManagerExtendedSupported()) ? TogglePossibleModes_MakeSingle(iGraphicsCaste, sGraphicsAdapter) : TogglePossibleModes_MakeExtended(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeHStretch(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeDualClone(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeSingle(iGraphicsCaste, sGraphicsAdapter));
						break;
					}
					case 1:
					{
						arrayList = new ArrayList();
						ArrayList[] secondControllerList = sGraphicsAdapter.displaysManagerInfo.get_secondControllerList();
						foreach (ArrayList arrayList3 in secondControllerList)
						{
							if (1 == arrayList3.Count)
							{
								arrayList.Add(arrayList3[0]);
							}
						}
						arrayList.Sort(0, arrayList.Count, null);
						num = -1;
						if (0 < ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().secondController.Count)
						{
							foreach (object item2 in arrayList)
							{
								int num3 = (int)item2;
								if (num3 > (int)((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().secondController[0])
								{
									num = num3;
									break;
								}
							}
						}
						flag = ((-1 != num) ? ((!sGraphicsAdapter.get_displaysManagerCloneSupported()) ? ((!sGraphicsAdapter.get_displaysManagerStretchSupported()) ? ((!sGraphicsAdapter.get_displaysManagerExtendedSupported()) ? TogglePossibleModes_MakeSingle(iGraphicsCaste, sGraphicsAdapter) : TogglePossibleModes_MakeExtended(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeHStretch(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeDualClone(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeSingle(iGraphicsCaste, sGraphicsAdapter));
						break;
					}
					case 2:
					{
						num = (int)((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().secondController[0];
						if (sGraphicsAdapter.get_displaysManagerStretchSupported())
						{
							flag = TogglePossibleModes_MakeHStretch(iGraphicsCaste, sGraphicsAdapter, num);
							break;
						}
						if (sGraphicsAdapter.get_displaysManagerExtendedSupported())
						{
							flag = TogglePossibleModes_MakeExtended(iGraphicsCaste, sGraphicsAdapter, num);
							break;
						}
						arrayList = new ArrayList();
						ArrayList[] secondControllerList = sGraphicsAdapter.displaysManagerInfo.get_secondControllerList();
						foreach (ArrayList arrayList5 in secondControllerList)
						{
							if (1 == arrayList5.Count)
							{
								arrayList.Add(arrayList5[0]);
							}
						}
						arrayList.Sort(0, arrayList.Count, null);
						num = -1;
						if (0 < ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().secondController.Count)
						{
							foreach (object item3 in arrayList)
							{
								int num5 = (int)item3;
								if (num5 > (int)((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().secondController[0])
								{
									num = num5;
									break;
								}
							}
						}
						else if (0 < arrayList.Count)
						{
							num = (int)arrayList[0];
						}
						flag = ((-1 != num) ? ((!sGraphicsAdapter.get_displaysManagerCloneSupported()) ? ((!sGraphicsAdapter.get_displaysManagerStretchSupported()) ? ((!sGraphicsAdapter.get_displaysManagerExtendedSupported()) ? TogglePossibleModes_MakeSingle(iGraphicsCaste, sGraphicsAdapter) : TogglePossibleModes_MakeExtended(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeHStretch(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeDualClone(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeSingle(iGraphicsCaste, sGraphicsAdapter));
						break;
					}
					case 4:
					{
						num = (int)((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().secondController[0];
						if (sGraphicsAdapter.get_displaysManagerExtendedSupported())
						{
							flag = TogglePossibleModes_MakeExtended(iGraphicsCaste, sGraphicsAdapter, num);
							break;
						}
						arrayList = new ArrayList();
						ArrayList[] secondControllerList = sGraphicsAdapter.displaysManagerInfo.get_secondControllerList();
						foreach (ArrayList arrayList4 in secondControllerList)
						{
							if (1 == arrayList4.Count)
							{
								arrayList.Add(arrayList4[0]);
							}
						}
						arrayList.Sort(0, arrayList.Count, null);
						num = -1;
						if (0 < ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().secondController.Count)
						{
							foreach (object item4 in arrayList)
							{
								int num4 = (int)item4;
								if (num4 > (int)((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().secondController[0])
								{
									num = num4;
									break;
								}
							}
						}
						else if (0 < arrayList.Count)
						{
							num = (int)arrayList[0];
						}
						flag = ((-1 != num) ? ((!sGraphicsAdapter.get_displaysManagerCloneSupported()) ? ((!sGraphicsAdapter.get_displaysManagerStretchSupported()) ? ((!sGraphicsAdapter.get_displaysManagerExtendedSupported()) ? TogglePossibleModes_MakeSingle(iGraphicsCaste, sGraphicsAdapter) : TogglePossibleModes_MakeExtended(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeHStretch(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeDualClone(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeSingle(iGraphicsCaste, sGraphicsAdapter));
						break;
					}
					case 5:
					{
						num = (int)((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().secondController[0];
						if (sGraphicsAdapter.get_displaysManagerStretchSupported())
						{
							flag = TogglePossibleModes_MakeVStretch(iGraphicsCaste, sGraphicsAdapter, num);
							break;
						}
						if (sGraphicsAdapter.get_displaysManagerExtendedSupported())
						{
							flag = TogglePossibleModes_MakeExtended(iGraphicsCaste, sGraphicsAdapter, num);
							break;
						}
						arrayList = new ArrayList();
						ArrayList[] secondControllerList = sGraphicsAdapter.displaysManagerInfo.get_secondControllerList();
						foreach (ArrayList arrayList2 in secondControllerList)
						{
							if (1 == arrayList2.Count)
							{
								arrayList.Add(arrayList2[0]);
							}
						}
						arrayList.Sort(0, arrayList.Count, null);
						num = -1;
						if (0 < ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().secondController.Count)
						{
							foreach (object item5 in arrayList)
							{
								int num2 = (int)item5;
								if (num2 > (int)((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().secondController[0])
								{
									num = num2;
									break;
								}
							}
						}
						else if (0 < arrayList.Count)
						{
							num = (int)arrayList[0];
						}
						flag = ((-1 != num) ? ((!sGraphicsAdapter.get_displaysManagerCloneSupported()) ? ((!sGraphicsAdapter.get_displaysManagerStretchSupported()) ? ((!sGraphicsAdapter.get_displaysManagerExtendedSupported()) ? TogglePossibleModes_MakeSingle(iGraphicsCaste, sGraphicsAdapter) : TogglePossibleModes_MakeExtended(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeHStretch(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeDualClone(iGraphicsCaste, sGraphicsAdapter, num)) : TogglePossibleModes_MakeSingle(iGraphicsCaste, sGraphicsAdapter));
						break;
					}
					case 3:
					case 6:
					case 7:
					case 8:
					case 9:
						flag = TogglePossibleModes_MakeSingle(iGraphicsCaste, sGraphicsAdapter);
						break;
					}
					if (flag)
					{
						iComponent.Apply(true);
						return flag;
					}
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception ex)
		{
			Services.Exception(ex);
			return flag;
		}
	}

	private static bool TogglePossibleModes_MakeSingle(IGraphicsCaste iGraphicsCaste, SGraphicsAdapter sGraphicsAdapter)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected I4, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Invalid comparison between I4 and Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		bool flag = false;
		ArrayList arrayList = new ArrayList();
		DM_INFO val = null;
		SGraphicsAdapter val2 = sGraphicsAdapter;
		MANNERISM manner = ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().linkInfo.manner;
		switch ((int)manner)
		{
		case 0:
			if (((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().firstController.Count == 0)
			{
				flag = true;
			}
			break;
		case 1:
		case 7:
		{
			SGraphicsAdapter val3 = null;
			if (sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex() <= sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex())
			{
				if (sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex() != ((SAdapter)sGraphicsAdapter).index)
				{
					SAdapter sAdapter = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex());
					val2 = (SGraphicsAdapter)(object)((sAdapter is SGraphicsAdapter) ? sAdapter : null);
				}
				SAdapter sAdapter2 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex());
				val3 = (SGraphicsAdapter)(object)((sAdapter2 is SGraphicsAdapter) ? sAdapter2 : null);
			}
			else
			{
				if (sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex() != ((SAdapter)sGraphicsAdapter).index)
				{
					SAdapter sAdapter3 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex());
					val2 = (SGraphicsAdapter)(object)((sAdapter3 is SGraphicsAdapter) ? sAdapter3 : null);
				}
				SAdapter sAdapter4 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex());
				val3 = (SGraphicsAdapter)(object)((sAdapter4 is SGraphicsAdapter) ? sAdapter4 : null);
			}
			val = new DM_INFO(((SAdapter)val3).index, false, false, ((SPropertySetting_MODEINFO)val3.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val3.displaysManagerInfo.mapping.Control).get_C(), false);
			arrayList.Add(val);
			val = null;
			if (7 == (int)((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().linkInfo.manner)
			{
				flag = true;
			}
			break;
		}
		case 3:
		case 6:
		case 8:
		case 9:
			flag = true;
			break;
		}
		ArrayList arrayList2 = new ArrayList();
		ArrayList arrayList3 = new ArrayList();
		ArrayList arrayList4 = null;
		iGraphicsCaste.GetControllerAllPossibleMapping(((SAdapter)val2).index, 0, arrayList2, ref arrayList4);
		foreach (ArrayList item in arrayList4)
		{
			if (1 == item.Count)
			{
				arrayList3.Add((int)item[0]);
			}
		}
		arrayList3.Sort(0, arrayList3.Count, null);
		if (0 < arrayList3.Count)
		{
			result = true;
			int num = (int)arrayList3[0];
			if (!flag && 0 < ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C().firstController.Count)
			{
				foreach (object item2 in arrayList3)
				{
					int num2 = (int)item2;
					if (num2 > (int)((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C().firstController[0])
					{
						num = num2;
						break;
					}
				}
			}
			val = new DM_INFO(((SAdapter)val2).index, ((SPropertySetting_bool)val2.displaysManagerInfo.active.Control).get_C(), ((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
			val.mappinginfo.firstController.Clear();
			val.mappinginfo.secondController.Clear();
			val.mappinginfo.firstController.Add(num);
			val.mappinginfo.linkInfo.manner = (MANNERISM)0;
			arrayList.Add(val);
			val = null;
			iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList);
		}
		return result;
	}

	private static bool TogglePossibleModes_MakeDualClone(IGraphicsCaste iGraphicsCaste, SGraphicsAdapter sGraphicsAdapter, int secondControlerIndex)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected I4, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		ArrayList arrayList = new ArrayList();
		DM_INFO val = null;
		SGraphicsAdapter val2 = sGraphicsAdapter;
		MANNERISM manner = ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().linkInfo.manner;
		switch ((int)manner)
		{
		case 0:
			if (((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C().firstController.Count == 0)
			{
				Services.LogError("Not supporting making DualClone from single manner which first controller has no devices mapped");
				break;
			}
			flag = true;
			val = new DM_INFO(((SAdapter)val2).index, ((SPropertySetting_bool)val2.displaysManagerInfo.active.Control).get_C(), ((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
			val.mappinginfo.secondController.Clear();
			val.mappinginfo.secondController.Add(secondControlerIndex);
			val.mappinginfo.linkInfo.manner = (MANNERISM)2;
			arrayList.Add(val);
			val = null;
			break;
		case 1:
		{
			flag = true;
			SGraphicsAdapter val3 = null;
			if (sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex() <= sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex())
			{
				if (sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex() != ((SAdapter)sGraphicsAdapter).index)
				{
					SAdapter sAdapter = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex());
					val2 = (SGraphicsAdapter)(object)((sAdapter is SGraphicsAdapter) ? sAdapter : null);
				}
				SAdapter sAdapter2 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex());
				val3 = (SGraphicsAdapter)(object)((sAdapter2 is SGraphicsAdapter) ? sAdapter2 : null);
			}
			else
			{
				if (sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex() != ((SAdapter)sGraphicsAdapter).index)
				{
					SAdapter sAdapter3 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex());
					val2 = (SGraphicsAdapter)(object)((sAdapter3 is SGraphicsAdapter) ? sAdapter3 : null);
				}
				SAdapter sAdapter4 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex());
				val3 = (SGraphicsAdapter)(object)((sAdapter4 is SGraphicsAdapter) ? sAdapter4 : null);
			}
			val = new DM_INFO(((SAdapter)val3).index, false, false, ((SPropertySetting_MODEINFO)val3.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val3.displaysManagerInfo.mapping.Control).get_C(), false);
			arrayList.Add(val);
			val = new DM_INFO(((SAdapter)val2).index, ((SPropertySetting_bool)val2.displaysManagerInfo.active.Control).get_C(), ((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
			val.mappinginfo.secondController.Clear();
			val.mappinginfo.secondController.Add(secondControlerIndex);
			val.mappinginfo.linkInfo.manner = (MANNERISM)2;
			arrayList.Add(val);
			val = null;
			break;
		}
		case 2:
		case 4:
		case 5:
			flag = true;
			val = new DM_INFO(((SAdapter)val2).index, ((SPropertySetting_bool)val2.displaysManagerInfo.active.Control).get_C(), ((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
			val.mappinginfo.secondController.Clear();
			val.mappinginfo.secondController.Add(secondControlerIndex);
			val.mappinginfo.linkInfo.manner = (MANNERISM)2;
			arrayList.Add(val);
			val = null;
			break;
		case 3:
		case 6:
		case 7:
		case 8:
		case 9:
			Services.LogError("Not supporting making DualClone from any kind of single clone manner");
			break;
		}
		if (flag || 0 < arrayList.Count)
		{
			iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList);
		}
		return flag;
	}

	private static bool TogglePossibleModes_MakeHStretch(IGraphicsCaste iGraphicsCaste, SGraphicsAdapter sGraphicsAdapter, int secondControlerIndex)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected I4, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		ArrayList arrayList = new ArrayList();
		DM_INFO val = null;
		SGraphicsAdapter val2 = sGraphicsAdapter;
		MANNERISM manner = ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().linkInfo.manner;
		switch ((int)manner)
		{
		case 0:
			if (((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C().firstController.Count == 0)
			{
				Services.LogError("Not supporting making HStretch from single manner which first controller has no devices mapped");
				break;
			}
			flag = true;
			val = new DM_INFO(((SAdapter)val2).index, ((SPropertySetting_bool)val2.displaysManagerInfo.active.Control).get_C(), ((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
			val.mappinginfo.secondController.Clear();
			val.mappinginfo.secondController.Add(secondControlerIndex);
			val.mappinginfo.linkInfo.manner = (MANNERISM)5;
			arrayList.Add(val);
			val = null;
			break;
		case 1:
		{
			flag = true;
			SGraphicsAdapter val3 = null;
			if (sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex() <= sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex())
			{
				if (sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex() != ((SAdapter)sGraphicsAdapter).index)
				{
					SAdapter sAdapter = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex());
					val2 = (SGraphicsAdapter)(object)((sAdapter is SGraphicsAdapter) ? sAdapter : null);
				}
				SAdapter sAdapter2 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex());
				val3 = (SGraphicsAdapter)(object)((sAdapter2 is SGraphicsAdapter) ? sAdapter2 : null);
			}
			else
			{
				if (sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex() != ((SAdapter)sGraphicsAdapter).index)
				{
					SAdapter sAdapter3 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex());
					val2 = (SGraphicsAdapter)(object)((sAdapter3 is SGraphicsAdapter) ? sAdapter3 : null);
				}
				SAdapter sAdapter4 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex());
				val3 = (SGraphicsAdapter)(object)((sAdapter4 is SGraphicsAdapter) ? sAdapter4 : null);
			}
			val = new DM_INFO(((SAdapter)val3).index, false, false, ((SPropertySetting_MODEINFO)val3.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val3.displaysManagerInfo.mapping.Control).get_C(), false);
			arrayList.Add(val);
			val = new DM_INFO(((SAdapter)val2).index, ((SPropertySetting_bool)val2.displaysManagerInfo.active.Control).get_C(), ((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
			val.mappinginfo.secondController.Clear();
			val.mappinginfo.secondController.Add(secondControlerIndex);
			val.mappinginfo.linkInfo.manner = (MANNERISM)5;
			arrayList.Add(val);
			val = null;
			break;
		}
		case 2:
		case 4:
		case 5:
			flag = true;
			val = new DM_INFO(((SAdapter)val2).index, ((SPropertySetting_bool)val2.displaysManagerInfo.active.Control).get_C(), ((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
			val.mappinginfo.secondController.Clear();
			val.mappinginfo.secondController.Add(secondControlerIndex);
			val.mappinginfo.linkInfo.manner = (MANNERISM)5;
			arrayList.Add(val);
			val = null;
			break;
		case 3:
		case 6:
		case 7:
		case 8:
		case 9:
			Services.LogError("Not supporting making HStretch from any kind of single clone manner");
			break;
		}
		if (flag || 0 < arrayList.Count)
		{
			iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList);
		}
		return flag;
	}

	private static bool TogglePossibleModes_MakeVStretch(IGraphicsCaste iGraphicsCaste, SGraphicsAdapter sGraphicsAdapter, int secondControlerIndex)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected I4, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		ArrayList arrayList = new ArrayList();
		DM_INFO val = null;
		SGraphicsAdapter val2 = sGraphicsAdapter;
		MANNERISM manner = ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().linkInfo.manner;
		switch ((int)manner)
		{
		case 0:
			if (((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C().firstController.Count == 0)
			{
				Services.LogError("Not supporting making VStretch from single manner which first controller has no devices mapped");
				break;
			}
			flag = true;
			val = new DM_INFO(((SAdapter)val2).index, ((SPropertySetting_bool)val2.displaysManagerInfo.active.Control).get_C(), ((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
			val.mappinginfo.secondController.Clear();
			val.mappinginfo.secondController.Add(secondControlerIndex);
			val.mappinginfo.linkInfo.manner = (MANNERISM)4;
			arrayList.Add(val);
			val = null;
			break;
		case 1:
		{
			flag = true;
			SGraphicsAdapter val3 = null;
			if (sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex() <= sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex())
			{
				if (sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex() != ((SAdapter)sGraphicsAdapter).index)
				{
					SAdapter sAdapter = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex());
					val2 = (SGraphicsAdapter)(object)((sAdapter is SGraphicsAdapter) ? sAdapter : null);
				}
				SAdapter sAdapter2 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex());
				val3 = (SGraphicsAdapter)(object)((sAdapter2 is SGraphicsAdapter) ? sAdapter2 : null);
			}
			else
			{
				if (sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex() != ((SAdapter)sGraphicsAdapter).index)
				{
					SAdapter sAdapter3 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex());
					val2 = (SGraphicsAdapter)(object)((sAdapter3 is SGraphicsAdapter) ? sAdapter3 : null);
				}
				SAdapter sAdapter4 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex());
				val3 = (SGraphicsAdapter)(object)((sAdapter4 is SGraphicsAdapter) ? sAdapter4 : null);
			}
			val = new DM_INFO(((SAdapter)val3).index, false, false, ((SPropertySetting_MODEINFO)val3.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val3.displaysManagerInfo.mapping.Control).get_C(), false);
			arrayList.Add(val);
			val = new DM_INFO(((SAdapter)val2).index, ((SPropertySetting_bool)val2.displaysManagerInfo.active.Control).get_C(), ((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
			val.mappinginfo.secondController.Clear();
			val.mappinginfo.secondController.Add(secondControlerIndex);
			val.mappinginfo.linkInfo.manner = (MANNERISM)4;
			arrayList.Add(val);
			val = null;
			break;
		}
		case 2:
		case 4:
		case 5:
			flag = true;
			val = new DM_INFO(((SAdapter)val2).index, ((SPropertySetting_bool)val2.displaysManagerInfo.active.Control).get_C(), ((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
			val.mappinginfo.secondController.Clear();
			val.mappinginfo.secondController.Add(secondControlerIndex);
			val.mappinginfo.linkInfo.manner = (MANNERISM)4;
			arrayList.Add(val);
			val = null;
			break;
		case 3:
		case 6:
		case 7:
		case 8:
		case 9:
			Services.LogError("Not supporting making VStretch from any kind of single clone manner");
			break;
		}
		if (flag || 0 < arrayList.Count)
		{
			iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList);
		}
		return flag;
	}

	private static bool TogglePossibleModes_MakeExtended(IGraphicsCaste iGraphicsCaste, SGraphicsAdapter sGraphicsAdapter, int secondControlerIndex)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected I4, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		bool flag = false;
		ArrayList arrayList = new ArrayList();
		DM_INFO val = null;
		SGraphicsAdapter val2 = sGraphicsAdapter;
		MANNERISM manner = ((SPropertySetting_MAPPINGINFO)sGraphicsAdapter.displaysManagerInfo.mapping.Control).get_C().linkInfo.manner;
		switch ((int)manner)
		{
		case 0:
		{
			if (((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C().firstController.Count == 0)
			{
				Services.LogError("Not supporting making Extended from single manner which first controller has no devices mapped");
				break;
			}
			flag = true;
			val = new DM_INFO(((SAdapter)val2).index, ((SPropertySetting_bool)val2.displaysManagerInfo.active.Control).get_C(), ((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
			val.mappinginfo.secondController.Clear();
			val.mappinginfo.secondController.Add(secondControlerIndex);
			val.mappinginfo.linkInfo.manner = (MANNERISM)1;
			arrayList.Add(val);
			int[] associatedAllAdapters = val2.get_associatedAllAdapters();
			foreach (int num2 in associatedAllAdapters)
			{
				SAdapter sAdapter4 = ((ICaste)iGraphicsCaste).GetSAdapter(num2);
				SGraphicsAdapter val4 = (SGraphicsAdapter)(object)((sAdapter4 is SGraphicsAdapter) ? sAdapter4 : null);
				if (val4 != null && !((SAdapter)val4).get_active())
				{
					val = new DM_INFO(((SAdapter)val4).index, true, ((SPropertySetting_bool)val4.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val4.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val4.displaysManagerInfo.mapping.Control).get_C(), false);
					arrayList.Add(val);
					break;
				}
			}
			val = null;
			break;
		}
		case 1:
			flag = true;
			if (sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex() <= sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex())
			{
				if (sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex() != ((SAdapter)sGraphicsAdapter).index)
				{
					SAdapter sAdapter2 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_firstControllerDEMAdapterIndex());
					val2 = (SGraphicsAdapter)(object)((sAdapter2 is SGraphicsAdapter) ? sAdapter2 : null);
				}
			}
			else if (sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex() != ((SAdapter)sGraphicsAdapter).index)
			{
				SAdapter sAdapter3 = ((ICaste)iGraphicsCaste).GetSAdapter(sGraphicsAdapter.displaysManagerInfo.get_secondControllerDEMAdapterIndex());
				val2 = (SGraphicsAdapter)(object)((sAdapter3 is SGraphicsAdapter) ? sAdapter3 : null);
			}
			val = new DM_INFO(((SAdapter)val2).index, ((SPropertySetting_bool)val2.displaysManagerInfo.active.Control).get_C(), ((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
			val.mappinginfo.secondController.Clear();
			val.mappinginfo.secondController.Add(secondControlerIndex);
			val.mappinginfo.linkInfo.manner = (MANNERISM)1;
			arrayList.Add(val);
			val = null;
			break;
		case 2:
		case 4:
		case 5:
		{
			flag = true;
			val = new DM_INFO(((SAdapter)val2).index, ((SPropertySetting_bool)val2.displaysManagerInfo.active.Control).get_C(), ((SPropertySetting_bool)val2.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val2.displaysManagerInfo.mapping.Control).get_C(), false);
			val.mappinginfo.secondController.Clear();
			val.mappinginfo.secondController.Add(secondControlerIndex);
			val.mappinginfo.linkInfo.manner = (MANNERISM)1;
			arrayList.Add(val);
			int[] associatedAllAdapters = val2.get_associatedAllAdapters();
			foreach (int num in associatedAllAdapters)
			{
				SAdapter sAdapter = ((ICaste)iGraphicsCaste).GetSAdapter(num);
				SGraphicsAdapter val3 = (SGraphicsAdapter)(object)((sAdapter is SGraphicsAdapter) ? sAdapter : null);
				if (val3 != null && !((SAdapter)val3).get_active())
				{
					val = new DM_INFO(((SAdapter)val3).index, true, ((SPropertySetting_bool)val3.displaysManagerInfo.primary.Control).get_C(), ((SPropertySetting_MODEINFO)val3.displaysManagerInfo.mode.Control).get_C(), ((SPropertySetting_MAPPINGINFO)val3.displaysManagerInfo.mapping.Control).get_C(), false);
					arrayList.Add(val);
					break;
				}
			}
			val = null;
			break;
		}
		case 3:
		case 6:
		case 7:
		case 8:
		case 9:
			Services.LogError("Not supporting making Extended from any kind of single clone manner");
			break;
		}
		if (flag || 0 < arrayList.Count)
		{
			iGraphicsCaste.RequestDisplaysManagerMultipleAssign(arrayList);
		}
		return flag;
	}
}
