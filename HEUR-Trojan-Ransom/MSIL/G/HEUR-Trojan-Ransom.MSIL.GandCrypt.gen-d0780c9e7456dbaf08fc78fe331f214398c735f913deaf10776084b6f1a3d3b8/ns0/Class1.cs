using System;
using System.ComponentModel;
using System.Runtime.Remoting;

namespace ns0;

internal sealed class Class1 : BackgroundWorker
{
	public override ISite ISite_0
	{
		get
		{
			return base.Site;
		}
		set
		{
			base.Site = value;
		}
	}

	protected override bool Boolean_0 => base.CanRaiseEvents;

	internal static byte[] smethod_0()
	{
		return Attribute0.smethod_0(Class0.smethod_0(), new byte[25]
		{
			137, 33, 108, 47, 140, 35, 65, 73, 53, 81,
			25, 22, 151, 86, 124, 132, 12, 72, 27, 1,
			133, 36, 113, 50, 111
		});
	}

	public override ObjRef vmethod_0(Type type_0)
	{
		return ((MarshalByRefObject)this).CreateObjRef(type_0);
	}

	public override bool vmethod_1(object object_0)
	{
		return base.Equals(object_0);
	}

	public override int vmethod_2()
	{
		return base.GetHashCode();
	}

	public override object vmethod_3()
	{
		return base.InitializeLifetimeService();
	}

	public override string vmethod_4()
	{
		return ToString();
	}

	protected override void vmethod_5(bool bool_0)
	{
		((Component)this).Dispose(bool_0);
	}

	protected override object vmethod_6(Type type_0)
	{
		return base.GetService(type_0);
	}

	protected override void vmethod_7(DoWorkEventArgs doWorkEventArgs_0)
	{
		base.OnDoWork(doWorkEventArgs_0);
	}

	protected override void vmethod_8(ProgressChangedEventArgs progressChangedEventArgs_0)
	{
		base.OnProgressChanged(progressChangedEventArgs_0);
	}

	protected override void vmethod_9(RunWorkerCompletedEventArgs runWorkerCompletedEventArgs_0)
	{
		base.OnRunWorkerCompleted(runWorkerCompletedEventArgs_0);
	}
}
