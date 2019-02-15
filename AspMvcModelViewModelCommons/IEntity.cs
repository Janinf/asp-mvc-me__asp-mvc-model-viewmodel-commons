namespace AspMvcModelViewModelCommons
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a database model
    /// </summary>
    public interface IEntity<TModel> : IModel<TModel> where TModel : IModel<TModel>
    {
        IViewModel<TModel> ToViewModel();
    }
}