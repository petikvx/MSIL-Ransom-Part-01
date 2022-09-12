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
using Cd2;
using Dn57;
using Fg5p;
using Jr8;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Ps92;
using Xr2;
using b1C5;
using j8P3;
using k6J;
using n0WD;
using n7K;
using o1N;
using o9R;
using y8D;

namespace n4M;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class a1B
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class a5B
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Em1 m_frmBilling;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sm6 m_frmBillingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jy1 m_frmMain;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b6E m_frmProcessingCost;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y8R m_frmProcessingDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qg6 m_frmProductDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public i0A1 m_frmPurchaseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public s9EJ m_frmSalesDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ln53 m_frmSupplierDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nn9a m_frmTransportDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Nm2f m_frmWarehouseDetail;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b1YL m_Login;

		public Em1 frmBilling
		{
			[DebuggerHidden]
			get
			{
				m_frmBilling = Pg5(m_frmBilling);
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
					Dt5(ref m_frmBilling);
				}
			}
		}

		public Sm6 frmBillingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmBillingDetail = Pg5(m_frmBillingDetail);
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
					Dt5(ref m_frmBillingDetail);
				}
			}
		}

		public Jy1 frmMain
		{
			[DebuggerHidden]
			get
			{
				m_frmMain = Pg5(m_frmMain);
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
					Dt5(ref m_frmMain);
				}
			}
		}

		public b6E frmProcessingCost
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingCost = Pg5(m_frmProcessingCost);
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
					Dt5(ref m_frmProcessingCost);
				}
			}
		}

		public y8R frmProcessingDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProcessingDetail = Pg5(m_frmProcessingDetail);
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
					Dt5(ref m_frmProcessingDetail);
				}
			}
		}

		public Qg6 frmProductDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmProductDetail = Pg5(m_frmProductDetail);
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
					Dt5(ref m_frmProductDetail);
				}
			}
		}

		public i0A1 frmPurchaseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmPurchaseDetail = Pg5(m_frmPurchaseDetail);
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
					Dt5(ref m_frmPurchaseDetail);
				}
			}
		}

		public s9EJ frmSalesDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSalesDetail = Pg5(m_frmSalesDetail);
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
					Dt5(ref m_frmSalesDetail);
				}
			}
		}

		public Ln53 frmSupplierDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmSupplierDetail = Pg5(m_frmSupplierDetail);
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
					Dt5(ref m_frmSupplierDetail);
				}
			}
		}

		public Nn9a frmTransportDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmTransportDetail = Pg5(m_frmTransportDetail);
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
					Dt5(ref m_frmTransportDetail);
				}
			}
		}

		public Nm2f frmWarehouseDetail
		{
			[DebuggerHidden]
			get
			{
				m_frmWarehouseDetail = Pg5(m_frmWarehouseDetail);
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
					Dt5(ref m_frmWarehouseDetail);
				}
			}
		}

		public b1YL Login
		{
			[DebuggerHidden]
			get
			{
				m_Login = Pg5(m_Login);
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
					Dt5(ref m_Login);
				}
			}
		}

		[DebuggerHidden]
		private static Yp6 Pg5<Yp6>(Yp6 Kr5) where Yp6 : Form, new()
		{
			if (Kr5 == null || ((Control)Kr5).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Yp6)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Yp6), null);
				try
				{
					return new Yp6();
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
					m_FormBeingCreated.Remove(typeof(Yp6));
				}
			}
			return Kr5;
		}

		[DebuggerHidden]
		private void Dt5<t8Y>(ref t8Y Ba3) where t8Y : Form
		{
			((Component)Ba3).Dispose();
			Ba3 = default(t8Y);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public a5B()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool d5Y(object m0A)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(m0A));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int y8X()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type t7H()
		{
			return typeof(a5B);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string g0D()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Jb3
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Ms2(object z2Z)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(z2Z));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int z9S()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type d6T()
		{
			return typeof(Jb3);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Gy9()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static p7P Cm6<p7P>(p7P Sn8) where p7P : new()
		{
			if (Sn8 == null)
			{
				return new p7P();
			}
			return Sn8;
		}

		[DebuggerHidden]
		private void Hi7<z9R>(ref z9R d3R)
		{
			d3R = default(z9R);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Jb3()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Do9<z7F> where z7F : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static z7F m_ThreadStaticValue;

		internal z7F GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new z7F();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Do9()
		{
		}
	}

	private static readonly Do9<En1> m_ComputerObjectProvider = new Do9<En1>();

	private static readonly Do9<j3J> m_AppObjectProvider = new Do9<j3J>();

	private static readonly Do9<User> m_UserObjectProvider = new Do9<User>();

	private static Do9<a5B> m_MyFormsObjectProvider = new Do9<a5B>();

	private static readonly Do9<Jb3> m_MyWebServicesObjectProvider = new Do9<Jb3>();

	[HelpKeyword("My.Computer")]
	internal static En1 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static j3J Application
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
	internal static a5B Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Jb3 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
