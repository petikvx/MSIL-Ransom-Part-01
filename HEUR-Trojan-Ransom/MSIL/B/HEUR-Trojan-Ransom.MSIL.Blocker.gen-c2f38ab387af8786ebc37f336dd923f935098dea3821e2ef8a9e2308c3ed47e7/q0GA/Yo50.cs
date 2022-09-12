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
using Bz7;
using Di68;
using Gn3;
using Hx0;
using Jz9;
using Kd1q;
using Kr2c;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Yr36;
using a2A;
using b9YC;
using e2D3;
using i4B6;
using j3S2;
using n2X;
using o5FP;
using q4G1;
using w1R;
using x0S1;
using x9B;

namespace q0GA;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Yo50
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class z4Y2
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dx5s m_frmBilling;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qp49 m_frmBillingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g2J4 m_frmMain;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cx7 m_frmProcessingCost;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qt2 m_frmProcessingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public o2T m_frmProductDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public z8Y m_frmPurchaseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public c8CP m_frmSalesDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b7KC m_frmSupplierDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y2HN m_frmTransportDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public So3 m_frmWarehouseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q1M m_Login;

		public Dx5s frmBilling
		{
			[DebuggerHidden]
			get
			{
				m_frmBilling = q2G4(m_frmBilling);
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
					m3XB(ref m_frmBilling);
				}
			}
		}

		public Qp49 frmBillingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmBillingDetail = q2G4(m_frmBillingDetail);
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
					m3XB(ref m_frmBillingDetail);
				}
			}
		}

		public g2J4 frmMain
		{
			[DebuggerHidden]
			get
			{
				m_frmMain = q2G4(m_frmMain);
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
					m3XB(ref m_frmMain);
				}
			}
		}

		public Cx7 frmProcessingCost
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingCost = q2G4(m_frmProcessingCost);
				return m_frmProcessingCost;
			}
			[DebuggerHidden]
			set
			{
				bool num = value == m_frmProcessingCost;
				Qp49.char_0[203] = (char)((Qp49.char_0[203] | Qp49.char_0[75]) & 'M');
				if (!num)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m3XB(ref m_frmProcessingCost);
				}
			}
		}

		public Qt2 frmProcessingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingDetail = q2G4(m_frmProcessingDetail);
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
					m3XB(ref m_frmProcessingDetail);
					Qp49.char_0[40] = (char)(Qp49.char_0[40] & Qp49.char_0[77] & 'õ');
				}
			}
		}

		public o2T frmProductDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProductDetail = q2G4(m_frmProductDetail);
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
					m3XB(ref m_frmProductDetail);
				}
			}
		}

		public z8Y frmPurchaseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmPurchaseDetail = q2G4(m_frmPurchaseDetail);
				return m_frmPurchaseDetail;
			}
			[DebuggerHidden]
			set
			{
				char[] char_ = Qp49.char_0;
				int num = 1;
				while (true)
				{
					bool num2 = value == m_frmPurchaseDetail;
					n0J5.char_0[53] = (char)((n0J5.char_0[53] * n0J5.char_0[241]) & '(');
					if (num2)
					{
						switch (char_[171])
						{
						case '酿':
							num = 5;
							return;
						case '酾':
							goto IL_0074;
						case '醂':
							goto IL_007c;
						case '醄':
							goto end_IL_0042;
						case '醀':
						case '醁':
						case '醃':
							return;
						}
						continue;
					}
					num = 2;
					goto IL_0074;
					IL_0074:
					if (value != null)
					{
						num = 6;
						goto IL_007c;
					}
					num = 8;
					break;
					IL_007c:
					throw new ArgumentException("Property can only be set to Nothing");
					continue;
					end_IL_0042:
					break;
				}
				m3XB(ref m_frmPurchaseDetail);
			}
		}

		public c8CP frmSalesDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSalesDetail = q2G4(m_frmSalesDetail);
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
					m3XB(ref m_frmSalesDetail);
					n0J5.char_0[344] = (char)((n0J5.char_0[344] | n0J5.char_0[128]) & '¿');
				}
			}
		}

		public b7KC frmSupplierDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSupplierDetail = q2G4(m_frmSupplierDetail);
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
					m3XB(ref m_frmSupplierDetail);
				}
			}
		}

		public y2HN frmTransportDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmTransportDetail = q2G4(m_frmTransportDetail);
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
					m3XB(ref m_frmTransportDetail);
				}
			}
		}

		public So3 frmWarehouseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmWarehouseDetail = q2G4(m_frmWarehouseDetail);
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
					m3XB(ref m_frmWarehouseDetail);
				}
			}
		}

		public q1M Login
		{
			[DebuggerHidden]
			get
			{
				m_Login = q2G4(m_Login);
				return m_Login;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Login)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					m3XB(ref m_Login);
				}
			}
		}

		[DebuggerHidden]
		private static Hk57 q2G4<Hk57>(Hk57 Gi92) where Hk57 : Form, new()
		{
			if (Gi92 == null || ((Control)Gi92).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Hk57)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Hk57), null);
				try
				{
					return new Hk57();
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
					m_FormBeingCreated.Remove(typeof(Hk57));
				}
			}
			return Gi92;
		}

		[DebuggerHidden]
		private void m3XB<i4HG>(ref i4HG q5R4) where i4HG : Form
		{
			((Component)q5R4).Dispose();
			q5R4 = default(i4HG);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public z4Y2()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool e0Y3(object s8LE)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(s8LE));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int f4R5()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type s7GY()
		{
			return typeof(z4Y2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Wd6p()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class i5D2
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Hd8m(object Jk13)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Jk13));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Sc9q()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type Mq4y()
		{
			return typeof(i5D2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Na25()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static m9B8 a7CL<m9B8>(m9B8 b0ES) where m9B8 : new()
		{
			bool num = b0ES == null;
			n0J5.char_0[56] = (char)((n0J5.char_0[56] + n0J5.char_0[364]) & '\n');
			if (num)
			{
				return new m9B8();
			}
			return b0ES;
		}

		[DebuggerHidden]
		private void e2JR<k2ZB>(ref k2ZB z4PL)
		{
			z4PL = default(k2ZB);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public i5D2()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class y5F0<p0CD> where p0CD : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static p0CD m_ThreadStaticValue;

		internal p0CD GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new p0CD();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public y5F0()
		{
		}
	}

	private static readonly y5F0<Qe07> m_ComputerObjectProvider = new y5F0<Qe07>();

	private static readonly y5F0<z0R3> m_AppObjectProvider = new y5F0<z0R3>();

	private static readonly y5F0<User> m_UserObjectProvider = new y5F0<User>();

	private static y5F0<z4Y2> m_MyFormsObjectProvider = new y5F0<z4Y2>();

	private static readonly y5F0<i5D2> m_MyWebServicesObjectProvider = new y5F0<i5D2>();

	[HelpKeyword("My.Computer")]
	internal static Qe07 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static z0R3 Application
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
	internal static z4Y2 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static i5D2 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}

	static void Pb6q()
	{
		_ = (Qt2)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c8CP c8CP);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cx7 cx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		e7WK e7WK;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qp49 qp);
		try
		{
			do
			{
				c8CP = c8CP;
				c8CP = c8CP;
				obj = obj;
			}
			while (obj != null);
		}
		catch
		{
			try
			{
				num = num;
				num = default(UIntPtr);
				if (num == 0)
				{
					e7WK obj2 = e7WK.Default;
					e7WK = e7WK.Default;
					e7WK = obj2;
				}
				else
				{
					Cx7 obj3 = (Cx7)(object)e7WK.Default;
					cx = cx;
					cx = obj3;
				}
			}
			catch
			{
				try
				{
					cx = (Cx7)(object)e7WK.Default;
					goto end_IL_007b;
				}
				catch
				{
					qp = qp;
					qp = null;
					goto end_IL_007b;
				}
				end_IL_007b:;
			}
		}
		_ = (Pw9k)(object)e7WK.Default;
		e7WK = null;
		_ = (c8CP)(object)e7WK.Default;
		try
		{
			o2T o2T = o2T;
			o2T = null;
		}
		finally
		{
			try
			{
				while ((object)e7WK.Default != null)
				{
					_ = (Yo50)(object)e7WK.Default;
				}
			}
			catch
			{
				do
				{
					_ = (n0J5)(object)e7WK.Default;
				}
				while (obj != null);
			}
			goto IL_00fd;
		}
		IL_0222:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pw9k pw9k);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fz0 fz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yo50 yo);
		try
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					fz = (Fz0)e7WK.Default;
					fz = fz;
				}
				catch
				{
					qp = (Qp49)(object)e7WK.Default;
				}
			}
		}
		finally
		{
			try
			{
				try
				{
					yo = yo;
				}
				finally
				{
					_ = (Qe07)(object)e7WK.Default;
					_ = (Qt2)(object)e7WK.Default;
					goto end_IL_025f;
				}
				end_IL_025f:;
			}
			catch
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Cx7)(object)e7WK.Default;
				}
				else
				{
					pw9k = pw9k;
					pw9k = pw9k;
				}
			}
			goto IL_02b6;
		}
		IL_00fd:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y2HN y2HN);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1M q1M);
		checked
		{
			try
			{
				_ = (z8Y)(object)e7WK.Default;
			}
			catch
			{
			}
			finally
			{
				if (unchecked((nuint)(UIntPtr)e7WK.Default) - num == 0)
				{
					_ = (Cx7)(object)e7WK.Default;
					goto IL_0174;
				}
				try
				{
					_ = e7WK.Default;
					q1M = q1M;
					q1M = q1M;
					y2HN obj11 = (y2HN)(object)e7WK.Default;
					y2HN = y2HN;
					y2HN = obj11;
				}
				finally
				{
					yo = null;
					yo = yo;
					goto IL_0174;
				}
			}
		}
		IL_0174:
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z8Y z8Y);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				z8Y = null;
				z8Y = null;
			}
			finally
			{
				_ = (n0J5)(object)e7WK.Default;
				_ = (q1M)(object)e7WK.Default;
				_ = (Pw9k)(object)e7WK.Default;
				goto IL_0222;
			}
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (n0J5)(object)e7WK.Default;
				_ = (g2J4)(object)e7WK.Default;
			}
			catch
			{
				n0J5 n0J = (n0J5)(object)e7WK.Default;
				n0J = n0J;
			}
			goto IL_0222;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z0R3 z0R);
		try
		{
			z0R = z0R;
			z0R = z0R;
		}
		finally
		{
			o2T o2T = null;
			b7KC b7KC = b7KC;
			b7KC = b7KC;
			_ = e7WK.Default;
			goto IL_0222;
		}
		IL_02b6:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6G b6G);
		try
		{
			try
			{
				while ((object)e7WK.Default != null)
				{
					b6G obj13 = (b6G)e7WK.Default;
					b6G = b6G;
					b6G = obj13;
				}
			}
			catch
			{
				e7WK = e7WK;
			}
		}
		catch
		{
			try
			{
				yo = yo;
			}
			finally
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (z8Y)(object)e7WK.Default;
					cx = (Cx7)(object)e7WK.Default;
					z8Y = z8Y;
				}
				else
				{
					_ = (z0R3)(object)e7WK.Default;
					_ = (Fz0)e7WK.Default;
				}
				goto end_IL_02ec;
			}
			end_IL_02ec:;
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				q1M = (q1M)(object)e7WK.Default;
			}
			goto IL_03de;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qt2 qt);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				e7WK = e7WK.Default;
				qp = qp;
				qt = qt;
				qt = null;
				_ = (c8CP)(object)e7WK.Default;
			}
			else
			{
				z0R = z0R;
			}
		}
		finally
		{
			try
			{
				_ = (b7KC)(object)e7WK.Default;
			}
			catch
			{
				_ = (c8CP)(object)e7WK.Default;
				cx = cx;
				_ = e7WK.Default;
			}
			goto IL_03de;
		}
		IL_06c1:
		try
		{
			while (obj != null)
			{
				try
				{
					_ = (b6G)e7WK.Default;
				}
				catch
				{
					_ = (g2J4)(object)e7WK.Default;
				}
			}
		}
		catch
		{
			try
			{
				_ = (_003CModule_003E)(object)e7WK.Default;
			}
			finally
			{
				if (num == 0)
				{
					qt = qt;
				}
				else
				{
					e7WK = e7WK;
				}
				goto end_IL_06e9;
			}
			end_IL_06e9:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dx5s dx5s);
		while (obj != null)
		{
			do
			{
				if (num != 0)
				{
					_ = (So3)(object)e7WK.Default;
					dx5s = dx5s;
					pw9k = pw9k;
				}
				else
				{
					_ = (z0R3)(object)e7WK.Default;
				}
			}
			while (obj != null);
		}
		_ = (Fz0)e7WK.Default;
		checked
		{
			while (obj != null)
			{
				num = default(UIntPtr);
				if (num + (unchecked((nuint)(UIntPtr)e7WK.Default) * num + unchecked((nuint)(UIntPtr)e7WK.Default)) == 0)
				{
					yo = null;
					_ = (Qp49)(object)e7WK.Default;
					b6G = b6G;
					continue;
				}
				try
				{
					qt = qt;
				}
				finally
				{
					continue;
				}
			}
			while (obj != null)
			{
				c8CP = c8CP;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qe07 qe);
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				if (num == 0)
				{
					_ = (b6G)e7WK.Default;
					continue;
				}
				qe = (Qe07)(object)e7WK.Default;
				_ = (z8Y)(object)e7WK.Default;
			}
		}
		else
		{
			_ = (Pw9k)(object)e7WK.Default;
		}
		if (num == 0)
		{
			try
			{
				_ = (Qp49)(object)e7WK.Default;
			}
			finally
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = e7WK.Default;
				}
				goto IL_083f;
			}
		}
		goto IL_083f;
		IL_03de:
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				try
				{
					qt = qt;
				}
				finally
				{
					_ = (g2J4)(object)e7WK.Default;
					goto end_IL_03ee;
				}
				end_IL_03ee:;
			}
			catch
			{
				_ = (c8CP)(object)e7WK.Default;
			}
		}
		try
		{
			_ = (Qe07)(object)e7WK.Default;
		}
		catch
		{
			fz = fz;
			q1M = null;
			o2T o2T = null;
		}
		while (true)
		{
			if (obj != null)
			{
				n0J5 n0J = null;
				_ = (Qp49)(object)e7WK.Default;
				b7KC b7KC = (b7KC)(object)e7WK.Default;
				_ = (Qt2)(object)e7WK.Default;
			}
			else if ((object)e7WK.Default == null && obj == null)
			{
				break;
			}
		}
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				while ((object)e7WK.Default != null)
				{
					_ = (Cx7)(object)e7WK.Default;
				}
			}
			else if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Qt2)(object)e7WK.Default;
			}
			else
			{
				fz = fz;
			}
		}
		try
		{
			while (obj != null)
			{
				_ = (b6G)e7WK.Default;
			}
		}
		catch
		{
			if (num == 0)
			{
				try
				{
					qt = qt;
				}
				finally
				{
					_ = (Qe07)(object)e7WK.Default;
					goto end_IL_04ed;
				}
			}
			if (num == 0)
			{
				_ = (o2T)(object)e7WK.Default;
			}
			else
			{
				q1M = (q1M)(object)e7WK.Default;
			}
			end_IL_04ed:;
		}
		_ = (Fz0)e7WK.Default;
		b6G = b6G;
		pw9k = (Pw9k)(object)e7WK.Default;
		_ = (b6G)e7WK.Default;
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (n0J5)(object)e7WK.Default;
			}
			while ((object)e7WK.Default != null);
		}
		if (num == 0)
		{
			qp = qp;
			_ = (So3)(object)e7WK.Default;
			_ = (Pw9k)(object)e7WK.Default;
			_ = (q1M)(object)e7WK.Default;
		}
		else if (num == 0)
		{
			try
			{
				z8Y = null;
			}
			catch
			{
				yo = null;
			}
		}
		else
		{
			while ((object)e7WK.Default != null)
			{
				c8CP = (c8CP)(object)e7WK.Default;
			}
		}
		while (true)
		{
			if (obj != null)
			{
				do
				{
					y2HN = y2HN;
				}
				while (obj != null);
			}
			else if ((object)e7WK.Default == null)
			{
				break;
			}
		}
		_ = (Fz0)e7WK.Default;
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					qe = null;
					qe = qe;
				}
			}
			else if (num == 0)
			{
				_ = (q1M)(object)e7WK.Default;
			}
		}
		catch
		{
			try
			{
				while (obj != null)
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
				}
			}
			finally
			{
				try
				{
					z8Y = (z8Y)(object)e7WK.Default;
				}
				finally
				{
					_ = (b7KC)(object)e7WK.Default;
					goto end_IL_064c;
				}
			}
			end_IL_064c:;
		}
		_ = (Dx5s)(object)e7WK.Default;
		q1M = null;
		try
		{
			dx5s = null;
			dx5s = dx5s;
		}
		finally
		{
			try
			{
				qp = null;
			}
			catch
			{
				So3 so = so;
				so = so;
			}
			goto IL_06c1;
		}
		IL_083f:
		try
		{
			z0R = null;
			qe = qe;
			_ = (o2T)(object)e7WK.Default;
			_ = (b6G)e7WK.Default;
		}
		catch
		{
			do
			{
				try
				{
					_ = (z8Y)(object)e7WK.Default;
				}
				catch
				{
					_ = (o2T)(object)e7WK.Default;
				}
			}
			while ((object)e7WK.Default != null);
		}
		qe = qe;
	}

	static void Dy0e()
	{
		while ((object)e7WK.Default != null)
		{
			_ = (Qp49)(object)e7WK.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g2J4 g2J);
		while (true)
		{
			obj = obj;
			if (obj == null)
			{
				break;
			}
			try
			{
				_ = (Dx5s)(object)e7WK.Default;
				_ = (b6G)e7WK.Default;
			}
			catch
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					n0J5 n0J = (n0J5)(object)e7WK.Default;
					n0J = n0J;
				}
				else
				{
					g2J = null;
					g2J = g2J;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out So3 so);
		try
		{
			Cx7 cx = null;
			cx = cx;
		}
		finally
		{
			uIntPtr = uIntPtr;
			if (uIntPtr == 0)
			{
				_ = (Dx5s)(object)e7WK.Default;
			}
			else
			{
				try
				{
					_ = e7WK.Default;
				}
				catch
				{
					so = so;
					so = so;
					_ = (Pw9k)(object)e7WK.Default;
					_ = (Yo50)(object)e7WK.Default;
				}
			}
			goto IL_00da;
		}
		IL_0566:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fz0 fz);
		try
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Qe07)(object)e7WK.Default;
				}
				catch
				{
					fz = fz;
					fz = fz;
				}
			}
		}
		finally
		{
			do
			{
				_ = (q1M)(object)e7WK.Default;
			}
			while ((object)e7WK.Default != null || obj != null);
			goto IL_05b9;
		}
		IL_081b:
		try
		{
			_ = (Cx7)(object)e7WK.Default;
		}
		finally
		{
			_ = (Qe07)(object)e7WK.Default;
			goto IL_0836;
		}
		IL_07b5:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qt2 qt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o2T o2T);
		try
		{
			try
			{
				_ = (y2HN)(object)e7WK.Default;
			}
			finally
			{
				o2T = null;
				_ = (Fz0)e7WK.Default;
				goto end_IL_07b7;
			}
			end_IL_07b7:;
		}
		catch
		{
			while (obj != null)
			{
				qt = null;
			}
		}
		finally
		{
			while (true)
			{
				if (obj != null)
				{
					Cx7 cx = null;
					_ = (Qt2)(object)e7WK.Default;
					_ = (c8CP)(object)e7WK.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
			goto IL_081b;
		}
		IL_00da:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qp49 qp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qe07 qe);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yo50 yo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6G b6G);
		checked
		{
			try
			{
				if (unchecked(uIntPtr / uIntPtr) + uIntPtr - uIntPtr == 0)
				{
					try
					{
						_ = (_003CModule_003E)(object)e7WK.Default;
					}
					catch
					{
						qe = (Qe07)(object)e7WK.Default;
						qe = qe;
					}
				}
				else
				{
					do
					{
						_ = (b7KC)(object)e7WK.Default;
						yo = yo;
						yo = yo;
					}
					while (obj != null);
				}
			}
			finally
			{
				try
				{
					while ((object)e7WK.Default != null)
					{
						_003CModule_003E = null;
						_003CModule_003E = _003CModule_003E;
					}
				}
				finally
				{
					try
					{
						qp = qp;
						qp = qp;
					}
					catch
					{
						b6G = (b6G)e7WK.Default;
						b6G = b6G;
					}
					goto IL_0188;
				}
			}
		}
		IL_0188:
		_ = (_003CModule_003E)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y2HN y2HN);
		do
		{
			try
			{
				while (obj != null)
				{
					_003CModule_003E = _003CModule_003E;
					y2HN = y2HN;
					y2HN = y2HN;
				}
			}
			finally
			{
				while (obj != null)
				{
					yo = yo;
				}
				continue;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dx5s dx5s);
		checked
		{
			try
			{
				_ = (Qp49)(object)e7WK.Default;
			}
			finally
			{
				nuint num = uIntPtr * uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num2 = unchecked(num / uIntPtr / uIntPtr);
				uIntPtr = default(UIntPtr);
				if (num2 * unchecked(checked(uIntPtr - (uIntPtr + uIntPtr)) / (nuint)(UIntPtr)e7WK.Default) == 0)
				{
					try
					{
						_ = (z8Y)(object)e7WK.Default;
					}
					finally
					{
						_ = (z0R3)(object)e7WK.Default;
						goto IL_0265;
					}
				}
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					dx5s = (Dx5s)(object)e7WK.Default;
					dx5s = dx5s;
				}
				goto IL_0265;
			}
		}
		IL_037d:
		UIntPtr num3 = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c8CP c8CP);
		if (checked(unchecked((nuint)num3) - (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)default(UIntPtr)) - (uIntPtr - uIntPtr * unchecked((nuint)(UIntPtr)e7WK.Default) - uIntPtr))) + (uIntPtr + uIntPtr)) == 0)
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					c8CP = null;
					c8CP = c8CP;
					g2J = (g2J4)(object)e7WK.Default;
					b6G = b6G;
				}
				else
				{
					_ = (y2HN)(object)e7WK.Default;
				}
			}
			else
			{
				while ((object)e7WK.Default != null)
				{
					c8CP = (c8CP)(object)e7WK.Default;
				}
			}
			goto IL_049a;
		}
		try
		{
			c8CP = (c8CP)(object)e7WK.Default;
		}
		finally
		{
			b7KC b7KC = null;
			goto IL_049a;
		}
		IL_0a36:
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z8Y z8Y);
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (obj != null)
				{
					_003CModule_003E = null;
				}
			}
			catch
			{
				_ = (z8Y)(object)e7WK.Default;
				_ = (z8Y)(object)e7WK.Default;
				z8Y = z8Y;
			}
		}
		while ((object)e7WK.Default != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while ((object)e7WK.Default != null)
				{
					qt = null;
				}
				continue;
			}
			try
			{
				_ = (q1M)(object)e7WK.Default;
			}
			finally
			{
				qp = qp;
				continue;
			}
		}
		if ((nuint)(UIntPtr)e7WK.Default / (nuint)(UIntPtr)e7WK.Default == 0)
		{
			try
			{
				try
				{
					g2J = null;
					return;
				}
				finally
				{
					_ = (n0J5)(object)e7WK.Default;
					return;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					_ = (Qt2)(object)e7WK.Default;
				}
				else
				{
					yo = null;
				}
				return;
			}
		}
		do
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - uIntPtr) == 0)
			{
				qp = qp;
			}
		}
		while (obj != null);
		return;
		IL_049a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z0R3 z0R);
		while (obj != null)
		{
			while ((object)e7WK.Default != null)
			{
				try
				{
					y2HN = y2HN;
					z0R = (z0R3)(object)e7WK.Default;
					z0R = null;
					y2HN = y2HN;
					_ = (Yo50)(object)e7WK.Default;
				}
				finally
				{
					_ = (Fz0)e7WK.Default;
					continue;
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (o2T)(object)e7WK.Default;
		}
		while (obj != null)
		{
			try
			{
				qt = null;
				qt = qt;
			}
			finally
			{
				_ = (q1M)(object)e7WK.Default;
				_ = (q1M)(object)e7WK.Default;
				continue;
			}
		}
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			dx5s = dx5s;
		}
		_ = (q1M)(object)e7WK.Default;
		try
		{
			UIntPtr num4 = (UIntPtr)e7WK.Default;
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num4) + uIntPtr * uIntPtr == 0)
				{
					z0R = z0R;
				}
				else
				{
					_ = (Qe07)(object)e7WK.Default;
				}
			}
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (q1M)(object)e7WK.Default;
				}
			}
			goto IL_0566;
		}
		IL_0265:
		try
		{
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				nuint num5 = uIntPtr / (nuint)(UIntPtr)e7WK.Default;
				uIntPtr = default(UIntPtr);
				if (checked(num5 * (uIntPtr - uIntPtr)) == 0)
				{
					_ = (Dx5s)(object)e7WK.Default;
					continue;
				}
				z8Y = z8Y;
				z8Y = null;
			}
		}
		finally
		{
			do
			{
				if ((UIntPtr)e7WK.Default != (UIntPtr)(nuint)0u)
				{
					so = so;
				}
				else
				{
					_ = e7WK.Default;
				}
			}
			while (obj != null);
			goto IL_02ea;
		}
		IL_02ea:
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				do
				{
					b7KC b7KC = null;
					b7KC = b7KC;
				}
				while (obj != null);
			}
			else if (uIntPtr == 0)
			{
				_ = (Dx5s)(object)e7WK.Default;
			}
		}
		try
		{
			while (obj != null)
			{
				if (uIntPtr == 0)
				{
					qe = qe;
				}
				else
				{
					b7KC b7KC = null;
				}
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					b6G = (b6G)e7WK.Default;
				}
				catch
				{
					_ = (z0R3)(object)e7WK.Default;
				}
			}
			goto IL_037d;
		}
		IL_0836:
		_003CModule_003E = null;
		if (uIntPtr == 0)
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					Pw9k pw9k = null;
					pw9k = pw9k;
				}
			}
			catch
			{
				try
				{
					qp = qp;
					z0R = z0R;
				}
				finally
				{
					qe = (Qe07)(object)e7WK.Default;
					goto end_IL_0862;
				}
				end_IL_0862:;
			}
		}
		do
		{
			try
			{
				try
				{
					_ = (Qp49)(object)e7WK.Default;
				}
				catch
				{
					so = null;
					g2J = g2J;
					b6G = default(b6G);
					_ = (Qp49)(object)e7WK.Default;
				}
			}
			catch
			{
				try
				{
					_ = (c8CP)(object)e7WK.Default;
				}
				finally
				{
					_ = (Fz0)e7WK.Default;
					goto end_IL_08c4;
				}
				end_IL_08c4:;
			}
		}
		while (obj != null);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (n0J5)(object)e7WK.Default;
					dx5s = (Dx5s)(object)e7WK.Default;
				}
				catch
				{
					z0R = z0R;
				}
			}
		}
		else
		{
			while ((object)e7WK.Default != null)
			{
				nuint num6 = uIntPtr;
				UIntPtr num7 = (UIntPtr)e7WK.Default;
				uIntPtr = default(UIntPtr);
				if (checked(num6 - (unchecked((nuint)num7) + uIntPtr)) / (nuint)(UIntPtr)e7WK.Default == 0)
				{
					_ = (b6G)e7WK.Default;
					n0J5 n0J = (n0J5)(object)e7WK.Default;
					continue;
				}
				yo = null;
				_ = (Pw9k)(object)e7WK.Default;
				b6G = default(b6G);
				_ = (g2J4)(object)e7WK.Default;
			}
		}
		while ((object)e7WK.Default != null)
		{
			_ = (Qe07)(object)e7WK.Default;
		}
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			_ = e7WK.Default;
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					b7KC b7KC = null;
					qt = qt;
					Cx7 cx = (Cx7)(object)e7WK.Default;
					_ = (y2HN)(object)e7WK.Default;
				}
				finally
				{
					o2T = o2T;
					g2J = null;
					_ = (Cx7)(object)e7WK.Default;
					_ = (b6G)e7WK.Default;
					goto IL_0a36;
				}
			}
		}
		goto IL_0a36;
		IL_05b9:
		do
		{
			z8Y = z8Y;
		}
		while (obj != null);
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			nuint num8 = checked(uIntPtr * uIntPtr);
			uIntPtr = default(UIntPtr);
			if (num8 / uIntPtr / (uIntPtr / (nuint)(UIntPtr)e7WK.Default) == 0)
			{
				so = null;
				_ = (Fz0)e7WK.Default;
				_ = (Dx5s)(object)e7WK.Default;
			}
		}
		_ = (q1M)(object)e7WK.Default;
		try
		{
			try
			{
				do
				{
					y2HN = null;
				}
				while (obj != null);
			}
			finally
			{
				qp = qp;
				goto end_IL_062d;
			}
			end_IL_062d:;
		}
		catch
		{
			try
			{
				_ = (Fz0)e7WK.Default;
			}
			catch
			{
				o2T = (o2T)(object)e7WK.Default;
				o2T = o2T;
				qt = qt;
			}
			finally
			{
				while ((object)e7WK.Default != null)
				{
					fz = fz;
					g2J = (g2J4)(object)e7WK.Default;
					_ = (So3)(object)e7WK.Default;
				}
				goto end_IL_064b;
			}
			end_IL_064b:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e7WK e7WK);
		checked
		{
			do
			{
				uIntPtr = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) + uIntPtr != 0)
				{
					if (unchecked((nuint)(UIntPtr)e7WK.Default) - unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
					{
						c8CP = (c8CP)(object)e7WK.Default;
						continue;
					}
					_ = (z8Y)(object)e7WK.Default;
					z0R = null;
					continue;
				}
				try
				{
					_ = (b7KC)(object)e7WK.Default;
				}
				finally
				{
					e7WK = e7WK;
					e7WK = e7WK;
					continue;
				}
			}
			while ((object)e7WK.Default != null);
		}
		try
		{
			do
			{
				try
				{
					_ = (Qp49)(object)e7WK.Default;
				}
				finally
				{
					g2J = g2J;
					Cx7 cx = null;
					_ = (c8CP)(object)e7WK.Default;
					e7WK = e7WK;
					continue;
				}
			}
			while ((object)e7WK.Default != null);
		}
		finally
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					e7WK = null;
					c8CP = c8CP;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (o2T)(object)e7WK.Default;
				}
			}
			goto IL_07b5;
		}
	}

	static void s1Z6()
	{
		n0J5 n0J = n0J;
		n0J = n0J;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qe07 qe);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o2T o2T);
		try
		{
			try
			{
				_ = (b6G)e7WK.Default;
			}
			finally
			{
				num = num;
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (Dx5s)(object)e7WK.Default;
				}
				else
				{
					o2T obj = (o2T)(object)e7WK.Default;
					o2T = o2T;
					o2T = obj;
				}
				goto end_IL_0010;
			}
			end_IL_0010:;
		}
		finally
		{
			try
			{
				try
				{
					qe = qe;
					qe = null;
				}
				finally
				{
					_ = (Dx5s)(object)e7WK.Default;
					goto end_IL_005e;
				}
				end_IL_005e:;
			}
			catch
			{
			}
			goto IL_0082;
		}
		IL_0082:
		try
		{
		}
		catch
		{
			nuint num2;
			checked
			{
				num2 = unchecked((nuint)(UIntPtr)e7WK.Default) * num;
				num = default(UIntPtr);
			}
			if (checked(num2 + num) / (nuint)(UIntPtr)e7WK.Default == 0)
			{
				checked
				{
					if (num - unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
					{
						_ = e7WK.Default;
					}
					else
					{
						_ = (z8Y)(object)e7WK.Default;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		try
		{
			do
			{
				if ((UIntPtr)e7WK.Default != (UIntPtr)(nuint)0u)
				{
					_ = (y2HN)(object)e7WK.Default;
				}
				else
				{
					_ = (Cx7)(object)e7WK.Default;
				}
				obj4 = e7WK.Default;
			}
			while (obj4 != null);
		}
		catch
		{
			do
			{
				_ = (Qt2)(object)e7WK.Default;
				_ = (_003CModule_003E)(object)e7WK.Default;
				_ = (Qe07)(object)e7WK.Default;
			}
			while (obj4 != null);
		}
		_ = (_003CModule_003E)(object)e7WK.Default;
		try
		{
			do
			{
				_ = e7WK.Default;
			}
			while (obj4 != null);
		}
		finally
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Dx5s)(object)e7WK.Default;
				}
				else
				{
					_ = (z0R3)(object)e7WK.Default;
				}
			}
			goto IL_019d;
		}
		IL_01f4:
		_ = (c8CP)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y2HN y2HN);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e7WK e7WK);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fz0 fz);
		do
		{
			try
			{
				y2HN = y2HN;
				y2HN = null;
				_ = (c8CP)(object)e7WK.Default;
				n0J = null;
				qe = (Qe07)(object)e7WK.Default;
			}
			catch
			{
				n0J = n0J;
			}
			finally
			{
				try
				{
					_ = (Qt2)(object)e7WK.Default;
					e7WK = e7WK;
					_ = (Fz0)e7WK.Default;
					Pw9k pw9k = (Pw9k)(object)e7WK.Default;
					pw9k = pw9k;
				}
				catch
				{
					Qp49 qp = null;
					qp = qp;
					o2T = o2T;
					fz = fz;
				}
				continue;
			}
		}
		while ((object)e7WK.Default != null);
		_ = (Yo50)(object)e7WK.Default;
		b6G b6G;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj4 != null)
				{
					b6G = default(b6G);
				}
			}
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Qp49)(object)e7WK.Default;
				}
				else
				{
					_ = (y2HN)(object)e7WK.Default;
				}
			}
			goto IL_0314;
		}
		IL_0470:
		_ = (c8CP)(object)e7WK.Default;
		qe = qe;
		_ = (So3)(object)e7WK.Default;
		_ = (Yo50)(object)e7WK.Default;
		_ = (g2J4)(object)e7WK.Default;
		_ = (_003CModule_003E)(object)e7WK.Default;
		o2T = null;
		if (num != 0)
		{
			while ((object)e7WK.Default != null)
			{
				try
				{
					_ = (b6G)e7WK.Default;
				}
				catch
				{
					e7WK = e7WK.Default;
				}
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			while ((object)e7WK.Default != null)
			{
				_ = (q1M)(object)e7WK.Default;
			}
		}
		do
		{
			_ = (c8CP)(object)e7WK.Default;
		}
		while ((object)e7WK.Default != null);
		do
		{
			try
			{
				_ = (z8Y)(object)e7WK.Default;
				y2HN = y2HN;
				_ = (y2HN)(object)e7WK.Default;
			}
			catch
			{
				try
				{
					_ = (o2T)(object)e7WK.Default;
					_ = (So3)(object)e7WK.Default;
				}
				catch
				{
				}
			}
		}
		while ((object)e7WK.Default != null);
		_ = (q1M)(object)e7WK.Default;
		do
		{
			Pw9k pw9k = (Pw9k)(object)e7WK.Default;
		}
		while (obj4 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cx7 cx);
		try
		{
			if (num == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					cx = (Cx7)(object)e7WK.Default;
					cx = null;
				}
			}
		}
		catch
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Pw9k)(object)e7WK.Default;
				}
			}
			catch
			{
				n0J = null;
				b6G = b6G;
			}
		}
		checked
		{
			if (num == 0)
			{
				while ((object)e7WK.Default != null)
				{
					UIntPtr num3 = unchecked((UIntPtr)e7WK.Default);
					num = default(UIntPtr);
					if ((unchecked((nuint)num3) + num) * num * unchecked((nuint)(UIntPtr)e7WK.Default / checked(num - num)) == 0)
					{
						_ = (b7KC)(object)e7WK.Default;
					}
				}
			}
			else
			{
				try
				{
					try
					{
						c8CP c8CP = c8CP;
						c8CP = c8CP;
					}
					finally
					{
						_ = (_003CModule_003E)(object)e7WK.Default;
						goto end_IL_0642;
					}
					end_IL_0642:;
				}
				catch
				{
					do
					{
						_ = (Yo50)(object)e7WK.Default;
					}
					while ((object)e7WK.Default != null);
				}
			}
			while (obj4 != null)
			{
				try
				{
					do
					{
						_ = (q1M)(object)e7WK.Default;
						_ = (q1M)(object)e7WK.Default;
					}
					while ((object)e7WK.Default != null);
				}
				catch
				{
					try
					{
						_ = (n0J5)(object)e7WK.Default;
					}
					finally
					{
						cx = (Cx7)(object)e7WK.Default;
						goto end_IL_06a4;
					}
					end_IL_06a4:;
				}
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out z0R3 z0R);
			do
			{
				nuint num4 = num;
				num = default(UIntPtr);
				if (num4 + num != 0)
				{
					try
					{
						_ = (b6G)e7WK.Default;
					}
					catch
					{
						_ = (c8CP)(object)e7WK.Default;
					}
					continue;
				}
				num = default(UIntPtr);
				if (num == 0)
				{
					b6G = default(b6G);
					continue;
				}
				z0R = z0R;
				z0R = z0R;
			}
			while (obj4 != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (o2T)(object)e7WK.Default;
				}
				catch
				{
					_ = (Pw9k)(object)e7WK.Default;
				}
			}
		}
		else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (q1M)(object)e7WK.Default;
				b6G = b6G;
				_ = (g2J4)(object)e7WK.Default;
				Yo50 yo = null;
				yo = yo;
			}
			while (obj4 != null);
		}
		else
		{
			do
			{
				_ = (So3)(object)e7WK.Default;
			}
			while ((object)e7WK.Default != null);
		}
		try
		{
			_ = (So3)(object)e7WK.Default;
		}
		finally
		{
			_ = (_003CModule_003E)(object)e7WK.Default;
			_ = (Qp49)(object)e7WK.Default;
			_ = (c8CP)(object)e7WK.Default;
			_ = (g2J4)(object)e7WK.Default;
			goto IL_0806;
		}
		IL_019d:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			fz = fz;
			fz = fz;
		}
		else
		{
			_ = (Qp49)(object)e7WK.Default;
		}
		_ = (Cx7)(object)e7WK.Default;
		try
		{
			e7WK = e7WK;
			e7WK = e7WK;
		}
		finally
		{
			_ = (o2T)(object)e7WK.Default;
			goto IL_01f4;
		}
		IL_0806:
		do
		{
			_ = (z8Y)(object)e7WK.Default;
		}
		while ((object)e7WK.Default != null);
		while ((object)e7WK.Default != null)
		{
			while ((object)e7WK.Default != null || obj4 != null)
			{
			}
		}
		try
		{
			try
			{
				_ = (z0R3)(object)e7WK.Default;
				_ = (Dx5s)(object)e7WK.Default;
			}
			finally
			{
				_ = (g2J4)(object)e7WK.Default;
				goto end_IL_0843;
			}
			end_IL_0843:;
		}
		catch
		{
			try
			{
				_ = (z8Y)(object)e7WK.Default;
			}
			finally
			{
				_ = e7WK.Default;
				goto end_IL_086b;
			}
			end_IL_086b:;
		}
		finally
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					Qp49 qp = (Qp49)(object)e7WK.Default;
				}
				while (obj4 != null);
			}
			goto IL_08ac;
		}
		IL_0314:
		num = default(UIntPtr);
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					Pw9k pw9k = (Pw9k)(object)e7WK.Default;
				}
				catch
				{
					qe = null;
				}
			}
		}
		else
		{
			do
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
				}
			}
			while (obj4 != null);
		}
		b6G = (b6G)e7WK.Default;
		while (obj4 != null)
		{
			try
			{
				while ((object)e7WK.Default != null)
				{
					_ = (Cx7)(object)e7WK.Default;
				}
			}
			finally
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = e7WK.Default;
				}
				continue;
			}
		}
		o2T = o2T;
		checked
		{
			try
			{
				num = default(UIntPtr);
				if (num + unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
				{
					try
					{
						_ = (b7KC)(object)e7WK.Default;
					}
					finally
					{
						_ = (o2T)(object)e7WK.Default;
						fz = (Fz0)e7WK.Default;
						_ = (Dx5s)(object)e7WK.Default;
						_ = (z8Y)(object)e7WK.Default;
						goto end_IL_03c3;
					}
				}
				num = default(UIntPtr);
				if (num == 0)
				{
				}
				end_IL_03c3:;
			}
			finally
			{
				try
				{
					try
					{
						_ = (Cx7)(object)e7WK.Default;
					}
					finally
					{
						_ = (g2J4)(object)e7WK.Default;
						goto end_IL_042f;
					}
					end_IL_042f:;
				}
				finally
				{
					try
					{
						_ = (Qt2)(object)e7WK.Default;
					}
					finally
					{
						_ = (b7KC)(object)e7WK.Default;
						o2T = null;
						goto IL_0470;
					}
				}
			}
		}
		IL_08ac:
		try
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out g2J4 g2J);
				while ((object)e7WK.Default != null)
				{
					_ = (b7KC)(object)e7WK.Default;
					_ = (q1M)(object)e7WK.Default;
					g2J = g2J;
					g2J = g2J;
					_ = (Yo50)(object)e7WK.Default;
				}
			}
			catch
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Pw9k)(object)e7WK.Default;
				}
			}
		}
		catch
		{
			do
			{
				_ = (z0R3)(object)e7WK.Default;
				cx = cx;
			}
			while (obj4 != null);
		}
	}

	static void Ys9e()
	{
		Dx5s dx5s = dx5s;
		dx5s = null;
		_ = (Fz0)e7WK.Default;
		_ = (Dx5s)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cx7 cx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c8CP c8CP);
		checked
		{
			num *= unchecked((nuint)(UIntPtr)e7WK.Default);
			num = default(UIntPtr);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out z0R3 z0R);
			if (num == 0)
			{
				num = default(UIntPtr);
				if (unchecked((nuint)default(UIntPtr)) * num == 0)
				{
					z0R3 obj = (z0R3)(object)e7WK.Default;
					z0R = null;
					z0R = obj;
					_ = (Qt2)(object)e7WK.Default;
					_ = (Yo50)(object)e7WK.Default;
				}
			}
			if (unchecked((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u))
			{
				y2HN y2HN = null;
				y2HN = y2HN;
			}
			try
			{
				try
				{
					while ((object)e7WK.Default != null)
					{
					}
				}
				catch
				{
					_ = e7WK.Default;
					_ = (Fz0)e7WK.Default;
					_ = (b7KC)(object)e7WK.Default;
				}
			}
			catch
			{
				do
				{
					num = default(UIntPtr);
					if (num != 0)
					{
						dx5s = null;
						continue;
					}
					c8CP = c8CP;
					c8CP = null;
				}
				while ((object)e7WK.Default != null);
			}
			while (true)
			{
				obj4 = obj4;
				if (obj4 == null)
				{
					break;
				}
				try
				{
					while ((object)e7WK.Default != null)
					{
						_ = (b7KC)(object)e7WK.Default;
					}
				}
				finally
				{
					try
					{
						dx5s = null;
					}
					catch
					{
						z0R = z0R;
						_ = (z8Y)(object)e7WK.Default;
					}
					continue;
				}
			}
			try
			{
				Fz0 fz = fz;
				fz = default(Fz0);
			}
			finally
			{
				if (num == 0)
				{
					try
					{
						_ = (b7KC)(object)e7WK.Default;
					}
					catch
					{
						_ = (_003CModule_003E)(object)e7WK.Default;
					}
				}
				else
				{
					num = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) * num * unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
					{
						cx = cx;
						cx = null;
					}
					else
					{
						_ = (Yo50)(object)e7WK.Default;
					}
				}
				goto IL_01e4;
			}
		}
		IL_048c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qt2 qt);
		try
		{
			Qe07 obj7 = (Qe07)(object)e7WK.Default;
			Qe07 qe = qe;
			qe = obj7;
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				qt = qt;
			}
		}
		try
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = (c8CP)(object)e7WK.Default;
				}
				else
				{
					_ = (n0J5)(object)e7WK.Default;
				}
			}
			finally
			{
				while (obj4 != null)
				{
					_ = (z8Y)(object)e7WK.Default;
				}
				goto end_IL_04c1;
			}
			end_IL_04c1:;
		}
		catch
		{
			Qe07 qe = (Qe07)(object)e7WK.Default;
		}
		do
		{
			nuint num2 = num;
			nuint num3 = num;
			num = default(UIntPtr);
			if (checked(num2 + num3 * num) != 0)
			{
				while (obj4 != null)
				{
					_ = (Qe07)(object)e7WK.Default;
				}
			}
			else
			{
				_ = (g2J4)(object)e7WK.Default;
			}
		}
		while (obj4 != null);
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					y2HN y2HN = (y2HN)(object)e7WK.Default;
				}
				catch
				{
					_ = (Qp49)(object)e7WK.Default;
				}
			}
			catch
			{
				_ = (g2J4)(object)e7WK.Default;
				_ = (g2J4)(object)e7WK.Default;
				g2J4 obj11 = (g2J4)(object)e7WK.Default;
				g2J4 g2J = g2J;
				g2J = obj11;
				g2J = g2J;
			}
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)e7WK.Default) + unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
				{
					dx5s = dx5s;
				}
				else
				{
					qt = null;
					_ = (z8Y)(object)e7WK.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out So3 so);
		try
		{
			while ((object)e7WK.Default != null)
			{
				nuint num4 = unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)e7WK.Default;
				UIntPtr num5 = (UIntPtr)e7WK.Default;
				UIntPtr num6 = (UIntPtr)e7WK.Default;
				num = default(UIntPtr);
				checked
				{
					if (num4 + (unchecked((nuint)num5) - unchecked((nuint)num6) * num - num) == 0)
					{
						_ = (Qp49)(object)e7WK.Default;
					}
					else
					{
						_ = (z8Y)(object)e7WK.Default;
					}
				}
			}
		}
		catch
		{
			so = so;
		}
		_ = (Qp49)(object)e7WK.Default;
		_ = (z0R3)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1M q1M);
		do
		{
			if ((nuint)(UIntPtr)e7WK.Default / (nuint)(UIntPtr)e7WK.Default != 0)
			{
				dx5s = (Dx5s)(object)e7WK.Default;
				continue;
			}
			try
			{
				g2J4 g2J = (g2J4)(object)e7WK.Default;
			}
			finally
			{
				q1M = q1M;
				continue;
			}
		}
		while ((object)e7WK.Default != null);
		Yo50 yo = yo;
		yo = yo;
		b6G b6G = default(b6G);
		while (true)
		{
			if (obj4 != null)
			{
				try
				{
					_ = (q1M)(object)e7WK.Default;
				}
				catch
				{
					_ = (Fz0)e7WK.Default;
				}
			}
			else if ((object)e7WK.Default == null)
			{
				break;
			}
		}
		while ((object)e7WK.Default != null)
		{
			dx5s = dx5s;
		}
		_ = (z8Y)(object)e7WK.Default;
		_ = (z8Y)(object)e7WK.Default;
		return;
		IL_0249:
		checked
		{
			try
			{
				try
				{
					try
					{
						_ = (z0R3)(object)e7WK.Default;
					}
					finally
					{
						_ = (Yo50)(object)e7WK.Default;
						goto end_IL_024b;
					}
					end_IL_024b:;
				}
				finally
				{
					if (num * (num + num) * (unchecked((nuint)(UIntPtr)e7WK.Default) + unchecked((nuint)(UIntPtr)e7WK.Default)) == 0)
					{
						q1M = q1M;
					}
					else
					{
						so = (So3)(object)e7WK.Default;
					}
					goto end_IL_024a;
				}
				end_IL_024a:;
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					if (num == 0)
					{
						_ = (Qt2)(object)e7WK.Default;
					}
					else
					{
						Pw9k pw9k = pw9k;
						pw9k = pw9k;
					}
				}
			}
			do
			{
				if (unchecked((nuint)(UIntPtr)e7WK.Default) - unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
				{
					_ = (o2T)(object)e7WK.Default;
				}
			}
			while (obj4 != null);
			while (obj4 != null)
			{
				try
				{
					_ = e7WK.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
					continue;
				}
			}
			cx = cx;
			_ = (g2J4)(object)e7WK.Default;
			z8Y z8Y = z8Y;
			z8Y = z8Y;
			_ = (z0R3)(object)e7WK.Default;
			while ((object)e7WK.Default != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					do
					{
						_ = (c8CP)(object)e7WK.Default;
						_ = (q1M)(object)e7WK.Default;
						Fz0 fz = (Fz0)e7WK.Default;
					}
					while ((object)e7WK.Default != null);
				}
				else if (unchecked((nuint)(UIntPtr)e7WK.Default) + unchecked((nuint)(UIntPtr)e7WK.Default) * num == 0)
				{
					_ = (Qp49)(object)e7WK.Default;
				}
				else
				{
					_ = (Fz0)e7WK.Default;
				}
			}
			try
			{
				do
				{
					c8CP = c8CP;
					_ = (c8CP)(object)e7WK.Default;
					_ = (q1M)(object)e7WK.Default;
				}
				while (obj4 != null);
			}
			catch
			{
				try
				{
					b7KC b7KC = b7KC;
					b7KC = b7KC;
				}
				finally
				{
					do
					{
						_ = (c8CP)(object)e7WK.Default;
					}
					while (obj4 != null);
					goto end_IL_040b;
				}
				end_IL_040b:;
			}
			while (true)
			{
				if (obj4 != null)
				{
					if (num == 0)
					{
						_ = (c8CP)(object)e7WK.Default;
					}
				}
				else if (obj4 == null)
				{
					break;
				}
			}
			try
			{
				_ = (q1M)(object)e7WK.Default;
			}
			finally
			{
				if (num == 0)
				{
					_ = (Qp49)(object)e7WK.Default;
					cx = (Cx7)(object)e7WK.Default;
					c8CP = c8CP;
				}
				goto IL_048c;
			}
		}
		IL_01e4:
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				qt = qt;
				qt = qt;
			}
			goto IL_0249;
		}
		try
		{
			_ = (n0J5)(object)e7WK.Default;
		}
		finally
		{
			try
			{
				qt = null;
				so = so;
				so = null;
			}
			finally
			{
				q1M = q1M;
				q1M = q1M;
				goto IL_0249;
			}
		}
	}

	static void Tx9n()
	{
		_ = (o2T)(object)e7WK.Default;
		UIntPtr num = (UIntPtr)e7WK.Default;
		UIntPtr uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		So3 so;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e7WK e7WK);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c8CP c8CP);
		checked
		{
			if (unchecked((nuint)num) * uIntPtr == 0)
			{
				_ = (Yo50)(object)e7WK.Default;
			}
			else if (unchecked((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u))
			{
				nuint num2 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num3 = num2 + uIntPtr;
				nuint num4 = uIntPtr;
				uIntPtr = default(UIntPtr);
				nuint num5;
				unchecked
				{
					num5 = num3 / checked(num4 * uIntPtr) / uIntPtr;
					uIntPtr = default(UIntPtr);
				}
				if (unchecked(num5 / uIntPtr) * uIntPtr == 0)
				{
					_ = (Pw9k)(object)e7WK.Default;
				}
				else
				{
					_ = (Cx7)(object)e7WK.Default;
				}
			}
			else
			{
				while ((object)e7WK.Default != null)
				{
					_ = (Cx7)(object)e7WK.Default;
				}
			}
			while ((object)e7WK.Default != null)
			{
				try
				{
					_ = (q1M)(object)e7WK.Default;
					c8CP = c8CP;
					c8CP = c8CP;
					_ = (q1M)(object)e7WK.Default;
				}
				finally
				{
					_003CModule_003E = (_003CModule_003E)(object)e7WK.Default;
					_003CModule_003E = null;
					obj = null;
					continue;
				}
			}
			do
			{
				_ = (n0J5)(object)e7WK.Default;
				e7WK = e7WK;
				e7WK = e7WK;
				_ = (b7KC)(object)e7WK.Default;
			}
			while (obj != null);
			so = null;
			so = so;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g2J4 g2J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fz0 fz);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1M q1M);
		try
		{
			do
			{
				try
				{
					g2J4 obj2 = (g2J4)(object)e7WK.Default;
					g2J = g2J;
					g2J = obj2;
				}
				catch
				{
					_ = (Fz0)e7WK.Default;
				}
			}
			while (obj != null);
		}
		catch
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					fz = fz;
					fz = fz;
					q1M = null;
					q1M = null;
					_ = (Cx7)(object)e7WK.Default;
				}
				finally
				{
					_ = (Qt2)(object)e7WK.Default;
					goto end_IL_016d;
				}
			}
			_ = (Qe07)(object)e7WK.Default;
			end_IL_016d:;
		}
		_ = (n0J5)(object)e7WK.Default;
		try
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (Qe07)(object)e7WK.Default;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		finally
		{
			while ((object)e7WK.Default != null)
			{
				try
				{
					_ = (Fz0)e7WK.Default;
				}
				catch
				{
					_ = (b6G)e7WK.Default;
				}
			}
			goto IL_021a;
		}
		IL_0410:
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked(uIntPtr / uIntPtr) * unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
			{
				do
				{
					_003CModule_003E = null;
				}
				while (obj != null);
			}
			so = (So3)(object)e7WK.Default;
			_ = (_003CModule_003E)(object)e7WK.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b7KC b7KC);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6G b6G);
		try
		{
			while ((object)e7WK.Default != null)
			{
			}
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / uIntPtr == 0)
				{
					b6G = b6G;
				}
				else
				{
					_ = (Pw9k)(object)e7WK.Default;
				}
			}
			else
			{
				while ((object)e7WK.Default != null)
				{
					b7KC obj6 = (b7KC)(object)e7WK.Default;
					b7KC = null;
					b7KC = obj6;
				}
			}
		}
		UIntPtr num6 = (UIntPtr)e7WK.Default;
		uIntPtr = default(UIntPtr);
		if ((nuint)num6 / uIntPtr == 0)
		{
			checked
			{
				try
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr + unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
					{
						_003CModule_003E = _003CModule_003E;
					}
					else
					{
						_ = (b6G)e7WK.Default;
					}
				}
				catch
				{
					try
					{
						_ = (y2HN)(object)e7WK.Default;
					}
					catch
					{
						_ = (b6G)e7WK.Default;
					}
				}
			}
		}
		try
		{
			_ = (Dx5s)(object)e7WK.Default;
			_ = (n0J5)(object)e7WK.Default;
			_ = (Yo50)(object)e7WK.Default;
			o2T o2T = null;
			o2T = o2T;
		}
		catch
		{
			fz = fz;
		}
		try
		{
			if (uIntPtr == 0)
			{
				_ = (b6G)e7WK.Default;
			}
		}
		finally
		{
			_ = e7WK.Default;
			goto IL_058e;
		}
		IL_02fa:
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (c8CP)(object)e7WK.Default;
				_ = (z8Y)(object)e7WK.Default;
				_ = (z8Y)(object)e7WK.Default;
			}
			catch
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					z0R3 z0R = z0R;
					z0R = null;
				}
			}
		}
		try
		{
			_ = (q1M)(object)e7WK.Default;
		}
		finally
		{
			_ = (Cx7)(object)e7WK.Default;
			goto IL_035e;
		}
		IL_058e:
		fz = default(Fz0);
		while (obj != null)
		{
			try
			{
				while ((object)e7WK.Default != null)
				{
					fz = fz;
				}
			}
			finally
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Qp49)(object)e7WK.Default;
				}
				continue;
			}
		}
		while ((object)e7WK.Default != null)
		{
		}
		_ = (So3)(object)e7WK.Default;
		so = (So3)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Yo50 yo);
		try
		{
			do
			{
				try
				{
					b6G = b6G;
				}
				finally
				{
					_ = (Fz0)e7WK.Default;
					g2J = g2J;
					_ = (q1M)(object)e7WK.Default;
					continue;
				}
			}
			while (obj != null);
		}
		catch
		{
			try
			{
				do
				{
					_ = (b7KC)(object)e7WK.Default;
					_ = (Qp49)(object)e7WK.Default;
					_ = (Qe07)(object)e7WK.Default;
				}
				while ((object)e7WK.Default != null);
			}
			finally
			{
				try
				{
					_ = (z8Y)(object)e7WK.Default;
				}
				finally
				{
					b7KC = b7KC;
					_ = (Pw9k)(object)e7WK.Default;
					_ = (Pw9k)(object)e7WK.Default;
					yo = null;
					goto end_IL_0637;
				}
			}
			end_IL_0637:;
		}
		try
		{
			e7WK = e7WK;
			_ = (Qe07)(object)e7WK.Default;
			_ = (z0R3)(object)e7WK.Default;
		}
		catch
		{
			n0J5 obj13 = (n0J5)(object)e7WK.Default;
			n0J5 n0J = n0J;
			n0J = obj13;
		}
		Dx5s dx5s;
		try
		{
			try
			{
				c8CP = (c8CP)(object)e7WK.Default;
				dx5s = dx5s;
				b6G = b6G;
				c8CP = c8CP;
				return;
			}
			catch
			{
				_ = (So3)(object)e7WK.Default;
				return;
			}
		}
		catch
		{
			while (obj != null)
			{
				yo = yo;
			}
			return;
		}
		finally
		{
			_ = (y2HN)(object)e7WK.Default;
			return;
		}
		IL_021a:
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				yo = null;
				yo = yo;
			}
		}
		catch
		{
			do
			{
				_ = (g2J4)(object)e7WK.Default;
			}
			while (obj != null);
		}
		Qt2 qt = qt;
		qt = qt;
		_ = (o2T)(object)e7WK.Default;
		Dx5s obj18 = (Dx5s)(object)e7WK.Default;
		dx5s = (Dx5s)(object)e7WK.Default;
		dx5s = obj18;
		try
		{
			try
			{
				_ = (So3)(object)e7WK.Default;
			}
			catch
			{
				_ = (Qe07)(object)e7WK.Default;
			}
			finally
			{
				try
				{
					qt = qt;
				}
				finally
				{
					_ = (c8CP)(object)e7WK.Default;
					goto end_IL_0285;
				}
			}
			end_IL_0285:;
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out y2HN y2HN);
			while ((object)e7WK.Default != null)
			{
				try
				{
					y2HN = y2HN;
					y2HN = y2HN;
					_ = (Cx7)(object)e7WK.Default;
				}
				catch
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			goto IL_02fa;
		}
		IL_035e:
		try
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (q1M)(object)e7WK.Default;
				}
			}
			finally
			{
				try
				{
					_ = (b7KC)(object)e7WK.Default;
					_ = (q1M)(object)e7WK.Default;
				}
				finally
				{
					_ = e7WK.Default;
					goto end_IL_035f;
				}
			}
			end_IL_035f:;
		}
		catch
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)e7WK.Default) * unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
				{
					try
					{
						_ = (o2T)(object)e7WK.Default;
					}
					finally
					{
						q1M = q1M;
						goto end_IL_039d;
					}
				}
			}
			end_IL_039d:;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Dx5s)(object)e7WK.Default;
				_ = (Qe07)(object)e7WK.Default;
				b6G = b6G;
				b6G = b6G;
				c8CP = c8CP;
			}
			finally
			{
				goto IL_0410;
			}
		}
		goto IL_0410;
	}
}
