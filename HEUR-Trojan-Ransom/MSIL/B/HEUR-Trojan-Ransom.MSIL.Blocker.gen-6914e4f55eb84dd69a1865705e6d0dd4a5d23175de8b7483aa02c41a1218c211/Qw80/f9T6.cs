using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bx3;
using Dn7;
using Dy1a;
using Gb1;
using Hc8;
using Hf9e;
using Hj8;
using Lj1k;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Ss0;
using Tb3;
using c5E;
using c6R;
using g5S;
using i3L;
using o8Z;
using p0H;
using q3F;
using q8X;
using z2Z;

namespace Qw80;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class f9T6
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class j6Y4
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Eb1 m_frmBilling;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public m0N m_frmBillingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Np8 m_frmMain;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pj8 m_frmProcessingCost;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Mb5 m_frmProcessingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d1X m_frmProductDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public x8D9 m_frmPurchaseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w4R m_frmSalesDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pm9 m_frmSupplierDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f0F m_frmTransportDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d4E m_frmWarehouseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Co4 m_Login;

		public Eb1 frmBilling
		{
			[DebuggerHidden]
			get
			{
				m_frmBilling = Hs1(m_frmBilling);
				return m_frmBilling;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmBilling)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Ba4(ref m_frmBilling);
				}
			}
		}

		public m0N frmBillingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmBillingDetail = Hs1(m_frmBillingDetail);
				return m_frmBillingDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmBillingDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Ba4(ref m_frmBillingDetail);
				}
			}
		}

		public Np8 frmMain
		{
			[DebuggerHidden]
			get
			{
				m_frmMain = Hs1(m_frmMain);
				return m_frmMain;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmMain)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Ba4(ref m_frmMain);
				}
			}
		}

		public Pj8 frmProcessingCost
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingCost = Hs1(m_frmProcessingCost);
				return m_frmProcessingCost;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmProcessingCost)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Ba4(ref m_frmProcessingCost);
				}
			}
		}

		public Mb5 frmProcessingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingDetail = Hs1(m_frmProcessingDetail);
				return m_frmProcessingDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmProcessingDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Ba4(ref m_frmProcessingDetail);
				}
			}
		}

		public d1X frmProductDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProductDetail = Hs1(m_frmProductDetail);
				return m_frmProductDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmProductDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Ba4(ref m_frmProductDetail);
				}
			}
		}

		public x8D9 frmPurchaseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmPurchaseDetail = Hs1(m_frmPurchaseDetail);
				return m_frmPurchaseDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmPurchaseDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Ba4(ref m_frmPurchaseDetail);
				}
			}
		}

		public w4R frmSalesDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSalesDetail = Hs1(m_frmSalesDetail);
				return m_frmSalesDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmSalesDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Ba4(ref m_frmSalesDetail);
				}
			}
		}

		public Pm9 frmSupplierDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSupplierDetail = Hs1(m_frmSupplierDetail);
				return m_frmSupplierDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmSupplierDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Ba4(ref m_frmSupplierDetail);
				}
			}
		}

		public f0F frmTransportDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmTransportDetail = Hs1(m_frmTransportDetail);
				return m_frmTransportDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmTransportDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Ba4(ref m_frmTransportDetail);
				}
			}
		}

		public d4E frmWarehouseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmWarehouseDetail = Hs1(m_frmWarehouseDetail);
				return m_frmWarehouseDetail;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmWarehouseDetail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Ba4(ref m_frmWarehouseDetail);
				}
			}
		}

		public Co4 Login
		{
			[DebuggerHidden]
			get
			{
				m_Login = Hs1(m_Login);
				return m_Login;
			}
			[DebuggerHidden]
			set
			{
				char[] char_ = Mb5.char_0;
				int num = 5;
				while (true)
				{
					if (value == m_Login)
					{
						switch (char_[29] - char_[29])
						{
						case 0:
							num = 4;
							return;
						case 6:
							goto IL_0051;
						case 1:
						case 8:
							goto IL_0059;
						case 2:
							goto end_IL_003e;
						case 3:
						case 4:
						case 7:
							return;
						}
						continue;
					}
					num = 6;
					goto IL_0051;
					IL_0051:
					if (value != null)
					{
						num = 8;
						goto IL_0059;
					}
					num = 2;
					break;
					IL_0059:
					throw new ArgumentException("Property can only be set to Nothing");
					continue;
					end_IL_003e:
					break;
				}
				Ba4(ref m_Login);
			}
		}

		[DebuggerHidden]
		private static Xz4 Hs1<Xz4>(Xz4 n9Q) where Xz4 : Form, new()
		{
			if (n9Q == null || ((Control)n9Q).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Xz4)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Xz4), null);
				try
				{
					return new Xz4();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError((Exception)ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message });
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(Xz4));
				}
			}
			return n9Q;
		}

		[DebuggerHidden]
		private void Ba4<Wm9>(ref Wm9 Po7) where Wm9 : Form
		{
			((Component)Po7).Dispose();
			Po7 = default(Wm9);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public j6Y4()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool z4P(object Cy7)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Cy7));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Jy8()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Qs3()
		{
			return typeof(j6Y4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Hg4()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Lq0
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Ax6(object r7T)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(r7T));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Cn1()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Jn0()
		{
			return typeof(Lq0);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string i5N()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Ft8 c8Y<Ft8>(Ft8 Rz2) where Ft8 : new()
		{
			if (Rz2 == null)
			{
				return new Ft8();
			}
			return Rz2;
		}

		[DebuggerHidden]
		private void f4A<Fw2>(ref Fw2 Qa4)
		{
			Qa4 = default(Fw2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Lq0()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class f8J<Ao6> where Ao6 : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static Ao6 m_ThreadStaticValue;

		internal Ao6 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Ao6();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public f8J()
		{
		}
	}

	private static readonly f8J<o5CZ> m_ComputerObjectProvider = new f8J<o5CZ>();

	private static readonly f8J<k6D9> m_AppObjectProvider = new f8J<k6D9>();

	private static readonly f8J<User> m_UserObjectProvider = new f8J<User>();

	private static f8J<j6Y4> m_MyFormsObjectProvider = new f8J<j6Y4>();

	private static readonly f8J<Lq0> m_MyWebServicesObjectProvider = new f8J<Lq0>();

	[HelpKeyword("My.Computer")]
	internal static o5CZ Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static k6D9 Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static j6Y4 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Lq0 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}

	static void Zq10()
	{
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Np8 np);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nf2 nf);
		while (true)
		{
			obj = Nf2.Default;
			if (obj == null)
			{
				break;
			}
			try
			{
				try
				{
					nf = nf;
					nf = nf;
				}
				finally
				{
					_ = (Mb5)(object)Nf2.Default;
					goto end_IL_0004;
				}
				end_IL_0004:;
			}
			catch
			{
				while ((object)Nf2.Default != null)
				{
					Np8 obj2 = (Np8)(object)Nf2.Default;
					np = (Np8)(object)Nf2.Default;
					np = obj2;
				}
			}
		}
		nuint uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Co4 co);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm9 pm);
		try
		{
			uIntPtr = (UIntPtr)Nf2.Default;
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				w4R w4R = null;
				w4R = w4R;
			}
			else
			{
				_ = (x8D9)(object)Nf2.Default;
			}
		}
		catch
		{
			try
			{
				_ = (Mb5)(object)Nf2.Default;
			}
			catch
			{
				Pm9 obj4 = (Pm9)(object)Nf2.Default;
				pm = pm;
				pm = obj4;
			}
		}
		finally
		{
			while (obj != null)
			{
				co = co;
				co = null;
				_ = (Pm9)(object)Nf2.Default;
			}
			goto IL_00e6;
		}
		IL_0231:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		while (obj != null)
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					d8B = (d8B)(object)Nf2.Default;
				}
				finally
				{
					_ = (d8B)(object)Nf2.Default;
					continue;
				}
			}
		}
		do
		{
			try
			{
				while ((object)Nf2.Default != null)
				{
					_ = (r8M)Nf2.Default;
				}
			}
			finally
			{
				d8B = d8B;
				_ = (d8B)(object)Nf2.Default;
				nf = nf;
				_ = (d4E)(object)Nf2.Default;
				continue;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k6D9 k6D);
		while ((object)Nf2.Default != null)
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Eb1)(object)Nf2.Default;
				}
			}
			else if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				np = np;
			}
			else
			{
				k6D = k6D;
				k6D = k6D;
			}
		}
		_ = (k6D9)(object)Nf2.Default;
		if (uIntPtr / uIntPtr == 0)
		{
			try
			{
				while ((object)Nf2.Default != null)
				{
					k6D = (k6D9)(object)Nf2.Default;
					_ = (m0N)(object)Nf2.Default;
					w4R w4R = (w4R)(object)Nf2.Default;
					Gj4 gj = (Gj4)Nf2.Default;
					gj = gj;
				}
			}
			catch
			{
			}
			goto IL_0396;
		}
		try
		{
		}
		finally
		{
			try
			{
				_ = (Pj8)(object)Nf2.Default;
			}
			catch
			{
				_ = (w4R)(object)Nf2.Default;
			}
			goto IL_0396;
		}
		IL_0747:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Eb1 eb);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				checked
				{
					if (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
					{
						_ = (w4R)(object)Nf2.Default;
					}
				}
			}
			catch
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (f2L)(object)Nf2.Default;
					d8B = d8B;
					_ = (f2L)(object)Nf2.Default;
					f9T6 f9T7 = f9T7;
					f9T7 = f9T7;
				}
				else
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
					co = (Co4)(object)Nf2.Default;
					eb = eb;
					eb = null;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr != 0)
		{
			do
			{
				o5CZ o5CZ = (o5CZ)(object)Nf2.Default;
			}
			while ((object)Nf2.Default != null);
		}
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					_ = (Mb5)(object)Nf2.Default;
				}
				catch
				{
					_ = (f2L)(object)Nf2.Default;
				}
			}
		}
		while ((object)Nf2.Default != null)
		{
			while (obj != null)
			{
				_ = (m0N)(object)Nf2.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mb5 mb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d4E d4E);
		checked
		{
			if (uIntPtr == 0)
			{
				if (uIntPtr + (uIntPtr - unchecked((nuint)(UIntPtr)Nf2.Default)) - unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
				{
					_ = (Eb1)(object)Nf2.Default;
				}
				else if (unchecked((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u))
				{
					mb = null;
				}
			}
			f2L f2L = f2L;
			f2L = f2L;
			while ((object)Nf2.Default != null)
			{
			}
			if (uIntPtr + uIntPtr == 0)
			{
				while (obj != null)
				{
					_ = (Pj8)(object)Nf2.Default;
				}
			}
			try
			{
				if (uIntPtr == 0)
				{
					r8M r8M = r8M;
				}
			}
			catch
			{
				do
				{
					k6D = null;
				}
				while ((object)Nf2.Default != null);
			}
			finally
			{
				d4E = (d4E)(object)Nf2.Default;
				x8D = x8D;
				goto IL_0922;
			}
		}
		IL_00e6:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			try
			{
				_ = (Eb1)(object)Nf2.Default;
			}
			catch
			{
			}
		}
		else if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			co = (((UIntPtr)Nf2.Default != (UIntPtr)(nuint)0u) ? co : co);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					_ = (Pm9)(object)Nf2.Default;
				}
				finally
				{
					np = np;
					goto end_IL_0131;
				}
			}
			try
			{
				_003CModule_003E obj13 = (_003CModule_003E)(object)Nf2.Default;
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = obj13;
			}
			finally
			{
				d8B = (d8B)(object)Nf2.Default;
				d8B = null;
				goto end_IL_0131;
			}
			end_IL_0131:;
		}
		finally
		{
			if (uIntPtr == 0)
			{
				do
				{
					Mb5 obj14 = (Mb5)(object)Nf2.Default;
					mb = mb;
					mb = obj14;
				}
				while (obj != null);
			}
			goto IL_01ac;
		}
		IL_05c2:
		try
		{
			np = null;
		}
		finally
		{
			try
			{
				_ = (Pj8)(object)Nf2.Default;
			}
			catch
			{
				while (obj != null)
				{
					_ = (m0N)(object)Nf2.Default;
				}
			}
			goto IL_05f0;
		}
		IL_05f0:
		try
		{
			while (true)
			{
				if ((object)Nf2.Default != null)
				{
					_ = (o5CZ)(object)Nf2.Default;
					co = (Co4)(object)Nf2.Default;
					_ = (k6D9)(object)Nf2.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		catch
		{
			if ((UIntPtr)Nf2.Default != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Pj8)(object)Nf2.Default;
				}
				finally
				{
					_ = (f0F)(object)Nf2.Default;
					goto end_IL_0630;
				}
			}
			_ = (f2L)(object)Nf2.Default;
			k6D = k6D;
			mb = mb;
			_ = (f0F)(object)Nf2.Default;
			end_IL_0630:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m0N m0N);
		try
		{
			m0N = m0N;
			_ = (Gj4)Nf2.Default;
			_003CModule_003E = _003CModule_003E;
			k6D = k6D;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				np = np;
			}
			goto IL_06c2;
		}
		IL_0922:
		do
		{
			eb = null;
		}
		while (obj != null);
		try
		{
			do
			{
				eb = eb;
			}
			while (obj != null || obj != null);
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr * unchecked((nuint)(UIntPtr)Nf2.Default)) / (nuint)(UIntPtr)Nf2.Default == 0)
			{
				do
				{
					d4E = d4E;
				}
				while ((object)Nf2.Default != null);
			}
			else
			{
				do
				{
					mb = mb;
				}
				while ((object)Nf2.Default != null);
			}
			goto IL_099a;
		}
		IL_06c2:
		checked
		{
			try
			{
				UIntPtr num = unchecked((UIntPtr)Nf2.Default);
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)num) - uIntPtr * uIntPtr == 0)
				{
					x8D = x8D;
					x8D = x8D;
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0 && unchecked((nuint)(UIntPtr)Nf2.Default / (nuint)(UIntPtr)Nf2.Default) - unchecked(checked(unchecked((nuint)(UIntPtr)Nf2.Default) + uIntPtr) / checked(uIntPtr - unchecked((nuint)default(UIntPtr)))) == 0)
				{
					w4R w4R = null;
				}
				goto IL_0747;
			}
		}
		IL_0396:
		while (obj != null)
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				_ = (m0N)(object)Nf2.Default;
				_ = (f0F)(object)Nf2.Default;
				_ = (f2L)(object)Nf2.Default;
				d8B = d8B;
			}
		}
		do
		{
			_ = (d1X)(object)Nf2.Default;
		}
		while ((object)Nf2.Default != null);
		np = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0F f0F);
		try
		{
			try
			{
				_ = (Co4)(object)Nf2.Default;
			}
			catch
			{
				nf = nf;
			}
			finally
			{
				do
				{
					f0F = (f0F)(object)Nf2.Default;
					f0F = f0F;
				}
				while (obj != null);
				goto end_IL_03b8;
			}
			end_IL_03b8:;
		}
		catch
		{
			try
			{
				do
				{
					f0F = f0F;
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					_ = (Gj4)Nf2.Default;
					goto end_IL_0407;
				}
				catch
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
					m0N = (m0N)(object)Nf2.Default;
					k6D = k6D;
					goto end_IL_0407;
				}
				end_IL_0407:;
			}
		}
		d4E = d4E;
		d4E = d4E;
		_ = (m0N)(object)Nf2.Default;
		_ = (d4E)(object)Nf2.Default;
		_ = (_003CModule_003E)(object)Nf2.Default;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Pj8)(object)Nf2.Default;
			_ = Nf2.Default;
			d4E = null;
			d4E = (d4E)(object)Nf2.Default;
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (x8D9)(object)Nf2.Default;
			}
			catch
			{
				_003CModule_003E = _003CModule_003E;
				co = co;
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			d4E = null;
			_ = (m0N)(object)Nf2.Default;
			_ = (_003CModule_003E)(object)Nf2.Default;
		}
		else
		{
			_ = Nf2.Default;
		}
		_003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
		_ = (Mb5)(object)Nf2.Default;
		checked
		{
			if (unchecked((nuint)(UIntPtr)Nf2.Default) + unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
			{
				Gj4 gj = (Gj4)Nf2.Default;
				goto IL_05c2;
			}
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr - unchecked(uIntPtr / unchecked((nuint)default(UIntPtr))) == 0)
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
				}
				else
				{
					_ = (Gj4)Nf2.Default;
				}
			}
			finally
			{
				try
				{
					_ = (Gj4)Nf2.Default;
				}
				finally
				{
					f0F = f0F;
					co = null;
					goto IL_05c2;
				}
			}
		}
		IL_099a:
		pm = pm;
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					pm = pm;
				}
				else
				{
					_ = (d1X)(object)Nf2.Default;
				}
				return;
			}
			finally
			{
				_ = (w4R)(object)Nf2.Default;
				return;
			}
		}
		finally
		{
			return;
		}
		IL_01ac:
		try
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				d8B = (d8B)(object)Nf2.Default;
			}
			else
			{
				o5CZ o5CZ = null;
				o5CZ = o5CZ;
			}
		}
		catch
		{
			try
			{
				m0N obj22 = (m0N)(object)Nf2.Default;
				m0N = m0N;
				m0N = obj22;
			}
			catch
			{
				m0N = m0N;
			}
		}
		finally
		{
			m0N = null;
			goto IL_0231;
		}
	}

	static void Sq5p()
	{
		_ = (Mb5)(object)Nf2.Default;
		w4R w4R = w4R;
		w4R = w4R;
		_ = (d4E)(object)Nf2.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Co4 co);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o5CZ o5CZ);
		try
		{
			try
			{
				try
				{
					Gj4 obj = (Gj4)Nf2.Default;
					Gj4 gj = gj;
					gj = obj;
				}
				catch
				{
					o5CZ = o5CZ;
					o5CZ = o5CZ;
				}
			}
			catch
			{
				try
				{
					_ = (Eb1)(object)Nf2.Default;
				}
				finally
				{
					co = co;
					co = co;
					goto end_IL_0055;
				}
				end_IL_0055:;
			}
		}
		catch
		{
			obj4 = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pj8 pj);
		try
		{
			UIntPtr num = (UIntPtr)Nf2.Default;
			num2 = default(UIntPtr);
			num2 = num2;
			num2 = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num) + num2 == 0)
				{
					num2 = default(UIntPtr);
					if (num2 == 0)
					{
						_ = (f2L)(object)Nf2.Default;
					}
					else
					{
						_ = (Co4)(object)Nf2.Default;
					}
				}
			}
		}
		catch
		{
			_ = (k6D9)(object)Nf2.Default;
			co = (Co4)(object)Nf2.Default;
			Pj8 obj6 = (Pj8)(object)Nf2.Default;
			pj = null;
			pj = obj6;
			o5CZ = o5CZ;
		}
		while (obj4 != null)
		{
			try
			{
				while (obj4 != null)
				{
					_ = (Eb1)(object)Nf2.Default;
				}
			}
			finally
			{
				try
				{
					co = null;
				}
				catch
				{
					Gj4 gj = default(Gj4);
					_ = (w4R)(object)Nf2.Default;
					_ = (f2L)(object)Nf2.Default;
					_ = (f9T6)(object)Nf2.Default;
				}
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k6D9 k6D);
		try
		{
			while (obj4 != null)
			{
			}
		}
		catch
		{
			k6D = k6D;
			k6D = null;
		}
		if (num2 == 0)
		{
			while ((object)Nf2.Default != null)
			{
				try
				{
					_ = Nf2.Default;
				}
				catch
				{
					_ = (f9T6)(object)Nf2.Default;
					co = null;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f2L f2L);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm9 pm);
		while (obj4 != null)
		{
			_ = (d4E)(object)Nf2.Default;
			Pm9 obj11 = (Pm9)(object)Nf2.Default;
			pm = (Pm9)(object)Nf2.Default;
			pm = obj11;
			f2L = (f2L)(object)Nf2.Default;
			f2L = f2L;
		}
		while ((object)Nf2.Default != null)
		{
			o5CZ = (o5CZ)(object)Nf2.Default;
		}
		pj = pj;
		_ = (Pm9)(object)Nf2.Default;
		if (num2 == 0)
		{
			UIntPtr num3 = (UIntPtr)Nf2.Default;
			UIntPtr num4 = (UIntPtr)Nf2.Default;
			num2 = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num3) + unchecked((nuint)num4) * unchecked(unchecked((nuint)default(UIntPtr)) / checked(num2 + num2 - unchecked((nuint)(UIntPtr)Nf2.Default))) == 0)
				{
					do
					{
						_ = (x8D9)(object)Nf2.Default;
					}
					while ((object)Nf2.Default != null);
				}
				else
				{
					_ = (d4E)(object)Nf2.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0F f0F);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f9T6 f9T7);
		if ((nuint)(UIntPtr)Nf2.Default / num2 == 0)
		{
			try
			{
				try
				{
					f0F = null;
					f0F = null;
				}
				catch
				{
					f2L = (f2L)(object)Nf2.Default;
					f9T7 = f9T7;
					f9T7 = null;
				}
			}
			catch
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					f9T7 = f9T7;
				}
			}
		}
		else
		{
			num2 = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) + num2 == 0)
				{
					_ = (f0F)(object)Nf2.Default;
					pm = pm;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nf2 nf);
		if (num2 == 0)
		{
			try
			{
				try
				{
					f2L = f2L;
				}
				finally
				{
					nf = Nf2.Default;
					nf = nf;
					goto end_IL_0335;
				}
				end_IL_0335:;
			}
			finally
			{
				try
				{
					_ = (d8B)(object)Nf2.Default;
				}
				finally
				{
					_ = (f2L)(object)Nf2.Default;
					goto IL_0377;
				}
			}
		}
		goto IL_0377;
		IL_0377:
		Mb5 mb;
		if (num2 == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D);
			do
			{
				try
				{
					_ = (f0F)(object)Nf2.Default;
					x8D9 obj14 = (x8D9)(object)Nf2.Default;
					x8D = x8D;
					x8D = obj14;
					Eb1 eb = null;
					eb = eb;
					_ = (d4E)(object)Nf2.Default;
				}
				finally
				{
					_ = (f2L)(object)Nf2.Default;
					continue;
				}
			}
			while ((object)Nf2.Default != null);
		}
		else if (num2 == 0)
		{
			if (num2 == 0)
			{
				_ = (o5CZ)(object)Nf2.Default;
				mb = null;
				mb = mb;
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Pm9)(object)Nf2.Default;
		}
		r8M r8M = r8M;
		r8M = r8M;
		_ = (m0N)(object)Nf2.Default;
		mb = (Mb5)(object)Nf2.Default;
		_ = (f2L)(object)Nf2.Default;
		num2 = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - num2 == 0)
			{
				nuint num5 = num2;
				nuint num6 = num2;
				num2 = default(UIntPtr);
				if (num5 * (num6 * unchecked(num2 / checked(unchecked((nuint)(UIntPtr)Nf2.Default / (nuint)(UIntPtr)Nf2.Default) * (num2 * num2)))) + num2 * num2 == 0)
				{
					do
					{
						f0F = f0F;
						_ = (x8D9)(object)Nf2.Default;
					}
					while ((object)Nf2.Default != null);
				}
			}
			else
			{
				k6D = k6D;
			}
			while ((object)Nf2.Default != null)
			{
				_ = (Gj4)Nf2.Default;
			}
			num2 = default(UIntPtr);
			if (num2 == 0)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					_ = (f2L)(object)Nf2.Default;
					o5CZ = o5CZ;
					d1X d1X = d1X;
					d1X = d1X;
				}
				else
				{
					while ((object)Nf2.Default != null)
					{
						_ = (k6D9)(object)Nf2.Default;
					}
				}
			}
			else
			{
				try
				{
					try
					{
						nf = null;
					}
					finally
					{
						_ = (f0F)(object)Nf2.Default;
						goto end_IL_0550;
					}
					end_IL_0550:;
				}
				catch
				{
					try
					{
						pm = null;
						mb = mb;
					}
					finally
					{
						_ = (o5CZ)(object)Nf2.Default;
						goto end_IL_0567;
					}
					end_IL_0567:;
				}
			}
			while (obj4 != null)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					num2 = default(UIntPtr);
					if (num2 == 0)
					{
						_ = (f2L)(object)Nf2.Default;
					}
					continue;
				}
				try
				{
					f2L = f2L;
				}
				finally
				{
					_ = (Eb1)(object)Nf2.Default;
					continue;
				}
			}
			_ = (o5CZ)(object)Nf2.Default;
			Gj4 gj = default(Gj4);
		}
		try
		{
			while (obj4 != null)
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					nf = nf;
				}
				else
				{
					pj = null;
				}
			}
		}
		catch
		{
			f9T7 = f9T7;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		while ((object)Nf2.Default != null)
		{
			try
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					d8B = (d8B)(object)Nf2.Default;
					d8B = d8B;
				}
			}
			catch
			{
				do
				{
					_ = (Co4)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
			}
		}
		while ((object)Nf2.Default != null)
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				pj = pj;
			}
		}
		do
		{
			nuint num7 = num2;
			num2 = default(UIntPtr);
			if (checked(num7 - num2) == 0)
			{
				d8B = d8B;
			}
		}
		while (obj4 != null);
		try
		{
			if (num2 == 0)
			{
				try
				{
					w4R = (w4R)(object)Nf2.Default;
				}
				finally
				{
					_ = (Pm9)(object)Nf2.Default;
					goto end_IL_06bb;
				}
			}
			do
			{
				_ = (r8M)Nf2.Default;
				co = co;
			}
			while (obj4 != null);
			end_IL_06bb:;
		}
		catch
		{
			do
			{
				try
				{
					_ = (f2L)(object)Nf2.Default;
				}
				finally
				{
					pj = (Pj8)(object)Nf2.Default;
					continue;
				}
			}
			while ((object)Nf2.Default != null);
		}
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			_ = (f9T6)(object)Nf2.Default;
			return;
		}
		_003CModule_003E obj19 = (_003CModule_003E)(object)Nf2.Default;
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		_003CModule_003E = obj19;
	}
}
