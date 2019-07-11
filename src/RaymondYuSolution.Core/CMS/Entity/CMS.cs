using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RaymondYuSolution.CMS.Entity
{
    public class CMSContent : FullAuditedEntity<int>, IMustHaveTenant
    {
        [Required]
        public string PageName { get; set; }

        public string PageContent { get; set; }

        public int TenantId { get; set; }
    }
}
