﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.Blog.Entities.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int CommentCount { get; set; }

        public ArticleDto Article { get; set; }


        public ICollection<ArticleDto> Articles { get; set; }
    }
}
