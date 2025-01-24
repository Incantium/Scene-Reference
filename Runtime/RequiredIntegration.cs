#if MODULE_REQUIRED
using Incantium.Attributes;

namespace Incantium
{
    /// <summary>
    /// Class handling the integration between <see cref="SceneReference"/> and <see cref="Required"/>.
    /// </summary>
    public sealed partial class SceneReference : IRequireable
    {
         /// <summary>
         /// Check to see if there is a scene referenced.
         /// </summary>
        public RequireStatus status => scene ? RequireStatus.Found : RequireStatus.Missing;
    }
}
#endif