using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RaymondYuSolution.CMS.Dto
{
    public class CMSDto : EntityDto<int>
    {   
        [Required]
        public string PageName { get; set; }
      
        public string PageContent { get; set; }
    }
}
