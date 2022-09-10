using System;
using System.IO;
using System.Security.Cryptography;

namespace abc;

internal class Wipe
{
	public event PassInfoEventHandler PassInfoEvent;

	public event SectorInfoEventHandler SectorInfoEvent;

	public event WipeDoneEventHandler WipeDoneEvent;

	public event WipeErrorEventHandler WipeErrorEvent;

	public void WipeFile(string filename, int timesToWrite)
	{
		try
		{
			if (!File.Exists(filename))
			{
				return;
			}
			double num = Math.Ceiling((double)new FileInfo(filename).Length / 512.0);
			byte[] array = new byte[512];
			RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
			FileStream fileStream = new FileStream(filename, FileMode.Open);
			for (int i = 0; i < timesToWrite; i++)
			{
				UpdatePassInfo(i + 1, timesToWrite);
				fileStream.Position = 0L;
				for (int j = 0; (double)j < num; j++)
				{
					UpdateSectorInfo(j + 1, (int)num);
					rNGCryptoServiceProvider.GetBytes(array);
					fileStream.Write(array, 0, array.Length);
				}
			}
			fileStream.SetLength(0L);
			fileStream.Close();
			DateTime dateTime = new DateTime(2037, 1, 1, 0, 0, 0);
			File.SetCreationTime(filename, dateTime);
			File.SetLastAccessTime(filename, dateTime);
			File.SetLastWriteTime(filename, dateTime);
			File.SetCreationTimeUtc(filename, dateTime);
			File.SetLastAccessTimeUtc(filename, dateTime);
			File.SetLastWriteTimeUtc(filename, dateTime);
			File.Delete(filename);
			WipeDone();
		}
		catch (Exception e)
		{
			WipeError(e);
		}
	}

	private void UpdatePassInfo(int currentPass, int totalPasses)
	{
		this.PassInfoEvent(new PassInfoEventArgs(currentPass, totalPasses));
	}

	private void UpdateSectorInfo(int currentSector, int totalSectors)
	{
		this.SectorInfoEvent(new SectorInfoEventArgs(currentSector, totalSectors));
	}

	private void WipeDone()
	{
		this.WipeDoneEvent(new WipeDoneEventArgs());
	}

	private void WipeError(Exception e)
	{
		this.WipeErrorEvent(new WipeErrorEventArgs(e));
	}
}
