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
using MiniGameEngine;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Class3
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class4
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Editor editor_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public MainForm mainForm_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Viewer viewer_0;

		public Editor Editor
		{
			[DebuggerHidden]
			get
			{
				editor_0 = smethod_0(editor_0);
				return editor_0;
			}
			[DebuggerHidden]
			set
			{
				if (value != editor_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					method_0(ref editor_0);
				}
			}
		}

		public MainForm MainForm
		{
			[DebuggerHidden]
			get
			{
				mainForm_0 = smethod_0(mainForm_0);
				return mainForm_0;
			}
			[DebuggerHidden]
			set
			{
				if (value != mainForm_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					method_0(ref mainForm_0);
				}
			}
		}

		[DebuggerHidden]
		private static OkEmBKaPT6hu4W0623 smethod_0<OkEmBKaPT6hu4W0623>(OkEmBKaPT6hu4W0623 zqLAvl58fpHx1ap0uf) where OkEmBKaPT6hu4W0623 : Form, new()
		{
			if (zqLAvl58fpHx1ap0uf == null || ((Control)zqLAvl58fpHx1ap0uf).get_IsDisposed())
			{
				if (hashtable_0 != null)
				{
					if (hashtable_0.ContainsKey(typeof(OkEmBKaPT6hu4W0623)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					hashtable_0 = new Hashtable();
				}
				hashtable_0.Add(typeof(OkEmBKaPT6hu4W0623), null);
				try
				{
					return new OkEmBKaPT6hu4W0623();
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
					hashtable_0.Remove(typeof(OkEmBKaPT6hu4W0623));
				}
			}
			return zqLAvl58fpHx1ap0uf;
		}

		[DebuggerHidden]
		private void method_0<iJWlvQJSU8UDtwb5rw>(ref iJWlvQJSU8UDtwb5rw gparam_0) where iJWlvQJSU8UDtwb5rw : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(iJWlvQJSU8UDtwb5rw);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
			Class11.NQ1E32yzjMukk();
			base._002Ector();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return typeof(Class4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[SpecialName]
		[DebuggerHidden]
		public Viewer method_2()
		{
			viewer_0 = smethod_0(viewer_0);
			return viewer_0;
		}

		[SpecialName]
		[DebuggerHidden]
		public void method_3(Viewer viewer_1)
		{
			if (viewer_1 != viewer_0)
			{
				if (viewer_1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				method_0(ref viewer_0);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class5
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class5);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static AFqcNCbpQ4Q2wwDbq3 smethod_0<AFqcNCbpQ4Q2wwDbq3>(AFqcNCbpQ4Q2wwDbq3 MXVxjBqlQkGrFSpUKj) where AFqcNCbpQ4Q2wwDbq3 : new()
		{
			if (MXVxjBqlQkGrFSpUKj == null)
			{
				return new AFqcNCbpQ4Q2wwDbq3();
			}
			return MXVxjBqlQkGrFSpUKj;
		}

		[DebuggerHidden]
		private void method_1<L9ADrNYWNtJYVRnoxx>(ref L9ADrNYWNtJYVRnoxx gparam_0)
		{
			gparam_0 = default(L9ADrNYWNtJYVRnoxx);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class5()
		{
			Class11.NQ1E32yzjMukk();
			base._002Ector();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class6<SlAnDQlJMvbUV139SS> where SlAnDQlJMvbUV139SS : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static SlAnDQlJMvbUV139SS jwXwtokBuD;

		[SpecialName]
		[DebuggerHidden]
		internal SlAnDQlJMvbUV139SS method_0()
		{
			if (jwXwtokBuD == null)
			{
				jwXwtokBuD = new SlAnDQlJMvbUV139SS();
			}
			return jwXwtokBuD;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class6()
		{
			Class11.NQ1E32yzjMukk();
			base._002Ector();
		}
	}

	private static readonly Class6<Class2> class6_0;

	private static readonly Class6<Class1> class6_1;

	private static readonly Class6<User> class6_2;

	private static Class6<Class4> class6_3;

	private static readonly Class6<Class5> class6_4;

	[HelpKeyword("My.Computer")]
	internal static Class2 Class2_0
	{
		[DebuggerHidden]
		get
		{
			return class6_0.method_0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class1 Class1_0
	{
		[DebuggerHidden]
		get
		{
			return class6_1.method_0();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class6_2.method_0();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			return class6_3.method_0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class5 Class5_0
	{
		[DebuggerHidden]
		get
		{
			return class6_4.method_0();
		}
	}

	static Class3()
	{
		Class11.NQ1E32yzjMukk();
		class6_0 = new Class6<Class2>();
		class6_1 = new Class6<Class1>();
		class6_2 = new Class6<User>();
		class6_3 = new Class6<Class4>();
		class6_4 = new Class6<Class5>();
	}
}
