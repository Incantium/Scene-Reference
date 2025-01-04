#if MODULE_REQUIRED
using Incantium.Attributes;

namespace Incantium
{
    public sealed partial class SceneReference : IRequireable
    {
         /// <summary>
         /// Check to see if there is a scene referenced.
         /// </summary>
        public RequireStatus status => scene ? RequireStatus.Found : RequireStatus.Missing;
    }
}
#endif