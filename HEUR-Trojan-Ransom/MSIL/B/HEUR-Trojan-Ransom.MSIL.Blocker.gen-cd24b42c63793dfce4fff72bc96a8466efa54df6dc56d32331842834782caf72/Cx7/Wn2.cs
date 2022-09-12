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
using Ax2;
using Bb3;
using Fz5;
using Hf5i;
using Lc3;
using Mf0;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Pc8;
using Rg9;
using Sk9;
using Wi0;
using Xs3;
using c7R0;
using e3F;
using g0G;
using m8T;
using p6H;
using p9B1;
using t2P;

namespace Cx7;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Wn2
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Rx9
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public f6Y m_frmBilling;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Cs3 m_frmBillingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i3F m_frmMain;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bj2 m_frmProcessingCost;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d3R m_frmProcessingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Aw7 m_frmProductDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Pr5 m_frmPurchaseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g7A m_frmSalesDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public q9X m_frmSupplierDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public k3NH m_frmTransportDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b4C0 m_frmWarehouseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fw02 m_Login;

		public f6Y frmBilling
		{
			[DebuggerHidden]
			get
			{
				m_frmBilling = j6K(m_frmBilling);
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
					Qq0(ref m_frmBilling);
				}
			}
		}

		public Cs3 frmBillingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmBillingDetail = j6K(m_frmBillingDetail);
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
					Qq0(ref m_frmBillingDetail);
				}
			}
		}

		public i3F frmMain
		{
			[DebuggerHidden]
			get
			{
				m_frmMain = j6K(m_frmMain);
				return m_frmMain;
			}
			[DebuggerHidden]
			set
			{
				bool num = value == m_frmMain;
				b4C0.char_0[314] = (char)((b4C0.char_0[314] + b4C0.char_0[336]) & 'b');
				if (!num)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Qq0(ref m_frmMain);
				}
			}
		}

		public Bj2 frmProcessingCost
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingCost = j6K(m_frmProcessingCost);
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
					Qq0(ref m_frmProcessingCost);
				}
			}
		}

		public d3R frmProcessingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingDetail = j6K(m_frmProcessingDetail);
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
					Qq0(ref m_frmProcessingDetail);
					Pr5.byte_0[195] = (byte)((Pr5.byte_0[195] + Pr5.byte_0[240]) & 0x4B);
				}
			}
		}

		public Aw7 frmProductDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProductDetail = j6K(m_frmProductDetail);
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
					Qq0(ref m_frmProductDetail);
					b4C0.char_0[308] = (char)((b4C0.char_0[308] * b4C0.char_0[501]) & '\u001b');
				}
			}
		}

		public Pr5 frmPurchaseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmPurchaseDetail = j6K(m_frmPurchaseDetail);
				return m_frmPurchaseDetail;
			}
			[DebuggerHidden]
			set
			{
				byte[] byte_ = Pr5.byte_0;
				int num = 2;
				while (true)
				{
					if (value != m_frmPurchaseDetail)
					{
						byte num2 = byte_[460];
						byte num3 = byte_[28];
						b4C0.char_0[564] = (char)((b4C0.char_0[564] | b4C0.char_0[613]) & '÷');
						switch (num2 - num3)
						{
						default:
							continue;
						case 0:
							if (value != null)
							{
								num = 1;
								goto case 1;
							}
							num = 8;
							goto case 8;
						case 1:
						case 3:
						case 5:
							throw new ArgumentException("Property can only be set to Nothing");
						case 7:
							break;
						case 8:
							Qq0(ref m_frmPurchaseDetail);
							return;
						case 4:
							return;
						}
					}
					else
					{
						num = 7;
					}
					break;
				}
				num = 4;
			}
		}

		public g7A frmSalesDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSalesDetail = j6K(m_frmSalesDetail);
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
					Qq0(ref m_frmSalesDetail);
				}
			}
		}

		public q9X frmSupplierDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSupplierDetail = j6K(m_frmSupplierDetail);
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
					Qq0(ref m_frmSupplierDetail);
				}
			}
		}

		public k3NH frmTransportDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmTransportDetail = j6K(m_frmTransportDetail);
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
					Qq0(ref m_frmTransportDetail);
				}
			}
		}

		public b4C0 frmWarehouseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmWarehouseDetail = j6K(m_frmWarehouseDetail);
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
					Qq0(ref m_frmWarehouseDetail);
				}
			}
		}

		public Fw02 Login
		{
			[DebuggerHidden]
			get
			{
				m_Login = j6K(m_Login);
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
					Qq0(ref m_Login);
				}
			}
		}

		[DebuggerHidden]
		private static f0Q j6K<f0Q>(f0Q p9Y) where f0Q : Form, new()
		{
			byte[] byte_ = Pr5.byte_0;
			int num = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out TargetInvocationException obj2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			TargetInvocationException ex = default(TargetInvocationException);
			while (true)
			{
				IL_00b1:
				if (p9Y == null)
				{
					num = 5;
					goto IL_0017;
				}
				num = 4;
				goto IL_0092;
				IL_0017:
				while (true)
				{
					num = 3;
					while (true)
					{
						IL_0086:
						if (m_FormBeingCreated != null)
						{
							num = 8;
							while (true)
							{
								IL_006f:
								bool flag = m_FormBeingCreated.ContainsKey(typeof(f0Q));
								while (true)
								{
									if (flag)
									{
										switch (byte_[498] + byte_[37])
										{
										case 5:
											break;
										case 6:
											continue;
										case 8:
											goto IL_006f;
										case 3:
											goto IL_0086;
										case 4:
											goto end_IL_0017;
										default:
											goto IL_00b1;
										case 10:
											throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
										case 7:
										case 9:
											goto IL_00d7;
										case 2:
											goto IL_00df;
										case 1:
										case 11:
											goto IL_00ec;
										}
										break;
									}
									num = 7;
									goto IL_00d7;
									IL_00d7:
									num = 1;
									goto IL_00ec;
								}
								break;
							}
							break;
						}
						num = 2;
						goto IL_00df;
						IL_00df:
						m_FormBeingCreated = new Hashtable();
						num = 1;
						goto IL_00ec;
						IL_00ec:
						m_FormBeingCreated.Add(typeof(f0Q), null);
						try
						{
							return new f0Q();
						}
						catch (object obj) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj2 = obj as TargetInvocationException;
							Pr5.byte_0[383] = (byte)((Pr5.byte_0[383] | Pr5.byte_0[346]) & 0x18);
							if (obj2 == null)
							{
								result = 0;
							}
							else
							{
								ProjectData.SetProjectError((Exception)obj2);
								ex = obj2;
								result = ((ex.InnerException != null) ? 1 : 0);
							}
							return (byte)result != 0;
						}).Invoke())
						{
							string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message });
							throw new InvalidOperationException(resourceString, ex.InnerException);
						}
						finally
						{
							m_FormBeingCreated.Remove(typeof(f0Q));
						}
					}
					continue;
					end_IL_0017:
					break;
				}
				goto IL_0092;
				IL_0092:
				if (!((Control)p9Y).get_IsDisposed())
				{
					break;
				}
				goto IL_0017;
			}
			return p9Y;
		}

		[DebuggerHidden]
		private void Qq0<Dx9>(ref Dx9 Fk8) where Dx9 : Form
		{
			((Component)Fk8).Dispose();
			Fk8 = default(Dx9);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Rx9()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Pd4(object z2C)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(z2C));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int d8S()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type g5D()
		{
			return typeof(Rx9);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string o4H()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class i8Y
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Ni7(object w8E)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(w8E));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int c4M()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type r8L()
		{
			return typeof(i8Y);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Sy5()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Ys8 w2Z<Ys8>(Ys8 t8H) where Ys8 : new()
		{
			bool num = t8H == null;
			b4C0.char_0[249] = (char)((b4C0.char_0[249] | b4C0.char_0[421]) & 'ë');
			if (num)
			{
				return new Ys8();
			}
			return t8H;
		}

		[DebuggerHidden]
		private void Rf5<En6>(ref En6 Zg0)
		{
			Zg0 = default(En6);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public i8Y()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class f5K<Ft9> where Ft9 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Ft9 m_ThreadStaticValue;

		internal Ft9 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Ft9();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public f5K()
		{
		}
	}

	private static readonly f5K<Ca4> m_ComputerObjectProvider = new f5K<Ca4>();

	private static readonly f5K<So3> m_AppObjectProvider = new f5K<So3>();

	private static readonly f5K<User> m_UserObjectProvider = new f5K<User>();

	private static f5K<Rx9> m_MyFormsObjectProvider = new f5K<Rx9>();

	private static readonly f5K<i8Y> m_MyWebServicesObjectProvider = new f5K<i8Y>();

	[HelpKeyword("My.Computer")]
	internal static Ca4 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static So3 Application
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
	internal static Rx9 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static i8Y WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}

	static void r9X()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q9X q9X);
		while ((object)j7W.Default != null)
		{
			try
			{
				_ = (Lp5)(object)j7W.Default;
			}
			catch
			{
				uIntPtr = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					q9X obj = (q9X)(object)j7W.Default;
					q9X = q9X;
					q9X = obj;
				}
				else
				{
					_ = (Pr5)(object)j7W.Default;
				}
			}
		}
		object obj3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cs3 cs);
		while (true)
		{
			obj3 = j7W.Default;
			if (obj3 == null)
			{
				break;
			}
			_ = (k3NH)(object)j7W.Default;
			_ = (We5)j7W.Default;
			_ = (We5)j7W.Default;
			cs = cs;
			cs = null;
			_ = (Aw7)(object)j7W.Default;
		}
		_ = (We5)j7W.Default;
		_ = (_003CModule_003E)(object)j7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fw02 fw);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bj2 bj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f6Y f6Y);
		checked
		{
			while ((object)j7W.Default != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr + uIntPtr != 0)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr * uIntPtr == 0)
					{
						fw = fw;
						fw = fw;
					}
				}
			}
			try
			{
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr * unchecked((nuint)(UIntPtr)j7W.Default) == 0)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr * uIntPtr == 0)
					{
						_ = (Ca4)(object)j7W.Default;
					}
					goto IL_017b;
				}
				try
				{
					f6Y = f6Y;
					f6Y = f6Y;
				}
				finally
				{
					bj = bj;
					bj = null;
					goto IL_017b;
				}
			}
		}
		IL_04de:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b4C0 b4C);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j7W j7W);
		try
		{
			while (true)
			{
				if (obj3 != null)
				{
					So3 so = (So3)(object)j7W.Default;
				}
				else if (obj3 == null)
				{
					break;
				}
			}
			return;
		}
		finally
		{
			try
			{
				try
				{
					_ = (Wn2)(object)j7W.Default;
					return;
				}
				finally
				{
					j7W = j7W;
					return;
				}
			}
			finally
			{
				b4C = null;
				Lp5 obj4 = (Lp5)(object)j7W.Default;
				Lp5 lp = lp;
				lp = obj4;
				_ = (b4C0)(object)j7W.Default;
				return;
			}
		}
		IL_017b:
		try
		{
			while ((object)j7W.Default != null)
			{
				bj = bj;
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (f0Q)j7W.Default;
				}
				else
				{
					fw = fw;
				}
			}
			goto IL_01ce;
		}
		IL_01ce:
		do
		{
			b4C0 obj5 = (b4C0)(object)j7W.Default;
			b4C = b4C;
			b4C = obj5;
		}
		while ((object)j7W.Default != null || (object)j7W.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i3F i3F);
		while (obj3 != null)
		{
			do
			{
				try
				{
					b4C = (b4C0)(object)j7W.Default;
				}
				finally
				{
					_ = (i3F)(object)j7W.Default;
					j7W = j7W.Default;
					j7W = null;
					i3F = i3F;
					i3F = i3F;
					continue;
				}
			}
			while (obj3 != null);
		}
		try
		{
			_ = (So3)(object)j7W.Default;
		}
		finally
		{
			f0Q obj6 = (f0Q)j7W.Default;
			f0Q f0Q = f0Q;
			f0Q = obj6;
			_ = j7W.Default;
			_ = (So3)(object)j7W.Default;
			_ = (_003CModule_003E)(object)j7W.Default;
			goto IL_0288;
		}
		IL_0288:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wn2 wn);
		try
		{
			try
			{
				wn = wn;
				wn = wn;
			}
			finally
			{
				_ = (Ca4)(object)j7W.Default;
				goto end_IL_0289;
			}
			end_IL_0289:;
		}
		catch
		{
			do
			{
				if (uIntPtr != 0)
				{
					So3 so = (So3)(object)j7W.Default;
					so = so;
				}
				else
				{
					_ = (f6Y)(object)j7W.Default;
				}
			}
			while (obj3 != null);
		}
		try
		{
			while (obj3 != null)
			{
				try
				{
					_ = (Ca4)(object)j7W.Default;
				}
				catch
				{
					_ = (g7A)(object)j7W.Default;
					_ = (f0Q)j7W.Default;
				}
			}
		}
		catch
		{
			do
			{
				fw = fw;
			}
			while (obj3 != null || obj3 != null);
		}
		uIntPtr = default(UIntPtr);
		nuint num = uIntPtr;
		nuint num2 = uIntPtr;
		nuint num10;
		checked
		{
			nuint num3 = (unchecked((nuint)(UIntPtr)j7W.Default / uIntPtr) * unchecked((nuint)(UIntPtr)j7W.Default) + uIntPtr) * (uIntPtr - unchecked(uIntPtr / uIntPtr) - unchecked((nuint)(UIntPtr)j7W.Default) - uIntPtr);
			uIntPtr = default(UIntPtr);
			UIntPtr num4 = uIntPtr;
			UIntPtr num5 = uIntPtr;
			UIntPtr num6 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num - (num2 - (num3 - unchecked((nuint)num4 / (checked(unchecked((nuint)num5) * (unchecked((nuint)num6) + uIntPtr)) / (nuint)(UIntPtr)j7W.Default)))) == 0)
			{
				uIntPtr = default(UIntPtr);
				UIntPtr num7 = uIntPtr;
				UIntPtr num8 = uIntPtr;
				uIntPtr = default(UIntPtr);
				unchecked
				{
					if ((nuint)num7 / checked(unchecked((nuint)num8) + uIntPtr * uIntPtr) == 0)
					{
						_ = (q9X)(object)j7W.Default;
					}
				}
			}
			else
			{
				g7A g7A = (g7A)(object)j7W.Default;
				g7A = g7A;
			}
			while ((object)j7W.Default != null)
			{
				_ = (d3R)(object)j7W.Default;
			}
			nuint num9 = unchecked(uIntPtr / uIntPtr / uIntPtr) - (uIntPtr + unchecked((nuint)default(UIntPtr)));
			uIntPtr = default(UIntPtr);
			num10 = num9 - uIntPtr + uIntPtr + (unchecked((nuint)default(UIntPtr)) + unchecked((nuint)default(UIntPtr)));
			uIntPtr = default(UIntPtr);
		}
		if (num10 / checked(uIntPtr * uIntPtr) == 0)
		{
			try
			{
				_ = (i3F)(object)j7W.Default;
				_ = (Bj2)(object)j7W.Default;
				q9X = null;
			}
			finally
			{
				try
				{
					wn = wn;
				}
				catch
				{
					f6Y = f6Y;
				}
				goto IL_04de;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k3NH k3NH);
		do
		{
			try
			{
				bj = bj;
			}
			catch
			{
				k3NH obj11 = (k3NH)(object)j7W.Default;
				k3NH = k3NH;
				k3NH = obj11;
			}
		}
		while (obj3 != null);
		goto IL_04de;
	}
}
