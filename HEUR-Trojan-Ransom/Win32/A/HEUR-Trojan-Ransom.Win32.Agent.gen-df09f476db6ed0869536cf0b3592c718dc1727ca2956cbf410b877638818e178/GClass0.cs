using System;
using System.Net;
using System.Runtime.CompilerServices;

public abstract class GClass0 : GInterface0
{
	private DateTime dateTime_0;

	protected GClass0()
	{
		Class51.smethod_0();
		base._002Ector();
	}

	[SpecialName]
	public DateTime imethod_15()
	{
		return dateTime_0;
	}

	[SpecialName]
	public void imethod_16(DateTime dateTime_1)
	{
		dateTime_0 = dateTime_1;
	}

	public virtual void imethod_0(GClass2 gclass2_0)
	{
		IAsyncResult iasyncResult_ = imethod_5(gclass2_0, null, null);
		imethod_10(iasyncResult_);
	}

	public virtual void imethod_1(GClass2 gclass2_0)
	{
		IAsyncResult iasyncResult_ = imethod_6(gclass2_0, null, gclass2_0);
		imethod_11(iasyncResult_);
	}

	public virtual GClass2[] imethod_2()
	{
		IAsyncResult iasyncResult_ = imethod_7(null, null);
		return imethod_12(iasyncResult_);
	}

	public virtual IPAddress imethod_3()
	{
		IAsyncResult iasyncResult_ = imethod_8(null, null);
		return imethod_13(iasyncResult_);
	}

	public virtual GClass2 imethod_4(GEnum1 genum1_0, int int_0)
	{
		IAsyncResult iasyncResult_ = imethod_9(genum1_0, int_0, null, null);
		return imethod_14(iasyncResult_);
	}

	public abstract IAsyncResult imethod_5(GClass2 gclass2_0, AsyncCallback asyncCallback_0, object object_0);

	public abstract IAsyncResult imethod_6(GClass2 gclass2_0, AsyncCallback asyncCallback_0, object object_0);

	public abstract IAsyncResult imethod_7(AsyncCallback asyncCallback_0, object object_0);

	public abstract IAsyncResult imethod_8(AsyncCallback asyncCallback_0, object object_0);

	public abstract IAsyncResult imethod_9(GEnum1 genum1_0, int int_0, AsyncCallback asyncCallback_0, object object_0);

	public abstract void imethod_10(IAsyncResult iasyncResult_0);

	public abstract void imethod_11(IAsyncResult iasyncResult_0);

	public abstract GClass2[] imethod_12(IAsyncResult iasyncResult_0);

	public abstract IPAddress imethod_13(IAsyncResult iasyncResult_0);

	public abstract GClass2 imethod_14(IAsyncResult iasyncResult_0);
}
