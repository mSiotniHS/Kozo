namespace Lib;

public interface IExporter<out TExport, TMetadata>
{
	public TExport Export(IDocument<TMetadata> document);
}
