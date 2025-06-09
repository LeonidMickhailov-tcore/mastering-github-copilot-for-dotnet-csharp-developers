using System;

namespace Skills;

public class Comment
{
    // create a method that generates a comment for a given skill
    public static string GenerateComment(string skillName, string commentText, string userName)
    {
        return $"{userName} commented on {skillName}: \"{commentText}\"";
    }

}
