using System;
using System.Runtime.InteropServices;
using Intuit.Spc.Map.HelpSystem.HelpInterfaces;

namespace Intuit.Spc.Map.HelpSystem;

[Guid("5B97275F-F9D2-4468-A401-B9B591A71A76")]
[ProgId("Intuit.Spc.Map.HelpSystem.IntuitHelpClassFactory")]
[ClassInterface(ClassInterfaceType.None)]
public class IntuitHelpClassFactory : ClassFactoryBase
{
	public override void virtual_CreateInstance(IntPtr pUnkOuter, ref Guid riid, out IntPtr ppvObject)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		if (IntuitHelpServer.ObjectsCount == 0)
		{
			if (!(riid == Marshal.GenerateGuidForType(typeof(IHelpSystem))) && !(riid == IntuitHelpServer.IID_IDispatch) && !(riid == IntuitHelpServer.IID_IUnknown))
			{
				throw new COMException("No interface", -2147467262);
			}
			AttemptTerminateServer val = new AttemptTerminateServer(IntuitHelpServer.AttemptToTerminateServer);
			DecrementObjectsCount val2 = new DecrementObjectsCount(IntuitHelpServer.InterlockedDecrementObjectsCount);
			IncermentObjectsCount val3 = new IncermentObjectsCount(IntuitHelpServer.InterlockedIncrementObjectsCount);
			IHelpSystem o = (IHelpSystem)new HelpSystem(val3, val2, val);
			ppvObject = Marshal.GetComInterfaceForObject(o, typeof(IHelpSystem));
		}
		else
		{
			ppvObject = Marshal.GetComInterfaceForObject(null, null);
		}
	}
}
