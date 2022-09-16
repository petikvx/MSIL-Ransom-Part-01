using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pal.EventLogAnalyzer.IO;

public class ProtocolRules
{
	public readonly byte commandStart;

	public readonly byte commandNext;

	public readonly byte commandDefine;

	public readonly byte commandEnd;

	public readonly IEnumerable<CommandModel> models;

	public readonly Encoding stringEncoding;

	private readonly ReadOnlyDictionary<ushort, CommandModel> indexedModels;

	public CommandModel this[ushort i] => default(CommandModel);

	public ProtocolRules(IEnumerable<CommandModel> models)
	{
		Encoding unicode = Encoding.Unicode;
		char c = '[';
		char c2 = ';';
		char c3 = '>';
		char c4 = ']';
		this._002Ector(models, unicode, in c, in c2, in c3, in c4);
	}

	public ProtocolRules(IEnumerable<CommandModel> models, Encoding stringEncoding, in char commandStart, in char commandNext, in char commandDefine, in char commandEnd)
	{
		byte b = (byte)commandStart;
		byte b2 = (byte)commandNext;
		byte b3 = (byte)commandDefine;
		byte b4 = (byte)commandEnd;
		this._002Ector(models, stringEncoding, in b, in b2, in b3, in b4);
	}

	public ProtocolRules(IEnumerable<CommandModel> models, Encoding stringEncoding, in byte commandStart, in byte commandNext, in byte commandDefine, in byte commandEnd)
	{
		this.models = models.ToList().AsReadOnly();
		this.stringEncoding = stringEncoding ?? throw new ArgumentNullException("stringEncoding");
		this.commandStart = commandStart;
		this.commandNext = commandNext;
		this.commandDefine = commandDefine;
		this.commandEnd = commandEnd;
	}

	public bool TryGetModel(ushort type)
	{
		return true;
	}
}
