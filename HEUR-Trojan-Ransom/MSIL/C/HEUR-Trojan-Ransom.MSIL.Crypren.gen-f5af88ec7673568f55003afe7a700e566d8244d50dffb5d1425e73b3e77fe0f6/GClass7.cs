using System.Collections.Generic;
using Aspect;
using Entity;
using Entity.Attribute;
using Entity.Snapshot;

[CanExecute]
[LogAspect]
public class GClass7
{
	private static string string_0;

	private static string string_1;

	private static string string_2;

	private static string string_3;

	[CanExecute]
	public List<DeviceManagerInfo> method_0()
	{
		return (List<DeviceManagerInfo>)Class29.smethod_0(7535529, this, null);
	}

	[CanExecute]
	[UacMethod]
	public void method_1(string string_4)
	{
		Class29.smethod_0(7535057, this, string_4);
	}

	[UacMethod]
	[CanExecute]
	public void method_2(string string_4, string string_5, string string_6)
	{
		Class29.smethod_0(7522268, this, string_4, string_5, string_6);
	}

	[CanExecute]
	[UacMethod]
	public void method_3()
	{
		Class29.smethod_0(7521543, this, null);
	}

	[CanExecute]
	public HWScanInfo method_4()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return (HWScanInfo)Class29.smethod_0(7521050, this, null);
	}

	[CanExecute]
	public TaskInfo method_5()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return (TaskInfo)Class29.smethod_0(7520571, this, null);
	}

	[CanExecute]
	public Alert method_6()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return (Alert)Class29.smethod_0(7524349, this, null);
	}

	[CanExecute]
	public PredictiveInfo method_7(string string_4)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		return (PredictiveInfo)Class29.smethod_0(7523618, this, string_4);
	}

	[CanExecute]
	public SnapshotInfo method_8(string string_4)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		return (SnapshotInfo)Class29.smethod_0(7523142, this, string_4);
	}

	[CanExecute]
	public SnapshotInfo method_9()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return (SnapshotInfo)Class29.smethod_0(7522651, this, null);
	}

	[CanExecute]
	public SystemMonitorInfo method_10(string string_4)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		return (SystemMonitorInfo)Class29.smethod_0(7526257, this, string_4);
	}

	[CanExecute]
	public void method_11()
	{
		Class29.smethod_0(7525729, this, null);
	}

	[CanExecute]
	public void method_12(string string_4)
	{
		Class29.smethod_0(7525555, this, string_4);
	}

	[CanExecute]
	public int method_13()
	{
		return (int)Class29.smethod_0(7525160, this, null);
	}

	static GClass7()
	{
		Class29.smethod_0(7525237, null, null);
	}
}
