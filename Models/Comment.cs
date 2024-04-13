using System;
using System.Collections.Generic;

namespace CodeBE_COMP1640.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public int ArticleId { get; set; }

    public int UserId { get; set; }

    public string CommentContent { get; set; } = null!;

    public DateTime? CommentTime { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
