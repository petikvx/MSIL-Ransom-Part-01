using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Xml;
using Spatula2;
using ns3;

namespace Loadsta8;

public class Stu00i0gly
{
	private static Assembly Urol3th3c;

	private static string Pl3cet;

	private static string Al5ugs;

	public static IJavaProcess Cigar5t()
	{
		if (Urol3th3c == null)
		{
			Forge55ers();
		}
		return (IJavaProcess)Urol3th3c.CreateInstance(Pl3cet);
	}

	public static IJDbg Triste1rins()
	{
		if (Urol3th3c == null)
		{
			Forge55ers();
		}
		return (IJDbg)Urol3th3c.CreateInstance(Al5ugs);
	}

	[SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Reflection.Assembly.LoadFrom", Justification = "Binary provided in the config file will not be installed in the GAC. It is located in a restricted location requiring admin privilages.")]
	private static void Forge55ers()
	{
		string directoryName = Path.GetDirectoryName(Assembly.GetCallingAssembly().Location);
		using FileStream input = new FileStream(Path.Combine(directoryName, "Microsoft.Kofe.JDWP.config"), FileMode.Open, FileAccess.Read);
		XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
		xmlReaderSettings.XmlResolver = null;
		XmlReader xmlReader = XmlReader.Create(input, xmlReaderSettings);
		xmlReader.ReadToDescendant("Module");
		string path = xmlReader.ReadElementContentAsString() + ".DLL";
		xmlReader.ReadToNextSibling("Process");
		Pl3cet = xmlReader.ReadElementContentAsString();
		xmlReader.ReadToNextSibling("JDbg");
		Al5ugs = xmlReader.ReadElementContentAsString();
		Urol3th3c = Assembly.LoadFrom(Path.Combine(directoryName, path));
	}
}
