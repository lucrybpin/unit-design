using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;

    private float _currentSpeed;

    public float CurrentSpeed
    {
        get { 
            return _agent.velocity.magnitude; 
        }
        set { _currentSpeed = value; }
    }



    public void Init(CharacterMovementData characterMovementData)
    {
        _agent.speed = characterMovementData.speed;
        _agent.angularSpeed= characterMovementData.angularSpeed;
        _agent.acceleration = characterMovementData.acceleration;
    }

    public void Move(Vector3 destination)
    {
        _agent.destination = destination;
    }
    
}
