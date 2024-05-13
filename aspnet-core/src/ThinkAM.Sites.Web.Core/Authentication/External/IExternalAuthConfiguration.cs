using System.Collections.Generic;

namespace ThinkAM.Sites.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
