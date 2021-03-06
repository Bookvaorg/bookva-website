﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookva.BusinessEntities.Author;
using Bookva.Common;

namespace Bookva.BusinessEntities.Work
{
    public class WorkPreviewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsAnonymous { get; set; }
        public string CoverSource { get; set; }
        public string PreviewCoverSource { get; set; }
        public float AverageRating { get; set; }
        public int ReviewsCount{ get; set; }
        public WorkStatus Status { get; set; }
        public IEnumerable<AuthorPreviewModel> Authors { get; set; }
    }
}
