using UnityEngine;

namespace UnitySampleAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (NavMeshAgent))]
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class AICharacterControl : MonoBehaviour
    {

        public NavMeshAgent agent { get; private set; } // the navmesh agent required for the path finding
        public ThirdPersonCharacter character { get; private set; } // the character we are controlling
        Vector3 target; // target to aim for
        public float targetChangeTolerance = 1; // distance to target before target can be changed

        // private Vector3 targetPos;

        // Use this for initialization
        private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();
			target = transform.position;
        }


        // Update is called once per frame
        private void Update()
        {
            if (target != null)
            {
                // update the progress if the character has made it to the previous target
                agent.SetDestination(target);
                // update the agents posiiton 
                agent.transform.position = transform.position;

                // use the values to move the character
                character.Move(agent.desiredVelocity, false, false, target);
            }
            else
            {
                // We still need to call the character's move function, but we send zeroed input as the move param.
                character.Move(Vector3.zero, false, false, transform.position + transform.forward*100);

            }
        }

        public void SetTarget(Vector3 target)
        {
            this.target = target;
        }
    }

}
