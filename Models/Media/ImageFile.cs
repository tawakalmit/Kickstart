using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace Kickstart.Models.Media
{
    [ContentType(
        DisplayName = "Image File",
        GUID = "83C1AA35-A472-41A8-B1B0-9B49A79740E1")]
    [MediaDescriptor(ExtensionString = "jgp,jpeg,png")]
    public class ImageFile : ImageData
    {
        [Display(
            Name = "Alternate Text")]
        public virtual string? AlternateText { get; set; }
    }
}
