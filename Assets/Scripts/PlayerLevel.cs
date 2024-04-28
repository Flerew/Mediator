using UnityEngine;

public class PlayerLevel
{
    public int Level { get; private set; }

    public void LevelUp()
    {
        Level++;
    }
}
