using System.Collections.Generic;
using Aspect;
using Entity;
using Entity.Attribute;

[CanExecute]
[LogAspect]
public class GClass8
{
	[CanExecute]
	public List<PasswordInfo> method_0()
	{
		return (List<PasswordInfo>)Class29.smethod_0(7524653, this, null);
	}

	[CanExecute]
	public List<InternetConnection> method_1()
	{
		return (List<InternetConnection>)Class29.smethod_0(7528426, this, null);
	}

	[CanExecute]
	public List<FirewallInfo> method_2()
	{
		return (List<FirewallInfo>)Class29.smethod_0(7527870, this, null);
	}

	[CanExecute]
	public FingerprintInfo method_3()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return (FingerprintInfo)Class29.smethod_0(7527382, this, null);
	}

	[CanExecute]
	public static List<AntiVirus> smethod_0()
	{
		return (List<AntiVirus>)Class29.smethod_0(7526814, null, null);
	}
}
