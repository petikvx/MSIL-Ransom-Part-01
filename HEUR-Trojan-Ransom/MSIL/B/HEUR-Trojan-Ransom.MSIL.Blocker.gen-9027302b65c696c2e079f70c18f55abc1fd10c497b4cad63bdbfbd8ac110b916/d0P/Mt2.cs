using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bo6;
using Dp4o9T;
using Dt7;
using Ed65Hf;
using Ed9;
using Ei07De;
using Gp;
using Jg8;
using Jm0r4W;
using Jr39Qo;
using Js9;
using Kj87Xi;
using Lk;
using Microsoft.VisualBasic.CompilerServices;
using Rn1;
using Sn7x6Z;
using c1CLx2;
using e2;
using g8GLd9;
using j1H5Ld;
using n2Z;
using o1KZx9;
using p6MRy9;
using s9;
using t5C8Kg;
using t7S;
using w0XGc7;
using x6T;

namespace d0P;

[DesignerGenerated]
public class Mt2
{
	internal sealed class Ke5
	{
		internal object object_0;

		internal object object_1;

		internal object object_2;

		internal int int_0;

		internal Ke5()
		{
		}
	}

	[AccessedThroughProperty("btnStop")]
	private object _btnStop;

	[AccessedThroughProperty("btnRefresh")]
	private object _btnRefresh;

	[AccessedThroughProperty("wbUse")]
	private WebBrowser _wbUse;

	private Bs.f9 f9_0 = new Bs.f9();

	internal virtual object btnClose
	{
		get
		{
			return f9_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			f9_0.object_0 = objectValue;
		}
	}

	internal virtual object SimpleButton1
	{
		get
		{
			return f9_0.object_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			f9_0.object_1 = objectValue;
		}
	}

	internal virtual object btnBack
	{
		get
		{
			return f9_0.object_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			f9_0.object_2 = objectValue;
		}
	}

