namespace AspMvcModelViewModelCommons
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a model for a views
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public interface IViewModel<TModel> : IModel<TModel> where TModel : IModel<TModel>
    {
        IEntity<TModel> ToEntity();
    }
}