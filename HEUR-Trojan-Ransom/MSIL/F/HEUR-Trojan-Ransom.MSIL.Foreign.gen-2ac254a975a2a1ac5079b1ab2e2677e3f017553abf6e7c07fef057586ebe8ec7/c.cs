using System;
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

[StandardModule]
[HideModuleName]
internal sealed class c
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class f<a> where a : new()
	{
		[ThreadStatic]
		private static a m_a;

		internal a a
		{
			[DebuggerHidden]
			get
			{
				if (f<a>.a == null)
				{
					f<a>.a = new a();
				}
				return f<a>.a;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public f()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class d
	{
		public j a;

		[ThreadStatic]
		private static Hashtable b;

		public j a
		{
			get
			{
				this.a = c(this.a);
				return this.a;
			}
			set
			{
				if (value == this.a)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							break;
						default:
							if (1 == 0)
							{
								/*OpCode not supported: LdMemberToken*/;
							}
							return;
						}
					}
				}
				if (value != null)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							break;
						default:
							throw new ArgumentException(n.a(1));
						}
					}
				}
				d(ref this.a);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public d()
		{
		}

		[DebuggerHidden]
		private unsafe static a c<a>(a P_0) where a : Form, new()
		{
			//Discarded unreachable code: IL_00ca, IL_0231, IL_024f
			if (P_0 != null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				_003CModule_003E.a = null;
				if (!((Control)P_0).get_IsDisposed())
				{
					return P_0;
				}
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			if (b != null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (b.ContainsKey(typeof(a)))
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							break;
						default:
						{
							string text = n.a(72);
							_003CModule_003E.d = null;
							throw new InvalidOperationException(Utils.GetResourceString(text, u.a(l.a(20))));
						}
						}
					}
				}
			}
			else
			{
				b = new Hashtable();
			}
			b.Add(typeof(a), q.a);
			TargetInvocationException ex = default(TargetInvocationException);
			try
			{
				return new a();
			}
			catch (object obj) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				TargetInvocationException obj2 = obj as TargetInvocationException;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
				if (obj2 == null)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num);
					if ((0x66 ^ ((uint)_003CModule_003E.o / 112u)) == 1969871125)
					{
						num = -1731338666;
					}
					else
					{
						int num2 = _003CModule_003E.p;
						num = ((((80 * num2 + 944 * num2 - 413) ^ 0x3BCBF954) == 0) ? (1742541955 + -686248131) : ((nint)Type.EmptyTypes.LongLength + 55021));
					}
					j.g = _003CModule_003E.c((int)num, (int)(((-(_003CModule_003E.j << 23) & 0x1BD9) == 0) ? ((nint)Type.EmptyTypes.LongLength + 55945) : (sizeof(int) + -708873888)), (int)((nint)Type.EmptyTypes.LongLength + 214));
					result = l.a(24);
				}
				else
				{
					ex = obj2;
					ProjectData.SetProjectError((Exception)obj2);
					Exception? innerException = ex.InnerException;
					string text2 = default(string);
					j.g = text2;
					_003CModule_003E.n = 1057425350;
					result = ((((((innerException == w.a) ? 1 : 0) == l.a(28)) ? 1u : 0u) > (uint)l.a(32)) ? 1 : 0);
				}
				return (byte)result != 0;
			}).Invoke())
			{
				_003CModule_003E.p = 2097519326;
				string text3 = n.a(129);
				string[] array = u.a(l.a(36));
				array[l.a(40)] = ex.InnerException!.Message;
				string text2 = Utils.GetResourceString(text3, array);
				throw new InvalidOperationException(text2, ex.InnerException);
			}
			finally
			{
				b.Remove(typeof(a));
			}
		}

		[DebuggerHidden]
		private void d<a>(ref a P_0) where a : Form
		{
			((Component)P_0).Dispose();
			P_0 = default(a);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object P_0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(P_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type e()
		{
			return typeof(d);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class e
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public e()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object P_0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(P_0));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type a()
		{
			return typeof(e);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static a b<a>(a P_0) where a : new()
		{
			//Discarded unreachable code: IL_0025
			if (P_0 == null)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						break;
					default:
						if (1 == 0)
						{
							/*OpCode not supported: LdMemberToken*/;
						}
						return new a();
					}
				}
			}
			return P_0;
		}

		[DebuggerHidden]
		private void c<a>(ref a P_0)
		{
			P_0 = default(a);
		}
	}

	private static readonly f<b> m_a = new f<b>();

	private static readonly f<a> m_b = new f<a>();

	private static readonly f<User> m_c = new f<User>();

	private static f<d> m_d = new f<d>();

	private static readonly f<e> m_e = new f<e>();

	[HelpKeyword("My.Computer")]
	internal static b a
	{
		[DebuggerHidden]
		get
		{
			return global::c.m_a.a;
		}
	}

	[HelpKeyword("My.Application")]
	internal static a b
	{
		[DebuggerHidden]
		get
		{
			return global::c.m_b.a;
		}
	}

	[HelpKeyword("My.User")]
	internal static User c
	{
		[DebuggerHidden]
		get
		{
			return global::c.m_c.a;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static d d
	{
		[DebuggerHidden]
		get
		{
			return global::c.m_d.a;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static e e
	{
		[DebuggerHidden]
		get
		{
			return global::c.m_e.a;
		}
	}
}
