using System.Web;
using System.Windows.Forms;

internal class Class7
{
	private static bool bool_0;

	internal static void pZcHwjQzdndJT()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (bool_0)
		{
			return;
		}
		bool_0 = true;
		try
		{
			MessageBox.Show("This assembly is protected by an unregistered version of Eziriz's \".NET Reactor\"!");
		}
		catch
		{
			try
			{
				if (HttpContext.get_Current() != null && HttpContext.get_Current().get_Response() != null)
				{
					HttpContext.get_Current().get_Response().Write("<script language='javascript'>alert( \"This assembly is protected by an unregistered version of .NET Reactor!\" );</script>");
				}
			}
			catch
			{
			}
		}
	}
}
