using System;
using Microsoft.VisualBasic.CompilerServices;
using WindowsApplication1.My;

namespace WindowsApplication1;

[StandardModule]
internal sealed class Module1
{
	[STAThread]
	public static void Main()
	{
		MyProject.Forms.FileHex.Dev();
	}
}
