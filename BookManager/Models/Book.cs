using System.ComponentModel.DataAnnotations;

namespace BookManager.Models
{
    public class Book
    {
        [Display(Name = "主键")]
        public int Id { get; set; } 
        [Display(Name = "书籍名称")]
        [Required(ErrorMessage = "书籍名称必填")]
        public string? Title { get; set; }
        [Display(Name = "作者")]
        [Required(ErrorMessage = "作者必填")]
        public string? Author { get; set; }
        [Display(Name = "出版社")]
        public string? Publisher { get; set; }
        [Display(Name = "出版日期")]
        [DataType(DataType.Date)]
        public DateTime PublishingTime { get; set; } 
        
        [Display(Name = "票价")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
