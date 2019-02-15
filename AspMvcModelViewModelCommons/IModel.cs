namespace AspMvcModelViewModelCommons
{
    /// <summary>
    /// Base interface for Entities and ViewModels
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public interface IModel<TModel> where TModel : IModel<TModel>
    {
    }
}