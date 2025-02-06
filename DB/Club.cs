using System;
using System.Collections.Generic;

namespace DB;

public partial class Club
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int IdBoss { get; set; }

    public virtual User IdBossNavigation { get; set; } = null!;
}
