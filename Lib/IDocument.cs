namespace Lib;

public interface IMetadata {}

public interface IDocument
{
	IMetadata Metadata { get; init; }
	List<IBlockElement> Content { get; init; }
}
