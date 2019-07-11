using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using Abp.UI;
using RaymondYuSolution.CMS.Dto;
using RaymondYuSolution.CMS.Entity;

namespace RaymondYuSolution.CMS
{

    public class CMSAppService : ICMSAppService
    {
        private readonly IRepository<CMSContent> _cmsRepository;
        private readonly IObjectMapper _objectMapper;

        public CMSAppService(IRepository<CMSContent> cmsRepository, IObjectMapper objectMapper)
        {
            _cmsRepository = cmsRepository;
            _objectMapper = objectMapper;
        }

        public async Task<ICollection<CMSDto>> GetAll()
        {
            var list = await _cmsRepository.GetAllListAsync();

            return _objectMapper.Map<ICollection<CMSDto>>(list);
        }

        public async Task<CMSDto> GetCMSContent(int pageId)
        {
            var cms = await _cmsRepository.GetAsync(pageId);

            if (cms == null) {
                throw new UserFriendlyException("Cannot find page.");
            }

            // convert entity to dto

            return _objectMapper.Map<CMSDto>(cms);
        }


        // Create task if it doesn't exist, update if it does
        public async Task InsertOrUpdateCMSContent(CMSInsertOrUpdateDto cmsDto)
        {
            var cms = _objectMapper.Map<CMSContent>(cmsDto);

            await _cmsRepository.InsertOrUpdateAsync(cms);
        }
    }
}
