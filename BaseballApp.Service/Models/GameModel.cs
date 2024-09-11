using System;

namespace BaseballApp.Service.Models;

public class GameModel
{
public TeamModel[] Teams { get; set; } = new TeamModel[2];
public DateTime StartingTime { get; set; }
public string Location  { get; set; }
}
