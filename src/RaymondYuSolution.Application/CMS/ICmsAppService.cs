using Abp.Application.Services;
using RaymondYuSolution.CMS.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RaymondYuSolution.CMS
{
    public interface ICMSAppService : IApplicationService
    {
        Task<CMSDto> GetCMSContent(int pageId);
        Task<CMSDto> InsertOrUpdateCMSContent(CMSInsertOrUpdateDto cmsDto);
        Task<ICollection<CMSDto>> GetAll();
    }
}
