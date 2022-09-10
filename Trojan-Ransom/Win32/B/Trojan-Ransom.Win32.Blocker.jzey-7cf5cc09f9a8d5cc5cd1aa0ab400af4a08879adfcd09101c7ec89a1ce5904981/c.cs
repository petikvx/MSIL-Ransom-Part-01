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
using E21wpg6v;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using sReLFYF2;
using wMk1FHff;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class c
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class nK2ej5qv
	{
		[ThreadStatic]
		private static Hashtable ANeT8hMx;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public zA2HbRlB MMPzyxcZ;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public plwslqFm oVEZgrWO;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public zWpziX3X zWpziX3X_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public iZ7z1xiY Q0rpVBaE;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ProjectDialogForm rIEn7L9R;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public B6EVEXad o9VphZv9;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public K2mIgUhF RpROX1i5;

		public zA2HbRlB ZA2HbRlB_0
		{
			get
			{
				MMPzyxcZ = smethod_0(MMPzyxcZ);
				return MMPzyxcZ;
			}
			set
			{
				if (value != MMPzyxcZ)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					jsTZg918(ref MMPzyxcZ);
				}
			}
		}

		public plwslqFm PlwslqFm_0
		{
			get
			{
				oVEZgrWO = smethod_0(oVEZgrWO);
				return oVEZgrWO;
			}
			set
			{
				if (value != oVEZgrWO)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					jsTZg918(ref oVEZgrWO);
				}
			}
		}

		public zWpziX3X i87fMpfy
		{
			get
			{
				zWpziX3X_0 = smethod_0(zWpziX3X_0);
				return zWpziX3X_0;
			}
			set
			{
				if (value != zWpziX3X_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					jsTZg918(ref zWpziX3X_0);
				}
			}
		}

		public iZ7z1xiY dY9azWnv
		{
			get
			{
				Q0rpVBaE = smethod_0(Q0rpVBaE);
				return Q0rpVBaE;
			}
			set
			{
				if (value != Q0rpVBaE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					jsTZg918(ref Q0rpVBaE);
				}
			}
		}

		public ProjectDialogForm stRYMSJ5
		{
			get
			{
				rIEn7L9R = smethod_0(rIEn7L9R);
				return rIEn7L9R;
			}
			set
			{
				if (value != rIEn7L9R)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					jsTZg918(ref rIEn7L9R);
				}
			}
		}

		public B6EVEXad JsPAqR2u
		{
			get
			{
				o9VphZv9 = smethod_0(o9VphZv9);
				return o9VphZv9;
			}
			set
			{
				if (value != o9VphZv9)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					jsTZg918(ref o9VphZv9);
				}
			}
		}

		public K2mIgUhF K2mIgUhF_0
		{
			get
			{
				RpROX1i5 = smethod_0(RpROX1i5);
				return RpROX1i5;
			}
			set
			{
				if (value != RpROX1i5)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					jsTZg918(ref RpROX1i5);
				}
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T rYnccsHJ) where T : Form, new()
		{
			if (rYnccsHJ != null && !((Control)rYnccsHJ).get_IsDisposed())
			{
				return rYnccsHJ;
			}
			if (ANeT8hMx != null)
			{
				if (m8meAX3U.smethod_0(ANeT8hMx, m8meAX3U.NXTa0utH(typeof(T).TypeHandle, 9099), 10569))
				{
					throw new InvalidOperationException(m8meAX3U.NPSqfVK7("WinForms_RecursiveFormCreate", new string[0], 15269));
				}
			}
			else
			{
				ANeT8hMx = new Hashtable();
			}
			m8meAX3U.hU1pH7xp(ANeT8hMx, m8meAX3U.NXTa0utH(typeof(T).TypeHandle, 9099), null, 59043);
			try
			{
				return new T();
			}
			catch (TargetInvocationException exception_) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				m8meAX3U.L6HgMKrR(exception_, 21003);
				return m8meAX3U.XUdv6OGi(exception_, 55772) != null;
			}).Invoke())
			{
				throw new InvalidOperationException(m8meAX3U.NPSqfVK7("WinForms_SeeInnerException", new string[1] { m8meAX3U.gGC2YcoR(m8meAX3U.XUdv6OGi(exception_, 55772), 48705) }, 15269), m8meAX3U.XUdv6OGi(exception_, 55772));
			}
			finally
			{
				m8meAX3U.dLT6t40X(ANeT8hMx, m8meAX3U.NXTa0utH(typeof(T).TypeHandle, 9099), 63468);
			}
		}

		[DebuggerHidden]
		private void jsTZg918<T>(ref T WLiKplzp) where T : Form
		{
			((Component)WLiKplzp).Dispose();
			for (int num = 0; num == 0; num = 1)
			{
				WLiKplzp = default(T);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public nK2ej5qv()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(m8meAX3U.bErpAbl3(o, 6598));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Wegq9WkI()
		{
			return m8meAX3U.NXTa0utH(typeof(nK2ej5qv).TypeHandle, 9099);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class B43bjyeb
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(m8meAX3U.bErpAbl3(o, 6598));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type MiotcOL1()
		{
			return m8meAX3U.NXTa0utH(typeof(B43bjyeb).TypeHandle, 9099);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static lzTUoQ8U smethod_0<lzTUoQ8U>(lzTUoQ8U go4yefTf) where lzTUoQ8U : new()
		{
			if (go4yefTf == null)
			{
				return new lzTUoQ8U();
			}
			return go4yefTf;
		}

		[DebuggerHidden]
		private void fdUtGfbt<T>(ref T eZHZwBLn)
		{
			eZHZwBLn = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public B43bjyeb()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class0<a> where a : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static a Fc4Ltn6g;

		internal a cAkeyUJJ
		{
			[DebuggerHidden]
			get
			{
				if (Fc4Ltn6g == null)
				{
					Fc4Ltn6g = new a();
				}
				return Fc4Ltn6g;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class0()
		{
		}
	}

	private static readonly Class0<b> mrX6RDXy = new Class0<b>();

	private static readonly Class0<A> HIUY9MOr = new Class0<A>();

	private static readonly Class0<User> oQwegMcy = new Class0<User>();

	private static Class0<nK2ej5qv> Ix3aEqFA = new Class0<nK2ej5qv>();

	private static readonly Class0<B43bjyeb> ohDMROHP = new Class0<B43bjyeb>();

	[HelpKeyword("My.Computer")]
	internal static b B_0
	{
		[DebuggerHidden]
		get
		{
			return mrX6RDXy.cAkeyUJJ;
		}
	}

	[HelpKeyword("My.Application")]
	internal static A A_0
	{
		[DebuggerHidden]
		get
		{
			return HIUY9MOr.cAkeyUJJ;
		}
	}

	[HelpKeyword("My.User")]
	internal static User cu3xzRe6
	{
		[DebuggerHidden]
		get
		{
			return oQwegMcy.cAkeyUJJ;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static nK2ej5qv uEYodtq4
	{
		[DebuggerHidden]
		get
		{
			return Ix3aEqFA.cAkeyUJJ;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static B43bjyeb ys65ImHc
	{
		[DebuggerHidden]
		get
		{
			return ohDMROHP.cAkeyUJJ;
		}
	}
}
