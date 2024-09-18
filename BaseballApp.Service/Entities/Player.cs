using System;
using System.Collections.Generic;
using BaseballApp.Service.Common;

namespace BaseballApp.Service.Models;

public partial class Player : BaseEntity
{
    public string Name { get; set; } = null!;

    public string Position { get; set; } = null!;

    public int TeamId { get; set; }

    public virtual Team Team { get; set; } = null!;
}
