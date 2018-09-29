namespace Moula.Common
{
	public interface IFactory<out T>
	{
		T Create();
	}
}