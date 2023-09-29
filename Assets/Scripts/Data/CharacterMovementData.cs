using UnityEngine;

[CreateAssetMenu(fileName = "CharacterMovementData", menuName = "Create/Character/Movement")]
public class CharacterMovementData : ScriptableObject
{
    public float speed;
    public float angularSpeed;
    public float acceleration;
}
