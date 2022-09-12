using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Se3;

[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class Ew7
{
	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class d0S<c7J> where c7J : new()
	{
		[ThreadStatic]
		private static c7J m_ThreadStaticValue;

		[SpecialName]
		internal c7J z4H()
		{
			if (m_ThreadStaticValue == null)
			{
				m_ThreadStaticValue = new c7J();
			}
			return m_ThreadStaticValue;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public d0S()
		{
		}
	}
}
