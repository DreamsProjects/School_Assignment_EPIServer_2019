using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace LunaEpi.Models.Media
{
    [ContentType(DisplayName = "Any File",
        GUID = "386d3aa7-8589-4f3c-b470-20c8852f20ad",
        Description = "Use this to upload any type of file.")]
    public class AnyFile : MediaData
    {
    }
}