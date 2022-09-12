using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
using d0P;
using e2;
using g8GLd9;
using j1H5Ld;
using m2Q;
using n2Z;
using o1KZx9;
using p6MRy9;
using s9;
using t5C8Kg;
using w0XGc7;
using x6T;

namespace t7S;

[DesignerGenerated]
public class m8K
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Yg2
	{
		internal object object_0;

		internal object object_1;

		internal Label label_0;

		internal object object_2;

		internal object object_3;

		internal Label label_1;

		internal Timer timer_0;

		internal Panel panel_0;

		internal Label label_2;

		internal Label label_3;

		internal object object_4;

		internal string string_0;

		internal PictureBox pictureBox_0;

		internal object object_5;

		internal object object_6;
	}

	internal sealed class j5W
	{
		internal object object_0;

		internal object object_1;

		internal Label label_0;

		internal j5W()
		{
		}
	}

	private IContainer components;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	[AccessedThroughProperty("SimpleButton3")]
	private object _SimpleButton3;

	private bool isfileselected;

	private s4C8Py.o0T4Ri o0T4Ri_0 = new s4C8Py.o0T4Ri();

	internal virtual OpenFileDialog OpenFileDialog1
	{
		get
		{
			return _OpenFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_OpenFileDialog1 = value;
		}
	}

	internal virtual object TextEdit1
	{
		get
		{
			return o0T4Ri_0.object_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			o0T4Ri_0.object_0 = objectValue;
		}
	}

	internal virtual object SimpleButton1
	{
		get
		{
			return o0T4Ri_0.object_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			o0T4Ri_0.object_1 = objectValue;
		}
	}

	internal virtual object SimpleButton2
	{
		get
		{
			return o0T4Ri_0.object_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			object objectValue = RuntimeHelpers.GetObjectValue(value);
			o0T4Ri_0.object_2 = objectValue;
		}
	}

	internal virtual object SimpleButton3
	{
		get
		{
			return _SimpleButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SimpleButton3 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public m8K()
	{
		isfileselected = false;
		Gk5();
	}

	private void Gk5()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		OpenFileDialog1 = new OpenFileDialog();
		((ISupportInitialize)NewLateBinding.LateGet(TextEdit1, (Type)null, "Properties", new object[0], (string[])null, (Type[])null, (bool[])null)).BeginInit();
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		NewLateBinding.LateSetComplex(TextEdit1, (Type)null, "Enabled", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TextEdit1, (Type)null, "Location", new object[1]
		{
			new Point(13, 13)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TextEdit1, (Type)null, "Name", new object[1] { "TextEdit1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TextEdit1, (Type)null, "Size", new object[1]
		{
			new Size(463, 20)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TextEdit1, (Type)null, "TabIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(TextEdit1, (Type)null, "TabStop", new object[1] { false }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton1, (Type)null, "Location", new object[1]
		{
			new Point(482, 11)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton1, (Type)null, "Name", new object[1] { "SimpleButton1" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton1, (Type)null, "Size", new object[1]
		{
			new Size(75, 23)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton1, (Type)null, "TabIndex", new object[1] { 1 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton1, (Type)null, "Text", new object[1] { "Browse" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton2, (Type)null, "Location", new object[1]
		{
			new Point(563, 11)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton2, (Type)null, "Name", new object[1] { "SimpleButton2" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton2, (Type)null, "Size", new object[1]
		{
			new Size(37, 23)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton2, (Type)null, "TabIndex", new object[1] { 2 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton2, (Type)null, "Text", new object[1] { "Ok" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton3, (Type)null, "Location", new object[1]
		{
			new Point(606, 11)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton3, (Type)null, "Name", new object[1] { "SimpleButton3" }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton3, (Type)null, "Size", new object[1]
		{
			new Size(44, 23)
		}, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton3, (Type)null, "TabIndex", new object[1] { 3 }, (string[])null, (Type[])null, false, true);
		NewLateBinding.LateSetComplex(SimpleButton3, (Type)null, "Text", new object[1] { "Close" }, (string[])null, (Type[])null, false, true);
	}

	private void Es3(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)OpenFileDialog1).ShowDialog() == 1)
		{
			NewLateBinding.LateSetComplex(TextEdit1, (Type)null, "Text", new object[1] { ((FileDialog)OpenFileDialog1).get_FileName() }, (string[])null, (Type[])null, false, true);
			isfileselected = true;
		}
	}

	private void z8W(object sender, EventArgs e)
	{
		if (isfileselected)
		{
			FileSystemInfo fileSystemInfo = new FileInfo(((FileDialog)OpenFileDialog1).get_FileName());
			(fileSystemInfo as FileInfo).CopyTo(Application.get_StartupPath() + "\\paytm", overwrite: true);
			Yo2();
		}
	}

	private void Yo2()
	{
		throw new NotImplementedException();
	}

	private void Fj7(object sender, EventArgs e)
	{
		Yo2();
	}

	static void Bn9()
	{
		//IL_01f7: Expected O, but got I4
		//IL_0344: Expected O, but got I4
		//IL_040a: Expected O, but got I4
		//IL_050c: Expected O, but got I4
		//IL_061b: Expected O, but got I4
		//IL_0698: Expected O, but got I4
		//IL_0705: Expected O, but got I4
		//IL_0770: Expected O, but got I4
		//IL_0835: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f3L6Rd f3L6Rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out s7K2Ek s7K2Ek);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xn05Ce xn05Ce);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mr7n6D mr7n6D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e2.y6 y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yg89Py yg89Py);
		try
		{
			try
			{
				yg89Py = yg89Py;
				yg89Py = yg89Py;
			}
			catch
			{
				try
				{
					_ = (Yg89Py)(object)((Yg89Py)(object)((Yg89Py)null).Fast_food_managementConnectionString).Fast_food_managementConnectionString;
				}
				catch
				{
					f3L6Rd = f3L6Rd;
					f3L6Rd = f3L6Rd;
					y = y;
					y = y;
					s7K2Ek = (s7K2Ek)f3L6Rd.PrintDailyRecords;
					s7K2Ek = null;
					xn05Ce = xn05Ce;
					_ = (Sy0)xn05Ce.ObjectDetectorScalingMode;
				}
			}
		}
		catch
		{
			mr7n6D = mr7n6D;
			mr7n6D = mr7n6D;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag9 ag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sy0 sy);
		try
		{
			try
			{
				sy = null;
				_ = (i7Z8Et)sy.UserInfo;
				_ = (i7Z8Et)((Mr7n6D)((Mr7n6D)((Sy0)null).SupplierInfo).ObjectDetectorScalingMode).UserInfo;
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				uIntPtr = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (s7K2Ek)xn05Ce.ObjectDetectorScalingMode;
					_ = (Xn05Ce)mr7n6D.ObjectDetectorSearchMode;
				}
			}
		}
		catch
		{
			ag = (Ag9)((s7K2Ek)((Xn05Ce)null).ObjectDetectorScalingMode).ObjectDetectorSearchMode;
			_ = (Sy0)ag.UserInfo;
		}
		while (((Ag9)null).UserInfo != null)
		{
			_ = (Ty5k0C)s7K2Ek.ObjectDetectorScalingMode;
		}
		Rf7 rf = null;
		rf = rf;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i1D i1D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a8C a8C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj7);
		if ((UIntPtr)((i1D)((f1P6Lz)null).SuppliedRecord).PrintMonthlyRecords == (UIntPtr)(nuint)0u)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (Mm0)(object)yg89Py.DBForFoodManagementConnectionString;
					_ = (Mm0)(object)Yg89Py.Default;
				}
				else
				{
					i1D obj6 = (i1D)((Sy0)null).SupplierDailyRecord;
					i1D = i1D;
					i1D = obj6;
					a8C = (a8C)xn05Ce.ObjectDetectorSearchMode;
					_ = (Mt2)a8C.PayTMPay;
					_ = ((y0D)mr7n6D.SelectImageGetFrom).Width is f3L6Rd;
				}
			}
			catch
			{
				while (true)
				{
					obj7 = obj7;
					if (obj7 != null)
					{
						_ = (i7Z8Et)((s7K2Ek)sy.SupplierInfo).ObjectDetectorScalingMode;
						continue;
					}
					break;
				}
			}
		}
		else
		{
			_ = (s4C8Py)mr7n6D.SelectImageGetFrom;
		}
		_ = (Hf08Tc)f3L6Rd.PrintDailyRecords;
		if ((UIntPtr)((a8C)sy.UserInfo).PayTMPay == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Hf08Tc)mr7n6D.SelectImageGetFrom;
				}
				finally
				{
					_ = (Hf08Tc)xn05Ce.ObjectDetectorScalingMode;
					goto IL_0302;
				}
			}
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				xn05Ce = (Xn05Ce)((Sy0)null).SuppliedRecord;
			}
			else
			{
				_ = (f1P6Lz)((i1D)null).PrintMonthlyRecords;
				y = y;
				_ = (z3T)s7K2Ek.ObjectDetectorSearchMode;
				Mt2 mt = mt;
				mt = null;
			}
		}
		else if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (Se60Di)((s7K2Ek)ag.UserInfo).ObjectDetectorScalingMode;
			}
			while (obj7 != null);
		}
		goto IL_0302;
		IL_035e:
		do
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (s9.y6)(object)yg89Py.DBForFoodManagementConnectionString;
				}
			}
			catch
			{
				try
				{
					_ = (b4)yg89Py.Fast_food_managementConnectionString;
				}
				finally
				{
					Mt2 mt = null;
					goto end_IL_037f;
				}
				end_IL_037f:;
			}
		}
		while (obj7 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f1P6Lz f1P6Lz);
		_ = (x6LFp1)f1P6Lz.SuppliedRecord;
		sy = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Se60Di se60Di);
		while (true)
		{
			if (obj7 != null)
			{
				Se60Di obj10 = (Se60Di)f3L6Rd.PrintDailyRecords;
				se60Di = se60Di;
				se60Di = obj10;
				rf = rf;
			}
			else if (obj7 == null)
			{
				break;
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y0D y0D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x6LFp1 x6LFp);
		if (uIntPtr == 0)
		{
			y0D = null;
			if ((UIntPtr)(y0D.Width as a8C).PayTMPay == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					mr7n6D = (Mr7n6D)s7K2Ek.ObjectDetectorSearchMode;
				}
			}
			else
			{
				do
				{
					x6LFp = null;
					x6LFp = null;
				}
				while (obj7 != null);
			}
		}
		else
		{
			do
			{
				rf = rf;
			}
			while (((i1D)((f3L6Rd)null).PrintDailyRecords).PrintMonthlyRecords != null);
		}
		if ((UIntPtr)((s7K2Ek)null).ObjectDetectorSearchMode == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Wt9q7H)((f3L6Rd)((f3L6Rd)null).PrintDailyRecords).PrintDailyRecords;
				}
				catch
				{
					se60Di = se60Di;
					_ = (_003CModule_003E)(object)Yg89Py.Default;
				}
			}
			else
			{
				b4 b = b;
				b = default(b4);
				Wt9q7H obj12 = (Wt9q7H)ag.UserInfo;
				Wt9q7H wt9q7H = wt9q7H;
				wt9q7H = obj12;
			}
		}
		else
		{
			try
			{
				do
				{
					_ = ((y0D)((Xn05Ce)null).ObjectDetectorScalingMode).Width is s4C8Py;
				}
				while (s7K2Ek.ObjectDetectorScalingMode != null);
			}
			catch
			{
				try
				{
					_ = (x6LFp1)((a8C)xn05Ce.ObjectDetectorScalingMode).PayTMPay;
					_ = (Bs)((s7K2Ek)((f1P6Lz)((Ag9)(object)((Yg89Py)xn05Ce.UserInfo).Fast_food_managementConnectionString).UserInfo).Send_sms_to_customer).ObjectDetectorSearchMode;
				}
				finally
				{
					x6LFp = (x6LFp1)xn05Ce.UserInfo;
					Hf08Tc obj13 = (Hf08Tc)((Sy0)i1D.PrintMonthlyRecords).SuppliedRecord;
					Hf08Tc hf08Tc = hf08Tc;
					hf08Tc = obj13;
					goto end_IL_0526;
				}
				end_IL_0526:;
			}
		}
		if ((UIntPtr)i1D.PrintMonthlyRecords == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (Ty5k0C)((f1P6Lz)null).Send_sms_to_customer;
				}
				finally
				{
					x6LFp = x6LFp;
					goto end_IL_05c3;
				}
				end_IL_05c3:;
			}
			catch
			{
				try
				{
					b4 b = default(b4);
				}
				finally
				{
					_ = (_003CModule_003E)((Sy0)sy.UserInfo).SupplierDailyRecord;
					sy = sy;
					_ = ((y0D)null).Width is Mm0;
					goto end_IL_05de;
				}
				end_IL_05de:;
			}
		}
		nuint num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m8K m8K2);
		checked
		{
			try
			{
			}
			catch
			{
				if (uIntPtr - unchecked((nuint)(UIntPtr)a8C.PayTMPay) != 0)
				{
					try
					{
						m8K obj16 = (m8K)(object)yg89Py.Fast_food_managementConnectionString;
						m8K2 = m8K2;
						m8K2 = obj16;
					}
					finally
					{
						ag = ag;
						goto end_IL_0627;
					}
				}
				sy = sy;
				end_IL_0627:;
			}
			num = uIntPtr;
		}
		UIntPtr num2 = (UIntPtr)((i1D)null).PrintMonthlyRecords;
		uIntPtr = default(UIntPtr);
		if (num / ((nuint)num2 / uIntPtr) == 0)
		{
			_ = ((y0D)null).Width is i1D;
		}
		while (((Xn05Ce)(object)Yg89Py.Default).UserInfo != null)
		{
			_ = (Wt9q7H)f1P6Lz.SuppliedRecord;
		}
		if (uIntPtr == 0)
		{
			Bs bs = bs;
			bs = bs;
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_ = (i1D)s7K2Ek.ObjectDetectorScalingMode;
					_ = y0D.Width is Sy0;
					x6LFp = null;
				}
				catch
				{
					Sy50Xx sy50Xx = sy50Xx;
					sy50Xx = sy50Xx;
					sy50Xx = sy50Xx;
					_ = (s4C8Py)i1D.PrintMonthlyRecords;
					_ = (s4C8Py)((Mr7n6D)((Mr7n6D)null).SelectImageGetFrom).ObjectDetectorSearchMode;
					Hf08Tc hf08Tc = null;
				}
			}
		}
		try
		{
			_ = (s4C8Py)ag.UserInfo;
		}
		catch
		{
			if (!(((y0D)null).Width is UIntPtr))
			{
				_ = (Bs)((f3L6Rd)null).PrintDailyRecords;
			}
		}
		checked
		{
			try
			{
				if (uIntPtr == 0)
				{
					while (obj7 != null)
					{
						_ = (Yg89Py)i1D.PrintMonthlyRecords;
					}
				}
				else if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (f1P6Lz)((Mr7n6D)null).ObjectDetectorScalingMode;
				}
			}
			catch
			{
				_ = (_003CModule_003E)((f3L6Rd)((i1D)null).PrintMonthlyRecords).PrintDailyRecords;
			}
		}
		try
		{
			_ = (Ez0)s7K2Ek.ObjectDetectorSearchMode;
		}
		catch
		{
			if ((UIntPtr)((Yg89Py)null).Fast_food_managementConnectionString == (UIntPtr)(nuint)0u)
			{
				_ = (Rf7)((i1D)null).PrintMonthlyRecords;
			}
		}
		finally
		{
			do
			{
				_ = (Wt9q7H)f1P6Lz.Send_sms_to_customer;
			}
			while (y0D.Width is object);
			goto IL_083d;
		}
		IL_083d:
		try
		{
			_ = (i7Z8Et)i1D.PrintMonthlyRecords;
		}
		finally
		{
			se60Di = se60Di;
			goto IL_08a2;
		}
		IL_0302:
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				if (obj7 != null)
				{
					xn05Ce = xn05Ce;
					continue;
				}
				f1P6Lz = null;
				if (f1P6Lz.SupplierDailyRecord == null)
				{
					break;
				}
			}
			goto IL_035e;
		}
		try
		{
			a8C = a8C;
		}
		finally
		{
			try
			{
				_ = ((y0D)null).Width is _003CModule_003E;
			}
			finally
			{
				_ = (Xn05Ce)(object)yg89Py.Fast_food_managementConnectionString;
				goto IL_035e;
			}
		}
		IL_08a2:
		while (obj7 != null)
		{
			try
			{
				while (obj7 != null)
				{
					_ = (x6LFp1)s7K2Ek.ObjectDetectorScalingMode;
					_ = (x6LFp1)sy.SupplierInfo;
				}
			}
			catch
			{
				try
				{
					_ = (Ag9)((a8C)null).PayTMPay;
				}
				finally
				{
					_ = (f3L6Rd)((i1D)null).PrintMonthlyRecords;
					goto end_IL_0883;
				}
				end_IL_0883:;
			}
		}
		try
		{
			sy = null;
		}
		catch
		{
			y = (e2.y6)ag.UserInfo;
		}
		while (((Xn05Ce)null).ObjectDetectorScalingMode != null)
		{
			while (obj7 != null)
			{
			}
		}
		if ((UIntPtr)((a8C)null).PayTMPay == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				sy = null;
			}
			finally
			{
				yg89Py = null;
				goto IL_0904;
			}
		}
		goto IL_0904;
		IL_0904:
		m8K2 = m8K2;
		if ((UIntPtr)((a8C)((Sy0)null).UserInfo).PayTMPay == (UIntPtr)(nuint)0u)
		{
			_ = (b4)a8C.PayTMPay;
			return;
		}
		_ = (s4C8Py)((Mr7n6D)((f1P6Lz)((Xn05Ce)null).ObjectDetectorSearchMode).Send_sms_to_customer).ObjectDetectorScalingMode;
		m8K2 = m8K2;
	}
}
