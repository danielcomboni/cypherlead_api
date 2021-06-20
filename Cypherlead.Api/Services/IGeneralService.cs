using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cypherlead.Api.Services
{

    public interface IGeneralService<TEntityModel, TCreateModel, TUpdateModel, TViewModel> where TEntityModel : class
        where TCreateModel : class where TUpdateModel : class where TViewModel : class
    {
        Task<TCreateModel> CreateAsync(TCreateModel createModel);
        Task<TUpdateModel> UpdateAsync(TUpdateModel updateModel, Guid id);
        Task<IEnumerable<TViewModel>> GetAllAsync();
        Task<TEntityModel> GetByIdAsync(Guid id);
        Task<int> DeleteAsync(Guid id);
        Task<bool> Exists(Guid id);
        Task<IEnumerable<TEntityModel>> CreateBatchAsync(IEnumerable<TEntityModel> entities);
    }
}
