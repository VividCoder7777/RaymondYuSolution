using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using RaymondYuSolution.CMS.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaymondYuSolution.CMS.Dto
{   
    [AutoMap(typeof(CMSContent))]
    public class CMSInsertOrUpdateDto : CMSDto
    {

    }
}
