using AutoMapper;
using Cypherlead.Api.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cypherlead.Api.Services
{
    public class GeneralService<TEntityModel, TCreateModel, TUpdateModel, TViewModel> : IGeneralService<TEntityModel, TCreateModel, TUpdateModel, TViewModel> where TEntityModel : class
        where TCreateModel : class where TUpdateModel : class where TViewModel : class
    {

        private readonly IGeneralRepository<TEntityModel> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<TEntityModel> _logger;

        public GeneralService(IGeneralRepository<TEntityModel> repository, IMapper mapper, ILogger<TEntityModel> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public virtual async Task<TCreateModel> CreateAsync(TCreateModel createModel)
        {
            var entityModel = await _repository.CreateAsync(_mapper.Map<TEntityModel>(createModel));
            return _mapper.Map<TCreateModel>(entityModel);
        }

        public virtual async Task<IEnumerable<TEntityModel>> CreateBatchAsync(IEnumerable<TEntityModel> entities)
            => await _repository.CreateBatchAsync(entities);

        public virtual async Task<int> DeleteAsync(Guid id) => await _repository.DeleteAsync(id);

        public virtual async Task<bool> Exists(Guid id) => await _repository.Exists(id);

        public virtual async Task<IEnumerable<TViewModel>> GetAllAsync() => _mapper.Map<List<TViewModel>>(await _repository.GetAllAsync());

        public virtual async Task<TEntityModel> GetByIdAsync(Guid id) => await _repository.GetByIdAsync(id);

        public virtual async Task<TUpdateModel> UpdateAsync(TUpdateModel updateModel, Guid id)
        {
            var entityModel = await _repository.UpdateAsync(_mapper.Map<TEntityModel>(updateModel), id);
            return _mapper.Map<TUpdateModel>(entityModel);
        }

    }
}
