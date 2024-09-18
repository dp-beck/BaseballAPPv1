using System;
using System.Collections.Generic;
using BaseballApp.Service.Common;

namespace BaseballApp.Service.Models;

public partial class Team : BaseEntity
{
    public string Name { get; set; } = null!;

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}
