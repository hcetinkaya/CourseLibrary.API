﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CourseLibrary.API.Entities;

namespace CourseLibrary.API.Models
{
    public class CourseDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Guid AuthorId { get; set; }
    }
}