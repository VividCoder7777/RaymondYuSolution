using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RaymondYuSolution.CMS.Dto;

namespace RaymondYuSolution.CMS
{
    public class CMSAppService : ICMSAppService
    {   


        public CMSAppService()
        {

        }

        public Task<ICollection<CMSDto>> GetAll()
        {
            return null;
        }

        public Task<CMSDto> GetCMSContent(int pageId)
        {
            return null;
        }

        public Task<CMSDto> InsertOrUpdateCMSContent(CMSInsertOrUpdateDto cmsDto)
        {
            return null;
        }
    }
}
