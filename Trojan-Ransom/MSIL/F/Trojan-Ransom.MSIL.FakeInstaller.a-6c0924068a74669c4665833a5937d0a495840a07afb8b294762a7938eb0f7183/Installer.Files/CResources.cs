using System.IO;
using System.Reflection;

namespace Installer.Files;

internal static class CResources
{
	private static Assembly _assembly;

	private static byte[] m_storage;

	private static Assembly m_assembly
	{
		get
		{
			if ((object)_assembly == null)
			{
				_assembly = Assembly.GetExecutingAssembly();
			}
			return _assembly;
		}
	}

	internal static Stream GetManifestResourceStream(string resourceName)
	{
		if (m_storage == null)
		{
			Stream manifestResourceStream = m_assembly.GetManifestResourceStream("Installer.Files.storage");
			BinaryReader binaryReader = new BinaryReader(manifestResourceStream);
			m_storage = binaryReader.ReadBytes((int)manifestResourceStream.Length);
		}
		if (m_storage[0] == 39)
		{
			int num = resourceName switch
			{
				"Installer.Files.params.txt" => 0, 
				"Installer.Files.installer.bmp" => 1, 
				"Installer.Files.otherCountries.bmp" => 2, 
				_ => 3, 
			};
			long num2 = 1L;
			while (num > 0)
			{
				long num3 = m_storage[num2] + m_storage[num2 + 1L] * 256 + m_storage[num2 + 2L] * 256 * 256 + m_storage[num2 + 3L] * 256 * 256 * 256;
				num2 += num3 + 4L;
				num--;
			}
			long num4 = m_storage[num2] + m_storage[num2 + 1L] * 256 + m_storage[num2 + 2L] * 256 * 256 + m_storage[num2 + 3L] * 256 * 256 * 256;
			byte[] array = new byte[num4];
			num2 += 4L;
			for (int i = 0; i < num4; i++)
			{
				array[i] = m_storage[num2++];
			}
			return new MemoryStream(array);
		}
		return null;
	}
}
