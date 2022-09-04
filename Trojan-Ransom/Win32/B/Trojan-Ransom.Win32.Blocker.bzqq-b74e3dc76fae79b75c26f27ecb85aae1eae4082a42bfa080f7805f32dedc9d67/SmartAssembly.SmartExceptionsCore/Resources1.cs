using System;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace SmartAssembly.SmartExceptionsCore;

internal class Resources1
{
	public static Bitmap GetBitmap(string key)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		Stream manifestResourceStream = default(Stream);
		Bitmap val = default(Bitmap);
		try
		{
			try
			{
				manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartUsageWithUI.Resources." + key + ".png");
				val = ((manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream));
				return val;
			}
			catch
			{
				val = null;
				return val;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, manifestResourceStream, val, key);
			throw;
		}
	}

	public static Icon GetIcon(string key)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		Stream manifestResourceStream = default(Stream);
		Icon val = default(Icon);
		try
		{
			try
			{
				manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartUsageWithUI.Resources." + key + ".ico");
				val = ((manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream));
				return val;
			}
			catch
			{
				val = null;
				return val;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, manifestResourceStream, val, key);
			throw;
		}
	}
}
