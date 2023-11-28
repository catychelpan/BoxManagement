using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BoxManagement.Data
{
	public class ItemModel
	{

        public ItemModel()
        {
            
        }
        public ItemModel(string name,int boxId, string igm)
        {
            this.Name = name;
            this.BoxId = boxId;
            this.ImgURL = igm;

        }

		[Required]
        [NotNull]
		public string? Name { get; set; }

		[Required]
		public int BoxId { get; set; }

        [Required]
        [Url]
        [NotNull]
        public string? ImgURL { get; set; }
    }
}
