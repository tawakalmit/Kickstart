using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Kickstart.Models.Blocks
{
    [ContentType(
        DisplayName = "Main Article Banner",
        GUID = "6B19AF34-84DC-43A1-8F82-4423B7FB8971")]
    public class MainArticleBanner : BlockData
    {
        [Display(
            Name = "Headline",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string? Headline { get; set; }

        [Display(
            Name = "Description",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString? Description { get; set; }

        [Display(
            Name = "Image",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? Image { get; set; }
    }
}
