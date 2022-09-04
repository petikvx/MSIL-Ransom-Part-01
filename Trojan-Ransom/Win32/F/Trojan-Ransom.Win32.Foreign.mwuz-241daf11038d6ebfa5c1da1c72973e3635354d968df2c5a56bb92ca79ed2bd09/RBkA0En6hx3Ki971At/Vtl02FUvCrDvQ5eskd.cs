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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using N1rRoaaHTA0QAGFQQl;
using bjrdkskshrst;
using nrm40BN0k5ScGrO4hs;

namespace RBkA0En6hx3Ki971At;

[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
internal sealed class Vtl02FUvCrDvQ5eskd
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MJZV135YDm2sobTv15
	{
		public sdfgh D5Pr4rxRT;

		[ThreadStatic]
		private static Hashtable RasiiJTGe;

		public sdfgh sdfgh
		{
			get
			{
				D5Pr4rxRT = TvQl5eskd(D5Pr4rxRT);
				return D5Pr4rxRT;
			}
			set
			{
				if (value == D5Pr4rxRT)
				{
					_ = 0;
					if (pJSbwXC5sa2g54qVXu())
					{
						return;
					}
				}
				else if (value == null)
				{
					RBktA0E6h(ref D5Pr4rxRT);
					return;
				}
				throw new ArgumentException("Property can only be set to Nothing");
			}
		}

		[DebuggerHidden]
		private static T TvQl5eskd<T>(T Instance) where T : Form, new()
		{
			if (Instance != null && !((Control)Instance).get_IsDisposed())
			{
				return Instance;
			}
			if (RasiiJTGe != null)
			{
				if (RasiiJTGe.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
				}
			}
			else
			{
				RasiiJTGe = new Hashtable();
			}
			RasiiJTGe.Add(typeof(T), null);
			try
			{
				return new T();
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
				RasiiJTGe.Remove(typeof(T));
			}
		}

		[DebuggerHidden]
		private void RBktA0E6h<T>(ref T gparam_0) where T : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MJZV135YDm2sobTv15()
		{
			PsEoEtG4EsXiGiKGTC(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(hGXl8pKDE2J5TtbQtT(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return Y2q4BB4hY1bKUqg70S(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type d3KBi971A()
		{
			return P2h6VweQfQj7dZ2O6h(typeof(MJZV135YDm2sobTv15).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		internal static bool pJSbwXC5sa2g54qVXu()
		{
			return true;
		}

		internal static bool Alk8eiJGhLcJtMls0W()
		{
			return false;
		}

		internal static void PsEoEtG4EsXiGiKGTC(object object_0)
		{
			object_0._002Ector();
		}

		internal static object hGXl8pKDE2J5TtbQtT(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static int Y2q4BB4hY1bKUqg70S(object object_0)
		{
			return object_0.GetHashCode();
		}

		internal static Type P2h6VweQfQj7dZ2O6h(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class M4rxRTk9asiJTGefrb
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return kKJ4ZIlZx4nVuhRQpf(this, L6Fq3iNNw9qlZ6RQtP(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type IrbjF7vWk()
		{
			return typeof(M4rxRTk9asiJTGefrb);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return (string)owuSB3xywqKgoCiy7o(this);
		}

		[DebuggerHidden]
		private static T MUC0xrI0a<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void U6IQTAIVR<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public M4rxRTk9asiJTGefrb()
		{
			WRrAduooXoc267fwrI(this);
		}

		internal static object L6Fq3iNNw9qlZ6RQtP(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static bool kKJ4ZIlZx4nVuhRQpf(object object_0, object object_1)
		{
			return object_0.Equals(object_1);
		}

		internal static bool oBu3SkaFKKN5CRZn1T()
		{
			return true;
		}

		internal static bool mWR4kBvOUPmBxYuIl5()
		{
			return false;
		}

		internal static object owuSB3xywqKgoCiy7o(object object_0)
		{
			return object_0.ToString();
		}

		internal static void WRrAduooXoc267fwrI(object object_0)
		{
			object_0._002Ector();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class X7vWkAmUCxrI0ab6IT<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T hMqhOBSUv;

		[SpecialName]
		[DebuggerHidden]
		internal T rSnpaNIFV()
		{
			if (hMqhOBSUv == null)
			{
				hMqhOBSUv = new T();
			}
			return hMqhOBSUv;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public X7vWkAmUCxrI0ab6IT()
		{
		}
	}

	private static readonly X7vWkAmUCxrI0ab6IT<vwi5wyYPau1qIQy6YD> iwymPau1q;

	private static readonly X7vWkAmUCxrI0ab6IT<iT6ba9su0WwFtHt6li> AQyR6YDwr;

	private static readonly X7vWkAmUCxrI0ab6IT<User> k40TB0k5S;

	private static X7vWkAmUCxrI0ab6IT<MJZV135YDm2sobTv15> rGrwO4hsb;

	private static readonly X7vWkAmUCxrI0ab6IT<M4rxRTk9asiJTGefrb> pl0u2FvCr;

	[HelpKeyword("My.Computer")]
	internal static vwi5wyYPau1qIQy6YD rtVxbV7EO
	{
		[DebuggerHidden]
		get
		{
			return iwymPau1q.rSnpaNIFV();
		}
	}

	[HelpKeyword("My.Application")]
	internal static iT6ba9su0WwFtHt6li pOPaKYRE1
	{
		[DebuggerHidden]
		get
		{
			return AQyR6YDwr.rSnpaNIFV();
		}
	}

	[HelpKeyword("My.User")]
	internal static User YpuNnT6ba
	{
		[DebuggerHidden]
		get
		{
			return k40TB0k5S.rSnpaNIFV();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MJZV135YDm2sobTv15 p6lniP1rR
	{
		[DebuggerHidden]
		get
		{
			return rGrwO4hsb.rSnpaNIFV();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static M4rxRTk9asiJTGefrb SFQkQl0wi
	{
		[DebuggerHidden]
		get
		{
			return pl0u2FvCr.rSnpaNIFV();
		}
	}

	static Vtl02FUvCrDvQ5eskd()
	{
		while (true)
		{
			iwymPau1q = new X7vWkAmUCxrI0ab6IT<vwi5wyYPau1qIQy6YD>();
			while (true)
			{
				AQyR6YDwr = new X7vWkAmUCxrI0ab6IT<iT6ba9su0WwFtHt6li>();
				k40TB0k5S = new X7vWkAmUCxrI0ab6IT<User>();
				_ = 0;
				if (!aXg2QaZuAbWBFTxFRc())
				{
					goto IL_0020;
				}
				goto IL_0059;
				IL_0059:
				rGrwO4hsb = new X7vWkAmUCxrI0ab6IT<MJZV135YDm2sobTv15>();
				goto IL_0020;
				IL_0020:
				while (true)
				{
					pl0u2FvCr = new X7vWkAmUCxrI0ab6IT<M4rxRTk9asiJTGefrb>();
					if (aXg2QaZuAbWBFTxFRc())
					{
						switch (6)
						{
						case 0:
							break;
						default:
							continue;
						case 1:
						case 2:
							goto IL_0059;
						case 5:
							goto end_IL_0003;
						case 6:
							return;
						}
						break;
					}
					return;
				}
				continue;
				end_IL_0003:
				break;
			}
		}
	}

	internal static bool aXg2QaZuAbWBFTxFRc()
	{
		return true;
	}

	internal static bool rcEr0qb6XfY8fhDfoa()
	{
		return false;
	}
}
