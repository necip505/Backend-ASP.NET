using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Commentt
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5,ErrorMessage="Title must be greater than 5 characters")]
        [MaxLength(100, ErrorMessage = "Title must be less than 100 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Content must be greater than 5 characters")]
        [MaxLength(100, ErrorMessage = "Content must be less than 100 characters")]
        public string Content { get; set; } = string.Empty;
    }
}
