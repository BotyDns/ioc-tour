namespace DiContainer.Interfaces
{

    public interface IContainerBuilder
    {
        IClassCollection ClassCollection { get; }


        DIContainer Build();
    }
}
