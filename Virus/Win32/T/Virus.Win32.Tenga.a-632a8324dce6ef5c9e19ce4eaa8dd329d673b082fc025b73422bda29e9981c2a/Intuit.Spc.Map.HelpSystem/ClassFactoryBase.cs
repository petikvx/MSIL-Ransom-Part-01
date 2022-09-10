using System;
using System.Runtime.InteropServices;

namespace Intuit.Spc.Map.HelpSystem;

public class ClassFactoryBase : IClassFactory
{
	protected uint m_locked;

	protected uint m_ClassContext = 4u;

	protected Guid m_ClassId;

	protected uint m_Flags;

	protected uint m_Cookie;

	public uint ClassContext
	{
		get
		{
			return m_ClassContext;
		}
		set
		{
			m_ClassContext = value;
		}
	}

	public Guid ClassId
	{
		get
		{
			return m_ClassId;
		}
		set
		{
			m_ClassId = value;
		}
	}

	public uint Flags
	{
		get
		{
			return m_Flags;
		}
		set
		{
			m_Flags = value;
		}
	}

	[DllImport("ole32.dll")]
	private static extern int CoRegisterClassObject([In] ref Guid rclsid, [MarshalAs(UnmanagedType.IUnknown)] object pUnk, uint dwClsContext, uint flags, out uint lpdwRegister);

	[DllImport("ole32.dll")]
	private static extern int CoResumeClassObjects();

	[DllImport("ole32.dll")]
	private static extern int CoRevokeClassObject(uint dwRegister);

	public virtual void virtual_CreateInstance(IntPtr pUnkOuter, ref Guid riid, out IntPtr ppvObject)
	{
		IntPtr intPtr = (ppvObject = new IntPtr(0));
	}

	public bool RegisterClassObject()
	{
		if (CoRegisterClassObject(ref m_ClassId, this, ClassContext, Flags, out m_Cookie) == 0)
		{
			return true;
		}
		return false;
	}

	public bool RevokeClassObject()
	{
		if (CoRevokeClassObject(m_Cookie) == 0)
		{
			return true;
		}
		return false;
	}

	public static bool ResumeClassObjects()
	{
		if (CoResumeClassObjects() == 0)
		{
			return true;
		}
		return false;
	}

	public void CreateInstance(IntPtr pUnkOuter, ref Guid riid, out IntPtr ppvObject)
	{
		virtual_CreateInstance(pUnkOuter, ref riid, out ppvObject);
	}

	public void LockServer(bool bLock)
	{
		if (bLock)
		{
			IntuitHelpServer.InterlockedIncrementServerLockCount();
		}
		else
		{
			IntuitHelpServer.InterlockedDecrementServerLockCount();
		}
		IntuitHelpServer.AttemptToTerminateServer();
	}
}
