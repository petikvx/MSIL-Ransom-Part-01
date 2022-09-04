using System;
using System.Net;
using System.Runtime.CompilerServices;

public interface GInterface0
{
	void imethod_0(GClass2 gclass2_0);

	void imethod_1(GClass2 gclass2_0);

	GClass2[] imethod_2();

	IPAddress imethod_3();

	GClass2 imethod_4(GEnum1 genum1_0, int int_0);

	IAsyncResult imethod_5(GClass2 gclass2_0, AsyncCallback asyncCallback_0, object object_0);

	IAsyncResult imethod_6(GClass2 gclass2_0, AsyncCallback asyncCallback_0, object object_0);

	IAsyncResult imethod_7(AsyncCallback asyncCallback_0, object object_0);

	IAsyncResult imethod_8(AsyncCallback asyncCallback_0, object object_0);

	IAsyncResult imethod_9(GEnum1 genum1_0, int int_0, AsyncCallback asyncCallback_0, object object_0);

	void imethod_10(IAsyncResult iasyncResult_0);

	void imethod_11(IAsyncResult iasyncResult_0);

	GClass2[] imethod_12(IAsyncResult iasyncResult_0);

	IPAddress imethod_13(IAsyncResult iasyncResult_0);

	GClass2 imethod_14(IAsyncResult iasyncResult_0);

	[SpecialName]
	DateTime imethod_15();

	[SpecialName]
	void imethod_16(DateTime dateTime_0);
}
