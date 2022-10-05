using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;
using i4AJ;
using r3ST;

namespace b7SY;

[StandardModule]
[HideModuleName]
internal sealed class e7DL
{
	[MyGroupCollection("System.Windows.Window", "Create__Instance__", "Dispose__Instance__", "My.MyWpfExtenstionModule.Windows")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Bp6n
	{
		[ThreadStatic]
		private static Hashtable C;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public n2M8 y;

		private static b5NQ Ko8c<b5NQ>(b5NQ gparam_0) where b5NQ : Window, new()
		{
			if (gparam_0 == null)
			{
				if (C != null)
				{
					if (C.ContainsKey(typeof(b5NQ)))
					{
						throw new InvalidOperationException("The window cannot be accessed via My.Windows from the Window constructor.");
					}
				}
				else
				{
					C = new Hashtable();
				}
				C.Add(typeof(b5NQ), null);
				return new b5NQ();
			}
			return gparam_0;
		}

		private void o0HB<y4ZY>(ref y4ZY gparam_0) where y4ZY : Window
		{
			gparam_0 = default(y4ZY);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Bp6n()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Fp3c(object object_0)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(object_0));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int n9P2()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type d6M1()
		{
			return typeof(Bp6n);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string o6P9()
		{
			return base.ToString();
		}

		[SpecialName]
		public n2M8 Fg48()
		{
			y = Ko8c(y);
			return y;
		}

		[SpecialName]
		public void q2J0(n2M8 n2M8_0)
		{
			if (n2M8_0 != y)
			{
				if (n2M8_0 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				o0HB(ref y);
			}
		}
	}

	private static m7A5.Xt2j<Computer> C = new m7A5.Xt2j<Computer>();

	private static m7A5.Xt2j<User> y = new m7A5.Xt2j<User>();

	private static m7A5.Xt2j<Bp6n> J = new m7A5.Xt2j<Bp6n>();

	private static m7A5.Xt2j<Log> W = new m7A5.Xt2j<Log>();

	[SpecialName]
	internal static Bp6n s3LJ()
	{
		return J.Q();
	}
}
