﻿using System;
using System.Collections.Generic;
using Bookva.Common;

namespace Bookva.Web.Models
{
    public class WorkViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Extract1 { get; set; }
        public string Extract2 { get; set; }
        public string Extract3 { get; set; }
        public DateTime DateAdded { get; set; }
        public short? YearCreated { get; set; }
        public WorkStatus Status { get; set; }
        public string Text { get; set; }
        public bool IsAnonymous { get; set; }
        public string CoverSource { get; set; }
        public string PreviewCoverSource { get; set; }

        public IEnumerable<AuthorPreviewViewModel> Authors { get; set; }
        public IEnumerable<GenreViewModel> Genres { get; set; }
        public IEnumerable<KeywordViewModel> Keywords { get; set; }
        public IEnumerable<ReviewViewModel> Reviews { get; set; }
        public int TotalVotes { get; set; }
        public float AverageRating { get; set; }
        public byte? CurrentUserVote { get; set; }
    }

    public class WorkEditViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Extract1 { get; set; }
        public string Extract2 { get; set; }
        public string Extract3 { get; set; }
        public short? YearCreated { get; set; }
        public WorkStatus Status { get; set; }
        public string Text { get; set; }
        public bool IsAnonymous { get; set; }
        public string CoverSource { get; set; }
        public string PreviewCoverSource { get; set; }

        public IEnumerable<int> AuthorIds { get; set; }
        public IEnumerable<GenreViewModel> Genres { get; set; }
        public IEnumerable<KeywordViewModel> Keywords { get; set; }
    }

    public class WorkPreviewViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public WorkStatus Status { get; set; }
        public bool IsAnonymous { get; set; }
        public string CoverSource { get; set; }
        public string PreviewCoverSource { get; set; }
        public float AverageRating { get; set; }

        public IEnumerable<AuthorPreviewViewModel> Authors { get; set; }
    }
}