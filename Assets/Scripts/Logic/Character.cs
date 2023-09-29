using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
[RequireComponent(typeof(CharacterAnimation))]
public class Character : MonoBehaviour
{
    [SerializeField] private CharacterData characterData;
    [SerializeField] private CharacterMovement _characterMovement;
    [SerializeField] private CharacterAnimation _characterAnimation;

    private void Update()
    {
        _characterAnimation.UpdateAnimations(_characterMovement);
    }

    public void Start()
    {
        _characterMovement.Init(characterData.characterMovementData);
    }

    public void Move(Vector3 destination)
    {
        _characterMovement.Move(destination);
    }
}
