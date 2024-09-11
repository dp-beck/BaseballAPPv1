using System;

namespace BaseballApp.Service.Models;

public class PlayerModel
{
    public string? Name { get; set;}
    public string? Position { get; set;}
    public TeamModel? Team { get; set;} = null;

    public PlayerModel(string name, string position)
    {
        Name = name;
        Position = position;
    }

}
