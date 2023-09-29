using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private int _walkAnimation;

    private void Awake()
    {
        _walkAnimation = Animator.StringToHash("speed");
    }

    public void UpdateAnimations(CharacterMovement characterMovement)
    {
        _animator.SetFloat(_walkAnimation, characterMovement.CurrentSpeed);
    }
}
