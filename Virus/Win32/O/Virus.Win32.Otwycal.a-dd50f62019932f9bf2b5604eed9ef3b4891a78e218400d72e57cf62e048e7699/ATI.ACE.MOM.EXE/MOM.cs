using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ATI.ACE.MOM.EXE;

public sealed class MOM
{
	static MOM()
	{
		Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
	}

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		Type type = null;
		try
		{
			Assembly assembly = LoadAssembly("MOM.Implementation");
			if ((object)assembly != null)
			{
				type = assembly.GetType("ATI.ACE.MOM.Implementation.MOM");
			}
		}
		catch (ArgumentNullException ex)
		{
			MessageBox.Show(ex.Message);
		}
		catch (FileNotFoundException ex2)
		{
			MessageBox.Show(ex2.Message);
		}
		catch (FileLoadException ex3)
		{
			MessageBox.Show(ex3.Message);
		}
		catch (BadImageFormatException ex4)
		{
			MessageBox.Show(ex4.Message);
		}
		if ((object)type != null)
		{
			try
			{
				type.InvokeMember("Main", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, new object[1] { args });
			}
			catch (ArgumentNullException ex5)
			{
				MessageBox.Show(ex5.Message);
			}
			catch (ArgumentException ex6)
			{
				MessageBox.Show(ex6.Message);
			}
			catch (MethodAccessException ex7)
			{
				MessageBox.Show(ex7.Message);
			}
			catch (MissingFieldException ex8)
			{
				MessageBox.Show(ex8.Message);
			}
			catch (MissingMethodException ex9)
			{
				MessageBox.Show(ex9.Message);
			}
			catch (TargetException ex10)
			{
				MessageBox.Show(ex10.Message);
			}
			catch (AmbiguousMatchException ex11)
			{
				MessageBox.Show(ex11.Message);
			}
			catch (NotSupportedException ex12)
			{
				MessageBox.Show(ex12.Message);
			}
		}
	}

	private static Assembly LoadAssembly(string fileName)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		string text = "Software\\ATI\\ACE";
		string text2 = "software\\wow6432node";
		string text3 = "software";
		string text4 = text + "\\Assemblies";
		string assemblyString = fileName;
		RegistryKey registryKey = null;
		try
		{
			int size = IntPtr.Size;
			if (size == 8)
			{
				text4 = text4.ToLower(CultureInfo.InvariantCulture);
				if (!text4.Contains(text2))
				{
					text4 = text4.Replace(text3.ToLower(CultureInfo.InvariantCulture), text2.ToLower(CultureInfo.InvariantCulture));
				}
			}
			registryKey = Registry.LocalMachine.OpenSubKey(text4, writable: false);
			if (registryKey != null)
			{
				assemblyString = registryKey.GetValue(fileName, fileName) as string;
			}
		}
		catch (SecurityException ex)
		{
			MessageBox.Show(ex.Message);
		}
		catch (UnauthorizedAccessException ex2)
		{
			MessageBox.Show(ex2.Message);
		}
		finally
		{
			registryKey?.Close();
		}
		Assembly result = null;
		try
		{
			result = Assembly.Load(assemblyString);
			return result;
		}
		catch (FileLoadException ex3)
		{
			MessageBox.Show(ex3.Message);
			return result;
		}
		catch (BadImageFormatException ex4)
		{
			MessageBox.Show(ex4.Message);
			return result;
		}
		catch (SystemException ex5)
		{
			MessageBox.Show(ex5.Message);
			return result;
		}
	}
}