	internal virtual object btnStop
	{
		get
		{
			return _btnStop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnStop = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object btnGo
	{
		get
		{
			return f9_0.object_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			f9_0.object_3 = objectValue;
		}
	}

	internal virtual object btnRefresh
	{
		get
		{
			return _btnRefresh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_btnRefresh = RuntimeHelpers.GetObjectValue(value);
		}
	}

	internal virtual object txtUrl
	{
		get
		{
			return f9_0.object_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			f9_0.object_4 = objectValue;
		}
	}

	internal virtual WebBrowser wbUse
	{
		get
		{
			return _wbUse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			object obj = (object)new WebBrowserDocumentCompletedEventHandler(o1M);
			object obj2 = _wbUse;
			if ((int)(WebBrowser)obj2 != 0)
			{
				((WebBrowser)((obj2 is WebBrowser) ? obj2 : null)).remove_DocumentCompleted((WebBrowserDocumentCompletedEventHandler)obj);
			}
			_wbUse = value;
			obj2 = _wbUse;
			if ((int)(WebBrowser)obj2 != 0)
			{
				((WebBrowser)obj2).add_DocumentCompleted((WebBrowserDocumentCompletedEventHandler)obj);
			}
		}
	}

	public Mt2()
	{
		x5D();
	}

	private void x5D()
	{
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Location", new object[1]
		{
			new Point(1225, 3)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Name", new object[1] { "btnClose" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Size", new object[1]
		{
			new Size(82, 31)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "TabIndex", new object[1] { 14 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnClose, (Type)null, "Text", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton1, (Type)null, "Location", new object[1]
		{
			new Point(54, 11)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton1, (Type)null, "Name", new object[1] { "SimpleButton1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton1, (Type)null, "Size", new object[1]
		{
			new Size(48, 23)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton1, (Type)null, "TabIndex", new object[1] { 12 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton1, (Type)null, "Text", new object[1] { "Forward" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnBack, (Type)null, "Location", new object[1]
		{
			new Point(2, 11)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnBack, (Type)null, "Name", new object[1] { "btnBack" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnBack, (Type)null, "Size", new object[1]
		{
			new Size(46, 23)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnBack, (Type)null, "TabIndex", new object[1] { 13 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnBack, (Type)null, "Text", new object[1] { "Back" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnStop, (Type)null, "Location", new object[1]
		{
			new Point(160, 10)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnStop, (Type)null, "Name", new object[1] { "btnStop" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnStop, (Type)null, "Size", new object[1]
		{
			new Size(35, 23)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnStop, (Type)null, "TabIndex", new object[1] { 9 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnStop, (Type)null, "Text", new object[1] { "Stop" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGo, (Type)null, "Location", new object[1]
		{
			new Point(520, 11)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGo, (Type)null, "Name", new object[1] { "btnGo" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGo, (Type)null, "Size", new object[1]
		{
			new Size(24, 23)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGo, (Type)null, "TabIndex", new object[1] { 10 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnGo, (Type)null, "Text", new object[1] { "Go" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Location", new object[1]
		{
			new Point(108, 11)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Name", new object[1] { "btnRefresh" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Size", new object[1]
		{
			new Size(46, 23)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "TabIndex", new object[1] { 11 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(btnRefresh, (Type)null, "Text", new object[1] { "Refresh" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtUrl, (Type)null, "Location", new object[1]
		{
			new Point(201, 13)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtUrl, (Type)null, "Name", new object[1] { "txtUrl" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtUrl, (Type)null, "Size", new object[1]
		{
			new Size(313, 20)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(txtUrl, (Type)null, "TabIndex", new object[1] { 8 }, (string[])null, (Type[])null, false, true);
		((Control)wbUse).set_Anchor((AnchorStyles)14);
		((Control)wbUse).set_Location(new Point(2, 45));
		((Control)wbUse).set_MinimumSize(new Size(20, 20));
		((Control)wbUse).set_Name("wbUse");
		((Control)wbUse).set_Size(new Size(1305, 597));
		((Control)wbUse).set_TabIndex(7);
	}

	private void Ew9(object sender, EventArgs e)
	{
		wbUse.Stop();
	}

	private void Ft5(object sender, EventArgs e)
	{
		WebBrowser obj = wbUse;
		object obj2;
		object[] obj3 = new object[1] { NewLateBinding.LateGet(obj2 = txtUrl, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null) };
		object obj4 = obj3;
		bool[] obj5 = new bool[1] { true };
		Array array = obj5;
		NewLateBinding.LateCall((object)obj, (Type)null, "Navigate", obj3, (string[])null, (Type[])null, obj5, true);
		if ((array as bool[])[0])
		{
			NewLateBinding.LateSetComplex(obj2, (Type)null, "Text", new object[1] { ((object[])obj4)[0] }, (string[])null, (Type[])null, true, true);
		}
	}

	public void w8B(string d9A)
	{
		wbUse.Navigate(d9A);
	}

	private void i9T(object sender, EventArgs e)
	{
		wbUse.Refresh();
	}

	internal static void p0B()
	{
		throw new NotImplementedException();
	}

	private void i7Y(object sender, EventArgs e)
	{
	}

	private void Cb8(object sender, EventArgs e)
	{
	}

	private void o1M(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		NewLateBinding.LateSetComplex(txtUrl, (Type)null, "Text", new object[1] { e.get_Url().ToString() }, (string[])null, (Type[])null, false, true);
	}

	private void k8Z(object sender, EventArgs e)
	{
		wbUse.GoBack();
	}

	private void z1C(object sender, EventArgs e)
	{
		wbUse.GoForward();
	}

	static void Qq2()
	{
		//IL_0111: Expected O, but got I4
		//IL_028a: Expected O, but got I4
		//IL_0296: Expected O, but got I4
		//IL_02cc: Expected O, but got I4
		//IL_0375: Expected O, but got I4
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected O, but got I4
		//IL_08ec: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7K2Ek s7K2Ek);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mr7n6D mr7n6D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy0 sy);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xn05Ce xn05Ce);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f3L6Rd f3L6Rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ez0 ez);
		try
		{
			try
			{
				do
				{
					Ez0 obj = (Ez0)((Xn05Ce)null).ObjectDetectorScalingMode;
					ez = null;
					ez = obj;
					s7K2Ek = null;
					obj2 = ((Mr7n6D)s7K2Ek.ObjectDetectorScalingMode).ObjectDetectorScalingMode;
				}
				while (obj2 != null);
			}
			catch
			{
				mr7n6D = (Mr7n6D)((Sy0)((Mr7n6D)null).ObjectDetectorScalingMode).SuppliedRecord;
				mr7n6D = mr7n6D;
				sy = null;
				mr7n6D = (Mr7n6D)((a8C)sy.UserInfo).PayTMPay;
				xn05Ce = (Xn05Ce)(object)Yg89Py.Default;
				_ = (Xn05Ce)((s7K2Ek)xn05Ce.ObjectDetectorScalingMode).ObjectDetectorSearchMode;
				f3L6Rd = f3L6Rd;
				_ = (Wt9q7H)f3L6Rd.PrintDailyRecords;
			}
		}
		catch
		{
			_ = (Sy50Xx)((Sy0)null).SupplierInfo;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mt2 mt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag9 ag);
		try
		{
			while (obj2 != null)
			{
				mt = mt;
				mt = null;
			}
		}
		finally
		{
			try
			{
				ag = ag;
				_ = (Rf7)ag.UserInfo;
			}
			catch
			{
				_ = ((y0D)null).Width is Wt9q7H;
			}
			goto IL_011a;
		}
		IL_0778:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i1D i1D);
		f1P6Lz f1P6Lz;
		try
		{
			i1D = i1D;
		}
		finally
		{
			_ = (Ty5k0C)f1P6Lz.SuppliedRecord;
			goto IL_083c;
		}
		IL_011a:
		f1P6Lz = null;
		_ = (_003CModule_003E)f1P6Lz.SuppliedRecord;
		try
		{
			_ = (Rf7)f3L6Rd.PrintDailyRecords;
		}
		catch
		{
			while (true)
			{
				i1D = i1D;
				if (i1D.PrintMonthlyRecords != null)
				{
					_ = (Rf7)((s7K2Ek)null).ObjectDetectorScalingMode;
					_ = (s7K2Ek)((Mr7n6D)null).SelectImageGetFrom;
				}
				else if (obj2 == null)
				{
					break;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		try
		{
			ez = null;
		}
		catch
		{
			z3T obj7 = (z3T)f3L6Rd.PrintDailyRecords;
			z3T z3T = z3T;
			z3T = obj7;
		}
		finally
		{
			try
			{
				_ = (Rf7)mr7n6D.UserInfo;
			}
			finally
			{
				y0D = y0D;
				y0D = y0D;
				goto IL_01c8;
			}
		}
		IL_0471:
		try
		{
			if ((UIntPtr)((Sy0)null).UserInfo == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Wt9q7H)((f1P6Lz)((Mr7n6D)((Sy0)null).SupplierDailyRecord).ObjectDetectorScalingMode).Send_sms_to_customer;
				}
				while (obj2 != null);
			}
		}
		catch
		{
			y0D = y0D;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a8C a8C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			try
			{
				num = default(UIntPtr);
				if (checked(num - num) == 0)
				{
					mr7n6D = mr7n6D;
				}
				else
				{
					_ = (x6LFp1)a8C.PayTMPay;
				}
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
				goto end_IL_04b3;
			}
			end_IL_04b3:;
		}
		catch
		{
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (y0D)((Sy0)null).SupplierInfo;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e2.y6 y);
		while (((Mr7n6D)null).UserInfo != null)
		{
			try
			{
				if ((UIntPtr)((Xn05Ce)f1P6Lz.SuppliedRecord).ObjectDetectorSearchMode == (UIntPtr)(nuint)0u)
				{
					_ = (e2.y6)((s7K2Ek)((i1D)f3L6Rd.PrintDailyRecords).PrintMonthlyRecords).ObjectDetectorSearchMode;
					y0D = null;
					mt = mt;
				}
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					y = y;
					y = default(e2.y6);
				}
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yg89Py yg89Py);
		do
		{
			_ = (m8K)(object)yg89Py.Fast_food_managementConnectionString;
			_ = (Mt2)xn05Ce.UserInfo;
			mr7n6D = mr7n6D;
			_ = (Ty5k0C)((i1D)null).PrintMonthlyRecords;
		}
		while (obj2 != null || obj2 != null);
		try
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				do
				{
					_ = ((y0D)null).Width is Wt9q7H;
					_ = (e2.y6)((Xn05Ce)f3L6Rd.PrintDailyRecords).UserInfo;
				}
				while (obj2 != null);
				goto end_IL_05f8;
			}
			end_IL_05f8:;
		}
		finally
		{
			_ = (Ty5k0C)sy.SuppliedRecord;
			goto IL_06b8;
		}
		IL_01c8:
		y0D = y0D;
		while (obj2 != null)
		{
			num = (UIntPtr)f1P6Lz.SuppliedRecord;
			num = default(UIntPtr);
			nuint num2 = num;
			yg89Py = yg89Py;
			checked
			{
				if (num2 + unchecked((nuint)(UIntPtr)yg89Py.Fast_food_managementConnectionString) + num == 0)
				{
					_ = (s4C8Py)(object)yg89Py.Fast_food_managementConnectionString;
					_ = (s4C8Py)((f1P6Lz)((s7K2Ek)((s7K2Ek)((Sy0)null).UserInfo).ObjectDetectorScalingMode).ObjectDetectorSearchMode).Send_sms_to_customer;
					_ = (Se60Di)((s7K2Ek)null).ObjectDetectorSearchMode;
					_ = (Se60Di)ag.UserInfo;
					a8C = a8C;
					a8C = a8C;
				}
			}
		}
		_ = y0D.Width is i1D;
		Hf08Tc hf08Tc = (Hf08Tc)(((y0D)null).Width as a8C).PayTMPay;
		hf08Tc = hf08Tc;
		try
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Bs bs);
				do
				{
					bs = bs;
					bs = bs;
				}
				while (y0D.Width is object);
			}
			finally
			{
				while (((Xn05Ce)null).ObjectDetectorSearchMode != null)
				{
					_ = (Sy0)((Mr7n6D)xn05Ce.ObjectDetectorSearchMode).SelectImageGetFrom;
				}
				goto end_IL_02b0;
			}
			end_IL_02b0:;
		}
		catch
		{
			_ = (x6LFp1)((f1P6Lz)((Xn05Ce)((s7K2Ek)((Mr7n6D)null).ObjectDetectorScalingMode).ObjectDetectorScalingMode).UserInfo).Send_sms_to_customer;
			_ = (z3T)mr7n6D.UserInfo;
		}
		try
		{
			UIntPtr intPtr = (UIntPtr)((a8C)null).PayTMPay;
			nuint intPtr2 = num;
			num = default(UIntPtr);
			nuint num3 = num;
			nuint num4;
			object obj12;
			checked
			{
				num4 = num - unchecked((nuint)default(UIntPtr));
				obj12 = ((y0D)null).Width;
			}
			_003F val = num3 / (num4 / ((obj12 is UIntPtr) ? obj12 : null));
			num = default(UIntPtr);
			if ((int)checked(unchecked((nuint)intPtr) + (unchecked(intPtr2 / checked(val * (unchecked((nuint)default(UIntPtr)) * ((num - num) * num + unchecked((nuint)default(UIntPtr)))))) - unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)))) * unchecked((nuint)default(UIntPtr))) == 0)
			{
				s7K2Ek = null;
			}
		}
		finally
		{
			try
			{
				s9.y6 y2 = y2;
				y2 = y2;
			}
			catch
			{
				_ = (Mt2)((Ag9)null).UserInfo;
			}
			finally
			{
				num = default(UIntPtr);
				if (num / num == 0)
				{
					mr7n6D = null;
				}
				else
				{
					i1D = null;
					f1P6Lz = f1P6Lz;
					_ = (a8C)((Mr7n6D)((i1D)mr7n6D.ObjectDetectorSearchMode).PrintMonthlyRecords).ObjectDetectorSearchMode;
					_ = (Sy50Xx)ag.UserInfo;
				}
				goto IL_0471;
			}
		}
		IL_083c:
		checked
		{
			while (obj2 != null)
			{
				if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					if (unchecked((UIntPtr)s7K2Ek.ObjectDetectorScalingMode == (UIntPtr)(nuint)0u))
					{
						b4 b = (b4)a8C.PayTMPay;
					}
					else
					{
						_ = (Xn05Ce)(object)yg89Py.DBForFoodManagementConnectionString;
					}
				}
				else if (unchecked((nuint)(UIntPtr)((Sy0)((s7K2Ek)null).ObjectDetectorScalingMode).SupplierDailyRecord / unchecked((nuint)default(UIntPtr))) - unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (i7Z8Et)(object)((Yg89Py)f1P6Lz.SupplierDailyRecord).DBForFoodManagementConnectionString;
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)ag.UserInfo == (UIntPtr)(nuint)0u)
			{
				do
				{
					f1P6Lz = f1P6Lz;
				}
				while ((object)((Yg89Py)null).Fast_food_managementConnectionString != null);
			}
		}
		else
		{
			try
			{
				while (obj2 != null)
				{
				}
			}
			catch
			{
				if ((UIntPtr)Yg89Py.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Ag9)i1D.PrintMonthlyRecords;
					_ = (s7K2Ek)((f3L6Rd)((Sy0)null).SuppliedRecord).PrintDailyRecords;
				}
			}
		}
		_ = (s7K2Ek)a8C.PayTMPay;
		f1P6Lz = f1P6Lz;
		while (obj2 != null)
		{
			do
			{
				_ = (Xn05Ce)sy.SupplierInfo;
			}
			while ((y0D.Width as f3L6Rd).PrintDailyRecords != null);
		}
		return;
		IL_06b8:
		checked
		{
			while (obj2 != null)
			{
				num = default(UIntPtr);
				if (num * unchecked((nuint)(UIntPtr)((Ag9)(object)((Yg89Py)null).Fast_food_managementConnectionString).UserInfo / (nuint)(UIntPtr)((Xn05Ce)null).ObjectDetectorSearchMode / num) == 0 && unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr))) + unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (f1P6Lz)((s7K2Ek)null).ObjectDetectorScalingMode;
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Ag9)sy.SupplierDailyRecord;
				}
				else
				{
					_ = (Ag9)xn05Ce.ObjectDetectorScalingMode;
				}
			}
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b4 b);
			while ((object)((Yg89Py)f1P6Lz.SupplierDailyRecord).Fast_food_managementConnectionString != null)
			{
				_ = (Bs)(object)Yg89Py.Default;
				_ = (e2.y6)f1P6Lz.SupplierDailyRecord;
				b = b;
			}
		}
		finally
		{
			Rf7 obj16 = (Rf7)sy.UserInfo;
			Rf7 rf = rf;
			rf = obj16;
			ez = ez;
			_ = (x6LFp1)a8C.PayTMPay;
			goto IL_0778;
		}
	}
}
