using api.Dtos.Commentt;
using api.Models;
using System.Runtime.CompilerServices;

namespace api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                StockId = commentModel.StockId
            };
        }

        public static Comment ToCommentFromCreate(this CreateCommentDto commentDto, int stockId)
        {
            return new Comment
            {
                
                Title = commentDto.Title,
                Content = commentDto.Content,
                StockId =stockId
            };
        }
        public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto commentDto)
        {
            return new Comment
            {

                Title = commentDto.Title,
                Content = commentDto.Content,
            };
        }
    }
}

    
