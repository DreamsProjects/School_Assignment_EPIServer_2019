using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace LunaEpi.Models.Media
{
    [ContentType(DisplayName = "Image File",
        GUID = "f0be86ab-3003-4d7a-a5e6-9ee7638c6875",
        Description = "Use this to upload image files.")]
    [MediaDescriptor(ExtensionString = "png,gif,jpg,jpeg")]
    public class ImageFile : ImageData
    {
        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }
    }
}