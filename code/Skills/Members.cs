using System;

namespace Skills;

public class Members
{
    public string Name { get; set; }
    public string Role { get; set; }
    public DateTime JoinedDate { get; set; }

    public Members(string name, string role, DateTime joinedDate)
    {
        Name = name;
        Role = role;
        JoinedDate = joinedDate;
    }

    public override string ToString()
    {
        return $"{Name} - {Role} (Joined: {JoinedDate.ToShortDateString()})";
    }
}
