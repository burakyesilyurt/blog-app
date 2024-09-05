﻿using System.ComponentModel.DataAnnotations;

namespace BlogClient.DTO
{
    public class ArticlePostDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public string? ImageUrl { get; set; }
        public int UserId { get; set; }
        public List<int> CategoryIds { get; set; }
        public List<int> TagIds { get; set; }
    }
}