using System.ComponentModel.DataAnnotations;

namespace Kickstart.Models.Pages
{

    [ContentType(
            DisplayName = "General Content",
            Description = "General content",
            GroupName = "General",
            GUID = "BB845C5B-E213-49F5-9ADA-8C1848080201"
        )]
    public class GeneralContent : MetadataHead
    {
        [Display(
            Name = "Headline",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string? Headline { get; set; }

        [Display(
            Name = "Headline Slug",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string? HeadlineSlug { get; set; }

        [Display(
            Name = "Body",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual XhtmlString? Body { get; set; }
    }
}
