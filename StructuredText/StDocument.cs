using Lib;

namespace StructuredText;

public struct Metadata : IMetadata
{
	public string Title;
	public string Author;
}

public sealed class StDocument : IDocument
{
	public Metadata Metadata { get; init; }
	public List<IBlockElement> Content { get; init; }
}
