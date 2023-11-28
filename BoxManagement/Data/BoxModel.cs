using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BoxManagement.Data
{
	public class BoxModel
	{
        public BoxModel()
        {
            
        }
        public BoxModel(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        [Required]
        public int Id { get; set; }

		[Required]
		[StringLength(100)]
        [NotNull]
		public string Name { get; set; }

	}
}
