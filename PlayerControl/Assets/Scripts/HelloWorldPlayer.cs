// Network Code
using MLAPI;
using MLAPI.Messaging;
using MLAPI.NetworkVariable;
using UnityEngine;

namespace HelloWorld
{
    public class HelloWorldPlayer : NetworkBehaviour

    {
        public NetworkVariableVector3 Position = new NetworkVariableVector3(new NetworkVariableSettings

        {
            WritePermission = NetworkVariablePermission.ServerOnly,
            ReadPermission = NetworkVariablePermission.Everyone
        });

        public override void NetworkStart()
        {
            AllowControl();
        }

        public void AllowControl()
        {
            if (NetworkManager.Singleton.IsServer)
            {
               /*
                Vector3 Hostposition = new Vector3(900, 7.61f, 954.83f);
                Position.Value = Hostposition;

                
                 transform.position = HostPosition();

                 var randomPosition = GetRandomPositionOnPlane();
                 transform.position = randomPosition;
                 Position.Value = randomPosition;
                */

            }
            else
            {
                // SubmitPositionRequestServerRpc();
            }
        }

        [ServerRpc]
        void SubmitPositionRequestServerRpc(ServerRpcParams rpcParams = default)
        {
            //Position.Value = GetRandomPositionOnPlane();
        }

        /*
        static Vector3 GetRandomPositionOnPlane()
        {
            return new Vector3(Random.Range(963.49f, 965.49f), 7.61f, 954.83f);
        }

        static Vector3 HostPosition()
        {
            return new Vector3(900, 7.61f, 954.83f);
        }
        */

        void Update()
        {

        }
        
    }
}