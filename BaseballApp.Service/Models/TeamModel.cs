using System;

namespace BaseballApp.Service.Models;

public class TeamModel
{
    public string? Name { get; set; }
    public string? City { get; set; }
    public List<PlayerModel>? Players { get; set; }
}
