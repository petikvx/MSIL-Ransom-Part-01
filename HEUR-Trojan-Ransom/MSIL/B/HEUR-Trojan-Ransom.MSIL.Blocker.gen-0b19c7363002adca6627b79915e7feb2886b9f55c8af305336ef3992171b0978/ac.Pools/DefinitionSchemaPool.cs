using System;
using System.Diagnostics;
using Tsjxretch.Collections;
using Tsjxretch.Factories;
using ac.Exporters;

namespace ac.Pools;

public static class DefinitionSchemaPool
{
	internal static DefinitionSchemaPool PostDic;

	[STAThread]
	public static void MapMerchant(string[] args)
	{
		int num = 10;
		IntPtr mainWindowHandle = default(IntPtr);
		while (true)
		{
			IL_0116:
			int num2;
			if (args.Length == 0)
			{
				num2 = 9;
				if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_0c2c6d8570054d4b994b02468af36249 == 0)
				{
					goto IL_002a;
				}
				goto IL_00b5;
			}
			goto IL_00e8;
			IL_002a:
			num2 = num;
			goto IL_00b5;
			IL_00e8:
			Console.WriteLine("Test");
			num2 = 0;
			if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_e80e0b6eb45a4e8cae93d950718ba116 == 0)
			{
				goto IL_0033;
			}
			goto IL_00b5;
			IL_00b5:
			while (true)
			{
				switch (num2)
				{
				case 9:
					break;
				case 1:
				case 7:
				case 8:
					goto end_IL_00b5;
				case 3:
				case 6:
					goto IL_004c;
				case 2:
					StateAdapterFactory.GetMerchant("Start-Sleep -s 5").WaitForExit();
					num2 = 0;
					if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_f325a505980d4513a75b01a8cb4f150f == 0)
					{
						continue;
					}
					goto default;
				default:
					StateAdapterFactory.GetMerchant("Start-Sleep -s 5").WaitForExit();
					num2 = 8;
					if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_9a63a7152d7443d786ba6cf6214725ae == 0)
					{
						continue;
					}
					goto IL_002a;
				case 5:
					goto IL_00e8;
				case 10:
					goto IL_0116;
				case 4:
					Database.CheckMerchant();
					return;
				}
				mainWindowHandle = Process.GetCurrentProcess().MainWindowHandle;
				num2 = 6;
				if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_dc40f82dd323485089ad0e79e11f49d0 == 0)
				{
					continue;
				}
				goto IL_002a;
				IL_004c:
				ReponseFieldExporter.ShowWindow(mainWindowHandle.ToInt32(), 0);
				StateAdapterFactory.GetMerchant("Start-Sleep -s 5").WaitForExit();
				num2 = 2;
				if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_6170d2f824924d33908c58678f601e42 == 0)
				{
					continue;
				}
				goto IL_002a;
				continue;
				end_IL_00b5:
				break;
			}
			goto IL_0033;
			IL_0033:
			if (Database.OrderMerchant())
			{
				num2 = 4;
				if (_003CModule_003E_007B97c19ca2_002Dd30d_002D4926_002Db319_002D0f9297a6a699_007D.m_a40ac98667d546268942a61b1ac3f33d != 0)
				{
					goto IL_002a;
				}
				goto IL_00b5;
			}
			break;
		}
	}

	internal static bool ResetDic()
	{
		return PostDic == null;
	}

	internal static DefinitionSchemaPool PatchDic()
	{
		return PostDic;
	}
}
