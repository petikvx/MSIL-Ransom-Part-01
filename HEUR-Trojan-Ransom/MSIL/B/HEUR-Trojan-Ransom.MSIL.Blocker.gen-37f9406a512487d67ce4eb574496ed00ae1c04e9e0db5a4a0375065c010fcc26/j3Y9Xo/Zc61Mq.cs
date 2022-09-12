using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bn86Yd;
using Da45Sz;
using Hj7k5K;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Sq4;
using c2QGt9;
using s4FCc7;
using w2L;
using x8N;

namespace j3Y9Xo;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Zc61Mq
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class g7LZz2
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ks1d0E m_frmNewsPaperRecord;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public a7N8Mb m_frmNewsPaperRecord1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Gz1t7F m_frmNoDues;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hd3 m_frmPasswordRecovery;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public w6A m_frmProject;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zd7 m_frmProjectRecord;

		private static w0MQz2 f3LEa2<w0MQz2>(w0MQz2 Bq5x1Y) where w0MQz2 : Form, new()
		{
			if (Bq5x1Y == null || ((Control)Bq5x1Y).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(w0MQz2)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(w0MQz2), null);
				try
				{
					return new w0MQz2();
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
					m_FormBeingCreated.Remove(typeof(w0MQz2));
				}
			}
			return Bq5x1Y;
		}

		private void z8X2Mk<m1C4Qb>(ref m1C4Qb Bg5d0M) where m1C4Qb : Form
		{
			((Component)Bg5d0M).Dispose();
			Bg5d0M = default(m1C4Qb);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public g7LZz2()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool r1Q2Ws(object Pb73Gn)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Pb73Gn));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Dk03Gi()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type b5YZx0()
		{
			return typeof(g7LZz2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string z3N4Si()
		{
			return base.ToString();
		}

		[SpecialName]
		public Ks1d0E n8NGj6()
		{
			m_frmNewsPaperRecord = f3LEa2(m_frmNewsPaperRecord);
			return m_frmNewsPaperRecord;
		}

		[SpecialName]
		public a7N8Mb p6QDa3()
		{
			m_frmNewsPaperRecord1 = f3LEa2(m_frmNewsPaperRecord1);
			return m_frmNewsPaperRecord1;
		}

		[SpecialName]
		public Gz1t7F r6S7Be()
		{
			m_frmNoDues = f3LEa2(m_frmNoDues);
			return m_frmNoDues;
		}

		[SpecialName]
		public Hd3 Rt5f9G()
		{
			m_frmPasswordRecovery = f3LEa2(m_frmPasswordRecovery);
			return m_frmPasswordRecovery;
		}

		[SpecialName]
		public w6A z9Q2Nk()
		{
			m_frmProject = f3LEa2(m_frmProject);
			return m_frmProject;
		}

		[SpecialName]
		public Zd7 e7SKq8()
		{
			m_frmProjectRecord = f3LEa2(m_frmProjectRecord);
			return m_frmProjectRecord;
		}

		[SpecialName]
		public void Si51Jf(Ks1d0E y3QKj1)
		{
			if (y3QKj1 != m_frmNewsPaperRecord)
			{
				if (y3QKj1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z8X2Mk(ref m_frmNewsPaperRecord);
			}
		}

		[SpecialName]
		public void o5BEs7(a7N8Mb Dt7q8P)
		{
			if (Dt7q8P != m_frmNewsPaperRecord1)
			{
				if (Dt7q8P != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z8X2Mk(ref m_frmNewsPaperRecord1);
			}
		}

		[SpecialName]
		public void x3ZAa8(Gz1t7F y1Q6Ej)
		{
			if (y1Q6Ej != m_frmNoDues)
			{
				if (y1Q6Ej != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z8X2Mk(ref m_frmNoDues);
			}
		}

		[SpecialName]
		public void Ej73Bx(Hd3 Zb2p1R)
		{
			if (Zb2p1R != m_frmPasswordRecovery)
			{
				if (Zb2p1R != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z8X2Mk(ref m_frmPasswordRecovery);
			}
		}

		[SpecialName]
		public void p9A7Mj(w6A Rs58Qe)
		{
			if (Rs58Qe != m_frmProject)
			{
				if (Rs58Qe != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z8X2Mk(ref m_frmProject);
			}
		}

		[SpecialName]
		public void g2ABa6(Zd7 So31Qm)
		{
			if (So31Qm != m_frmProjectRecord)
			{
				if (So31Qm != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				z8X2Mk(ref m_frmProjectRecord);
			}
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Tp2s3H
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Jf8i2P(object Wd65Em)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Wd65Em));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int e5L2Dw()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type c5EBx1()
		{
			return typeof(Tp2s3H);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string g3S7Yz()
		{
			return base.ToString();
		}

		private static Eb1r2N i9Z5Ln<Eb1r2N>(Eb1r2N Mp6m3H) where Eb1r2N : new()
		{
			if (Mp6m3H == null)
			{
				return new Eb1r2N();
			}
			return Mp6m3H;
		}

		private void y2BZb6<x9Y8Hd>(ref x9Y8Hd e5G1Pa)
		{
			e5G1Pa = default(x9Y8Hd);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tp2s3H()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Jb35Af<z5R9Eb> where z5R9Eb : new()
	{
		[ThreadStatic]
		private static z5R9Eb m_ThreadStaticValue;

		[SpecialName]
		internal z5R9Eb Rz3d8B()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new z5R9Eb();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Jb35Af()
		{
		}
	}

	private static readonly Jb35Af<a8GZm9> m_ComputerObjectProvider = new Jb35Af<a8GZm9>();

	private static readonly Jb35Af<c2BTb4> m_AppObjectProvider = new Jb35Af<c2BTb4>();

	private static readonly Jb35Af<User> m_UserObjectProvider = new Jb35Af<User>();

	private static Jb35Af<g7LZz2> m_MyFormsObjectProvider = new Jb35Af<g7LZz2>();

	private static readonly Jb35Af<Tp2s3H> m_MyWebServicesObjectProvider = new Jb35Af<Tp2s3H>();

	[HelpKeyword("My.Computer")]
	internal static a8GZm9 Computer => m_ComputerObjectProvider.get_GetInstance();

	[HelpKeyword("My.Application")]
	internal static c2BTb4 Application => m_AppObjectProvider.get_GetInstance();

	[HelpKeyword("My.User")]
	internal static User User => m_UserObjectProvider.get_GetInstance();

	[HelpKeyword("My.Forms")]
	internal static g7LZz2 Forms => m_MyFormsObjectProvider.get_GetInstance();

	[HelpKeyword("My.WebServices")]
	internal static Tp2s3H WebServices => m_MyWebServicesObjectProvider.get_GetInstance();
}
