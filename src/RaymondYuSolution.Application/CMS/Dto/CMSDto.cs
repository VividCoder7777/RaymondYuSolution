using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using RaymondYuSolution.CMS.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RaymondYuSolution.CMS.Dto
{   

    [AutoMap(typeof(CMSContent))]
    public class CMSDto : EntityDto<int>
    {   
        [Required]
        public string PageName { get; set; }
      
        public string PageContent { get; set; }
    }
}
