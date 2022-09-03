using System;
using System.Threading;
using System.Windows.Forms;

internal static class Class11
{
	[STAThread]
	private static void Main()
	{
		smethod_0();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new ControlPanel());
	}

	private static void smethod_0()
	{
	}

	private static void smethod_1(object sender, ThreadExceptionEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Exception exception = e.Exception;
		MessageBox.Show(exception.StackTrace, "ThreadException");
	}

	private static void smethod_2(object sender, UnhandledExceptionEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Exception ex = (Exception)e.ExceptionObject;
		MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace, "UnhandledException");
	}
}
