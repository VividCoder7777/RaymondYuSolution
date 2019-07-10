using Abp.AutoMapper;
using RaymondYuSolution.Authentication.External;

namespace RaymondYuSolution.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
