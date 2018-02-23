using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset = new Vector3(8.0f, 3.3f, -1.0f);


        private void LateUpdate()
        {
            transform.position = target.position + offset;
        }
    }
}
